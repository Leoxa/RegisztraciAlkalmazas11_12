namespace RegisztracioAlkalmazas
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.hozzaad = new System.Windows.Forms.Button();
            this.betolt = new System.Windows.Forms.Button();
            this.mentes = new System.Windows.Forms.Button();
            this.nev = new System.Windows.Forms.TextBox();
            this.ujhobbi = new System.Windows.Forms.TextBox();
            this.hobbik = new System.Windows.Forms.ListBox();
            this.szdatum = new System.Windows.Forms.DateTimePicker();
            this.F = new System.Windows.Forms.RadioButton();
            this.N = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // hozzaad
            // 
            this.hozzaad.Location = new System.Drawing.Point(190, 165);
            this.hozzaad.Name = "hozzaad";
            this.hozzaad.Size = new System.Drawing.Size(75, 23);
            this.hozzaad.TabIndex = 0;
            this.hozzaad.Text = "Hozzáad";
            this.hozzaad.UseVisualStyleBackColor = true;
            this.hozzaad.Click += new System.EventHandler(this.hozzaad_Click);
            // 
            // betolt
            // 
            this.betolt.Location = new System.Drawing.Point(190, 194);
            this.betolt.Name = "betolt";
            this.betolt.Size = new System.Drawing.Size(75, 23);
            this.betolt.TabIndex = 1;
            this.betolt.Text = "Betölt";
            this.betolt.UseVisualStyleBackColor = true;
            this.betolt.Click += new System.EventHandler(this.betolt_Click);
            // 
            // mentes
            // 
            this.mentes.Location = new System.Drawing.Point(99, 194);
            this.mentes.Name = "mentes";
            this.mentes.Size = new System.Drawing.Size(75, 23);
            this.mentes.TabIndex = 2;
            this.mentes.Text = "mentés";
            this.mentes.UseVisualStyleBackColor = true;
            this.mentes.Click += new System.EventHandler(this.mentes_Click);
            // 
            // nev
            // 
            this.nev.Location = new System.Drawing.Point(62, 34);
            this.nev.Name = "nev";
            this.nev.Size = new System.Drawing.Size(100, 20);
            this.nev.TabIndex = 3;
            // 
            // ujhobbi
            // 
            this.ujhobbi.Location = new System.Drawing.Point(190, 139);
            this.ujhobbi.Name = "ujhobbi";
            this.ujhobbi.Size = new System.Drawing.Size(100, 20);
            this.ujhobbi.TabIndex = 4;
            // 
            // hobbik
            // 
            this.hobbik.FormattingEnabled = true;
            this.hobbik.Location = new System.Drawing.Point(190, 38);
            this.hobbik.Name = "hobbik";
            this.hobbik.Size = new System.Drawing.Size(120, 95);
            this.hobbik.TabIndex = 5;
            // 
            // szdatum
            // 
            this.szdatum.Location = new System.Drawing.Point(62, 73);
            this.szdatum.Name = "szdatum";
            this.szdatum.Size = new System.Drawing.Size(122, 20);
            this.szdatum.TabIndex = 6;
            // 
            // F
            // 
            this.F.AutoSize = true;
            this.F.Location = new System.Drawing.Point(62, 115);
            this.F.Name = "F";
            this.F.Size = new System.Drawing.Size(31, 17);
            this.F.TabIndex = 7;
            this.F.TabStop = true;
            this.F.Text = "F";
            this.F.UseVisualStyleBackColor = true;
            // 
            // N
            // 
            this.N.AutoSize = true;
            this.N.Location = new System.Drawing.Point(99, 115);
            this.N.Name = "N";
            this.N.Size = new System.Drawing.Size(33, 17);
            this.N.TabIndex = 8;
            this.N.TabStop = true;
            this.N.Text = "N";
            this.N.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(190, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Kedvenc hobbi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Név";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(2, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Sz. dátum";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Nem";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(128, 146);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Új hobbi";
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileDialog1_FileOk);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(366, 261);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.N);
            this.Controls.Add(this.F);
            this.Controls.Add(this.szdatum);
            this.Controls.Add(this.hobbik);
            this.Controls.Add(this.ujhobbi);
            this.Controls.Add(this.nev);
            this.Controls.Add(this.mentes);
            this.Controls.Add(this.betolt);
            this.Controls.Add(this.hozzaad);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button hozzaad;
        private System.Windows.Forms.Button betolt;
        private System.Windows.Forms.Button mentes;
        private System.Windows.Forms.TextBox nev;
        private System.Windows.Forms.TextBox ujhobbi;
        private System.Windows.Forms.ListBox hobbik;
        private System.Windows.Forms.DateTimePicker szdatum;
        private System.Windows.Forms.RadioButton F;
        private System.Windows.Forms.RadioButton N;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

