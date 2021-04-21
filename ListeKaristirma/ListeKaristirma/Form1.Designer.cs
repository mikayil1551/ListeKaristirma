namespace ListeKaristirma
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnKaristir = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "İsim";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(76, 27);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 1;
            // 
            // btnEkle
            // 
            this.btnEkle.BackColor = System.Drawing.SystemColors.Window;
            this.btnEkle.Location = new System.Drawing.Point(232, 25);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(75, 23);
            this.btnEkle.TabIndex = 2;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = false;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            this.btnEkle.MouseLeave += new System.EventHandler(this.btnEkle_MouseLeave);
            this.btnEkle.MouseHover += new System.EventHandler(this.btnEkle_MouseHover);
            // 
            // btnSil
            // 
            this.btnSil.BackColor = System.Drawing.SystemColors.Window;
            this.btnSil.Location = new System.Drawing.Point(232, 61);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(75, 23);
            this.btnSil.TabIndex = 3;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = false;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            this.btnSil.MouseLeave += new System.EventHandler(this.btnSil_MouseLeave);
            this.btnSil.MouseHover += new System.EventHandler(this.btnSil_MouseHover);
            // 
            // btnKaristir
            // 
            this.btnKaristir.BackColor = System.Drawing.SystemColors.Window;
            this.btnKaristir.Location = new System.Drawing.Point(232, 106);
            this.btnKaristir.Name = "btnKaristir";
            this.btnKaristir.Size = new System.Drawing.Size(75, 23);
            this.btnKaristir.TabIndex = 4;
            this.btnKaristir.Text = "Karistir";
            this.btnKaristir.UseVisualStyleBackColor = false;
            this.btnKaristir.Click += new System.EventHandler(this.btnKaristir_Click);
            this.btnKaristir.MouseLeave += new System.EventHandler(this.btnKaristir_MouseLeave);
            this.btnKaristir.MouseHover += new System.EventHandler(this.btnKaristir_MouseHover);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(16, 70);
            this.listBox1.Name = "listBox1";
            this.listBox1.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listBox1.Size = new System.Drawing.Size(160, 134);
            this.listBox1.TabIndex = 5;
            this.listBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.listBox1_KeyDown);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btnKaristir);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnKaristir;
        private System.Windows.Forms.ListBox listBox1;
    }
}

