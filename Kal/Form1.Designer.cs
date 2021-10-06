
namespace Kal
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
            this.toperasi = new System.Windows.Forms.Label();
            this.tnilai1 = new System.Windows.Forms.Label();
            this.cmb1 = new System.Windows.Forms.ComboBox();
            this.tBox1 = new System.Windows.Forms.TextBox();
            this.tBox2 = new System.Windows.Forms.TextBox();
            this.tnilai2 = new System.Windows.Forms.Label();
            this.tBox3Teks = new System.Windows.Forms.TextBox();
            this.thasil = new System.Windows.Forms.Label();
            this.btnhitung = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // toperasi
            // 
            this.toperasi.AutoSize = true;
            this.toperasi.Location = new System.Drawing.Point(26, 24);
            this.toperasi.Name = "toperasi";
            this.toperasi.Size = new System.Drawing.Size(41, 13);
            this.toperasi.TabIndex = 0;
            this.toperasi.Text = "operasi";
            this.toperasi.Click += new System.EventHandler(this.label1_Click);
            // 
            // tnilai1
            // 
            this.tnilai1.AutoSize = true;
            this.tnilai1.Location = new System.Drawing.Point(26, 71);
            this.tnilai1.Name = "tnilai1";
            this.tnilai1.Size = new System.Drawing.Size(32, 13);
            this.tnilai1.TabIndex = 1;
            this.tnilai1.Text = "nilaiA";
            // 
            // cmb1
            // 
            this.cmb1.FormattingEnabled = true;
            this.cmb1.Location = new System.Drawing.Point(94, 16);
            this.cmb1.Name = "cmb1";
            this.cmb1.Size = new System.Drawing.Size(121, 21);
            this.cmb1.TabIndex = 2;
            // 
            // tBox1
            // 
            this.tBox1.Location = new System.Drawing.Point(94, 64);
            this.tBox1.Name = "tBox1";
            this.tBox1.Size = new System.Drawing.Size(100, 20);
            this.tBox1.TabIndex = 3;
            // 
            // tBox2
            // 
            this.tBox2.Location = new System.Drawing.Point(94, 106);
            this.tBox2.Name = "tBox2";
            this.tBox2.Size = new System.Drawing.Size(100, 20);
            this.tBox2.TabIndex = 5;
            // 
            // tnilai2
            // 
            this.tnilai2.AutoSize = true;
            this.tnilai2.Location = new System.Drawing.Point(26, 113);
            this.tnilai2.Name = "tnilai2";
            this.tnilai2.Size = new System.Drawing.Size(32, 13);
            this.tnilai2.TabIndex = 4;
            this.tnilai2.Text = "nilaiB";
            // 
            // tBox3Teks
            // 
            this.tBox3Teks.Location = new System.Drawing.Point(94, 148);
            this.tBox3Teks.Name = "tBox3Teks";
            this.tBox3Teks.Size = new System.Drawing.Size(100, 20);
            this.tBox3Teks.TabIndex = 7;
            this.tBox3Teks.TextChanged += new System.EventHandler(this.tBox3_TextChanged);
            // 
            // thasil
            // 
            this.thasil.AutoSize = true;
            this.thasil.Location = new System.Drawing.Point(26, 155);
            this.thasil.Name = "thasil";
            this.thasil.Size = new System.Drawing.Size(28, 13);
            this.thasil.TabIndex = 6;
            this.thasil.Text = "hasil";
            this.thasil.Click += new System.EventHandler(this.thasil_Click);
            // 
            // btnhitung
            // 
            this.btnhitung.Location = new System.Drawing.Point(94, 210);
            this.btnhitung.Name = "btnhitung";
            this.btnhitung.Size = new System.Drawing.Size(75, 23);
            this.btnhitung.TabIndex = 8;
            this.btnhitung.Text = "hitung";
            this.btnhitung.UseVisualStyleBackColor = true;
            this.btnhitung.Click += new System.EventHandler(this.btnhitung_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnhitung);
            this.Controls.Add(this.tBox3Teks);
            this.Controls.Add(this.thasil);
            this.Controls.Add(this.tBox2);
            this.Controls.Add(this.tnilai2);
            this.Controls.Add(this.tBox1);
            this.Controls.Add(this.cmb1);
            this.Controls.Add(this.tnilai1);
            this.Controls.Add(this.toperasi);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label toperasi;
        private System.Windows.Forms.Label tnilai1;
        private System.Windows.Forms.ComboBox cmb1;
        private System.Windows.Forms.TextBox tBox1;
        private System.Windows.Forms.TextBox tBox2;
        private System.Windows.Forms.Label tnilai2;
        private System.Windows.Forms.TextBox tBox3Teks;
        private System.Windows.Forms.Label thasil;
        private System.Windows.Forms.Button btnhitung;
    }
}

