namespace RysowanieOdcinka
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.EFLARB = new System.Windows.Forms.RadioButton();
            this.MidpointRB = new System.Windows.Forms.RadioButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cleanB = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.startTB = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.endTB = new System.Windows.Forms.TextBox();
            this.DrawB = new System.Windows.Forms.Button();
            this.HelpB = new System.Windows.Forms.Button();
            this.CloseB = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // EFLARB
            // 
            this.EFLARB.AutoSize = true;
            this.EFLARB.Checked = true;
            this.EFLARB.Location = new System.Drawing.Point(5, 27);
            this.EFLARB.Margin = new System.Windows.Forms.Padding(2);
            this.EFLARB.Name = "EFLARB";
            this.EFLARB.Size = new System.Drawing.Size(55, 17);
            this.EFLARB.TabIndex = 1;
            this.EFLARB.TabStop = true;
            this.EFLARB.Text = "EFLA";
            this.EFLARB.UseVisualStyleBackColor = true;
            this.EFLARB.CheckedChanged += new System.EventHandler(this.EFLARB_CheckedChanged);
            // 
            // MidpointRB
            // 
            this.MidpointRB.AutoSize = true;
            this.MidpointRB.Location = new System.Drawing.Point(5, 48);
            this.MidpointRB.Margin = new System.Windows.Forms.Padding(2);
            this.MidpointRB.Name = "MidpointRB";
            this.MidpointRB.Size = new System.Drawing.Size(149, 17);
            this.MidpointRB.TabIndex = 2;
            this.MidpointRB.Text = "z punktem środkowym";
            this.MidpointRB.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Location = new System.Drawing.Point(0, -2);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(555, 496);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            // 
            // cleanB
            // 
            this.cleanB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cleanB.Location = new System.Drawing.Point(589, 98);
            this.cleanB.Margin = new System.Windows.Forms.Padding(2);
            this.cleanB.Name = "cleanB";
            this.cleanB.Size = new System.Drawing.Size(125, 29);
            this.cleanB.TabIndex = 8;
            this.cleanB.Text = "Wyczyść płótno";
            this.cleanB.UseVisualStyleBackColor = true;
            this.cleanB.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.EFLARB);
            this.groupBox1.Controls.Add(this.MidpointRB);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox1.Location = new System.Drawing.Point(560, 377);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(175, 84);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Algorytmy:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.DrawB);
            this.groupBox2.Controls.Add(this.endTB);
            this.groupBox2.Controls.Add(this.textBox5);
            this.groupBox2.Controls.Add(this.startTB);
            this.groupBox2.Controls.Add(this.textBox3);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox2.Location = new System.Drawing.Point(560, 186);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(175, 160);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Rysuj:";
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.SystemColors.Control;
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox3.Location = new System.Drawing.Point(40, 19);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(100, 13);
            this.textBox3.TabIndex = 0;
            this.textBox3.Text = "Początek";
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // startTB
            // 
            this.startTB.Location = new System.Drawing.Point(40, 38);
            this.startTB.Name = "startTB";
            this.startTB.Size = new System.Drawing.Size(100, 20);
            this.startTB.TabIndex = 1;
            // 
            // textBox5
            // 
            this.textBox5.BackColor = System.Drawing.SystemColors.Control;
            this.textBox5.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox5.Location = new System.Drawing.Point(40, 73);
            this.textBox5.Name = "textBox5";
            this.textBox5.ReadOnly = true;
            this.textBox5.Size = new System.Drawing.Size(100, 13);
            this.textBox5.TabIndex = 2;
            this.textBox5.Text = "Koniec";
            this.textBox5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // endTB
            // 
            this.endTB.Location = new System.Drawing.Point(40, 92);
            this.endTB.Name = "endTB";
            this.endTB.Size = new System.Drawing.Size(100, 20);
            this.endTB.TabIndex = 3;
            // 
            // DrawB
            // 
            this.DrawB.Location = new System.Drawing.Point(40, 131);
            this.DrawB.Name = "DrawB";
            this.DrawB.Size = new System.Drawing.Size(100, 23);
            this.DrawB.TabIndex = 4;
            this.DrawB.Text = "Narysuj";
            this.DrawB.UseVisualStyleBackColor = true;
            this.DrawB.Click += new System.EventHandler(this.button2_Click);
            // 
            // HelpB
            // 
            this.HelpB.Location = new System.Drawing.Point(565, 21);
            this.HelpB.Name = "HelpB";
            this.HelpB.Size = new System.Drawing.Size(75, 23);
            this.HelpB.TabIndex = 12;
            this.HelpB.Text = "Pomoc";
            this.HelpB.UseVisualStyleBackColor = true;
            this.HelpB.Click += new System.EventHandler(this.HelpB_Click);
            // 
            // CloseB
            // 
            this.CloseB.Location = new System.Drawing.Point(651, 21);
            this.CloseB.Name = "CloseB";
            this.CloseB.Size = new System.Drawing.Size(75, 23);
            this.CloseB.TabIndex = 13;
            this.CloseB.Text = "Zamknij";
            this.CloseB.UseVisualStyleBackColor = true;
            this.CloseB.Click += new System.EventHandler(this.CloseB_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(738, 495);
            this.Controls.Add(this.CloseB);
            this.Controls.Add(this.HelpB);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cleanB);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Rysowanie odcinków";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.RadioButton EFLARB;
        private System.Windows.Forms.RadioButton MidpointRB;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button cleanB;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox endTB;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox startTB;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button DrawB;
        private System.Windows.Forms.Button HelpB;
        private System.Windows.Forms.Button CloseB;
    }
}

