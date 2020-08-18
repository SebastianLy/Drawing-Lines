# Drawing Lines

## Technologie
* **C# 8.0**,
* **.NET WinForms**.

## Informacje
Program pozwala na rysowanie linii na dwa sposoby: za pomocą myszki lub podając współrzędne początku i końca linii. Przy rysowaniu linii mamy do wyboru dwa algorytmy: 
Bresenhama (z punktem środkowym) lub EFLA (Extremely Fast Line Algorithm).

### Algorytm Bresenhama:
<pre><code>
// x0 , y0 - współrzędne początku odcinka
// x1 , y1 - współrzędne końca odcinka
int d, dx, dy, incrNE, incrE, xi, yi;
int x = x0, y = y0;
// ustalenie kierunku rysowania
dx = x0 < x1 ? x1 - x0 : x0 - x1;
dy = y0 < y1 ? y1 - y0 : y0 - y1;
xi = x0 < x1 ? 1 : -1;
yi = y0 < y1 ? 1 : -1;
// pierwszy piksel
bitmap.SetPixel(x, y, color);
// oś wiodąca OX
if (dx > dy)
{
    incrNE = (dy - dx) * 2;
    incrE = dy * 2;
    d = incrE - dx;
    while (x != x1)
    {
        if (d >= 0)
        {
            x += xi;
            y += yi;
            d += incrNE;
        }
        else
        {
            d += incrE;
            x += xi;
        }
        bitmap.SetPixel(x, y, color);
    }
}
// oś wiodąca OY
else
{
    incrNE = (dx - dy) * 2;
    incrE = dx * 2;
    d = incrE - dy;
    while (y != y1)
    {
        if (d >= 0)
        {
            x += xi;
            y += yi;
            d += incrNE;
        }
        else
        {
            d += incrE;
            y += yi;
        }
        bitmap.SetPixel(x, y, color);
    }
}
</code></pre>

### Algorytm EFLA:
<pre><code>
// x0 , y0 - współrzędne początku odcinka
// x1 , y1 - współrzędne końca odcinka
int dx = Math.Abs(x1 - x0), sx = x0 < x1 ? 1 : -1;
int dy = Math.Abs(y1 - y0), sy = y0 < y1 ? 1 : -1;
double vy = 32.768 + 65.536 * y0;
double iy = 65.536 * dy / dx;
double vx = 32.768 + 65.536 * x0;
double ix = 65.536 * dx / dy;
iy = y0 < y1 ? iy : -iy;
ix = x0 < x1 ? ix : -ix;
int x = x0;
int y = y0;
// oś wiodąca OY
if (dy > dx)
{
    while (y != y1)
    {
        bitmap.SetPixel((int)Math.Round(vx / 65.536), y, color);
        vx += ix;
        y += sy;
    }
}
// oś wiodąca OX
else
{
    while (x != x1)
    {
        bitmap.SetPixel(x, (int)Math.Round(vy / 65.536), color);
        vy += iy;
        x += sx;
    }
}
</code></pre>
