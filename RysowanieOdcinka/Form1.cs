using System;
using System.Drawing;
using System.Windows.Forms;

namespace RysowanieOdcinka
{
    public partial class Form1 : Form
    {
        Bitmap mainbitmap;
        Bitmap copybitmap;
        Point start = new Point(0, 0);
        Point end = new Point(0, 0);

        public Form1()
        {
            InitializeComponent();
            mainbitmap = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            copybitmap = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            pictureBox1.Image = mainbitmap;
        }

        public enum Algorithms
        {
            EFLA, MidpointLine
        }

        private Algorithms currAlgorithms = Algorithms.EFLA;

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < mainbitmap.Width; i++)
            {
                for (int j = 0; j < mainbitmap.Height; j++)
                {
                    mainbitmap.SetPixel(i, j, Color.White);
                    copybitmap.SetPixel(i, j, Color.White);
                }
            }
            pictureBox1.Image = mainbitmap;
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {            
            if (e.Button == MouseButtons.Left)
            {
                if (end.X < pictureBox1.Image.Width && end.X > 0 && end.Y > 0 && end.Y < pictureBox1.Image.Height)
                {
                    pictureBox1.Image = copybitmap;
                    Clean(start, end, copybitmap);
                    end = PointToClient(Cursor.Position);
                    switch (currAlgorithms)
                    {
                        case Algorithms.EFLA:
                            EFLA(start.X, start.Y, end.X, end.Y, Color.Blue, copybitmap);
                            break;
                        case Algorithms.MidpointLine:
                            MidpointLine(start.X, start.Y, end.X, end.Y, Color.Blue, copybitmap);
                            break;
                        default:
                            return;
                    }
                }
            }
            if (e.Button != MouseButtons.Left)
            {
                if (start != end)
                {
                    switch (currAlgorithms)
                    {
                        case Algorithms.EFLA:
                            EFLA(start.X, start.Y, end.X, end.Y, Color.Blue, mainbitmap);
                            break;
                        case Algorithms.MidpointLine:
                            MidpointLine(start.X, start.Y, end.X, end.Y, Color.Blue, mainbitmap);
                            break;
                        default:
                            return;
                    }
                    copybitmap = (Bitmap)mainbitmap.Clone();
                }
                pictureBox1.Image = mainbitmap;
                start = PointToClient(Cursor.Position);
                end = start;
            }
        }
        
        public void Clean(Point start, Point end, Bitmap bitmap)
        {
            if (end.X < bitmap.Width && end.X > 0 && end.Y > 0 && end.Y < bitmap.Height)
            {
                switch (currAlgorithms)
                {
                    case Algorithms.EFLA:
                        EFLA(start.X, start.Y, end.X, end.Y, Color.White, bitmap);
                        break;
                    case Algorithms.MidpointLine:
                        MidpointLine(start.X, start.Y, end.X, end.Y, Color.White, bitmap);
                        break;
                    default:
                        return;
                }
            }
        }
        
        private void EFLA(int x0, int y0, int x1, int y1, Color color, Bitmap bitmap)
        {
            try
            {
                if (x0 < bitmap.Width && x0 > 0 && y0 > 0 && y0 < bitmap.Height)
                {
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
                    if (dy > dx)
                    {
                        while (y != y1)
                        {
                            bitmap.SetPixel((int)Math.Round(vx / 65.536), y, color);
                            vx += ix;
                            y += sy;
                        }
                    }
                    else
                    {
                        while (x != x1)
                        {
                            bitmap.SetPixel(x, (int)Math.Round(vy / 65.536), color);
                            vy += iy;
                            x += sx;
                        }
                    }
                }
            }
            catch (ArgumentOutOfRangeException) { }
        }

        private void MidpointLine(int x0, int y0, int x1, int y1, Color color, Bitmap bitmap)
        {
            try
            {
                if (x0 < bitmap.Width && x0 > 0 && y0 > 0 && y0 < bitmap.Height)
                {
                    int d, dx, dy, incrNE, incrE, xi, yi;
                    int x = x0, y = y0;
                    dx = x0 < x1 ? x1 - x0 : x0 - x1;
                    dy = y0 < y1 ? y1 - y0 : y0 - y1;
                    xi = x0 < x1 ? 1 : -1;
                    yi = y0 < y1 ? 1 : -1;
                    bitmap.SetPixel(x, y, color);
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
                }
            }
            catch (ArgumentOutOfRangeException) { }         
        }

        private void EFLARB_CheckedChanged(object sender, EventArgs e)
        {
            if (EFLARB.Checked)
            {
                currAlgorithms = Algorithms.EFLA;
            }
            else
            {
                currAlgorithms = Algorithms.MidpointLine;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string startS = startTB.Text + ".";
            string endS = endTB.Text + ".";
            try
            {
                start.X = Convert.ToInt32(startS.Substring(0, startS.IndexOf(",")));
                start.Y = Convert.ToInt32(startS.Substring(startS.IndexOf(",") + 1, startS.IndexOf(".") - startS.IndexOf(",") - 1));
                end.X = Convert.ToInt32(endS.Substring(0, endS.IndexOf(",")));
                end.Y = Convert.ToInt32(endS.Substring(endS.IndexOf(",") + 1, endS.IndexOf(".") - endS.IndexOf(",") - 1));
                if (end.X < pictureBox1.Image.Width && end.X > 0 && end.Y > 0 && end.Y < pictureBox1.Image.Height)
                {
                    pictureBox1.Image = mainbitmap;
                    switch (currAlgorithms)
                    {
                        case Algorithms.EFLA:
                            EFLA(start.X, start.Y, end.X, end.Y, Color.Blue, mainbitmap);
                            break;
                        case Algorithms.MidpointLine:
                            MidpointLine(start.X, start.Y, end.X, end.Y, Color.Blue, mainbitmap);
                            break;
                        default:
                            return;
                    }

                }
            }
            catch (ArgumentOutOfRangeException) { }
            catch (FormatException) { }
        }

        private void HelpB_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Są dwie opcje rysowania. Bezpośrednio na płótnie naciskając i przytrzymując LPM, dzięki czemu rysujesz odcinek." +
                " Druga opcja to podanie wpółrzędnych początka oraz końca odcinka, które muszą być oddzielone przecinkiem.");
        }

        private void CloseB_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
