namespace ApiSample
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.textBox_kereses = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.textBox_mennyiseg = new System.Windows.Forms.TextBox();
            this.label_1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button_plus = new System.Windows.Forms.Button();
            this.button_minus = new System.Windows.Forms.Button();
            this.button_megse = new System.Windows.Forms.Button();
            this.button_mentes = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox_kereses
            // 
            this.textBox_kereses.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(131)))), ((int)(((byte)(85)))));
            this.textBox_kereses.Location = new System.Drawing.Point(12, 12);
            this.textBox_kereses.Name = "textBox_kereses";
            this.textBox_kereses.Size = new System.Drawing.Size(217, 20);
            this.textBox_kereses.TabIndex = 0;
            this.textBox_kereses.TextChanged += new System.EventHandler(this.textBox_kereses_TextChanged_1);
//            this.textBox_kereses.Leave += new System.EventHandler(this.textBox_kereses_Leave);
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(131)))), ((int)(((byte)(85)))));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(12, 55);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(217, 316);
            this.listBox1.TabIndex = 1;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged_1);
            // 
            // textBox_mennyiseg
            // 
            this.textBox_mennyiseg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(131)))), ((int)(((byte)(85)))));
            this.textBox_mennyiseg.Location = new System.Drawing.Point(306, 229);
            this.textBox_mennyiseg.Name = "textBox_mennyiseg";
            this.textBox_mennyiseg.Size = new System.Drawing.Size(100, 20);
            this.textBox_mennyiseg.TabIndex = 2;
            // 
            // label_1
            // 
            this.label_1.AutoSize = true;
            this.label_1.Location = new System.Drawing.Point(254, 232);
            this.label_1.Name = "label_1";
            this.label_1.Size = new System.Drawing.Size(46, 13);
            this.label_1.TabIndex = 3;
            this.label_1.Text = "Jelenleg";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(411, 232);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "termék van készleten";
            // 
            // button_plus
            // 
            this.button_plus.Location = new System.Drawing.Point(524, 198);
            this.button_plus.Name = "button_plus";
            this.button_plus.Size = new System.Drawing.Size(44, 44);
            this.button_plus.TabIndex = 10;
            this.button_plus.Text = "+";
            this.button_plus.UseVisualStyleBackColor = true;
            this.button_plus.Click += new System.EventHandler(this.button_plus_Click_1);
            // 
            // button_minus
            // 
            this.button_minus.Location = new System.Drawing.Point(524, 260);
            this.button_minus.Name = "button_minus";
            this.button_minus.Size = new System.Drawing.Size(44, 44);
            this.button_minus.TabIndex = 11;
            this.button_minus.Text = "-";
            this.button_minus.UseVisualStyleBackColor = true;
            this.button_minus.Click += new System.EventHandler(this.button_minus_Click_1);
            // 
            // button_megse
            // 
            this.button_megse.Location = new System.Drawing.Point(236, 326);
            this.button_megse.Name = "button_megse";
            this.button_megse.Size = new System.Drawing.Size(156, 45);
            this.button_megse.TabIndex = 12;
            this.button_megse.Text = "Mégse";
            this.button_megse.UseVisualStyleBackColor = true;
            this.button_megse.Click += new System.EventHandler(this.button_megse_Click);
            // 
            // button_mentes
            // 
            this.button_mentes.Location = new System.Drawing.Point(398, 326);
            this.button_mentes.Name = "button_mentes";
            this.button_mentes.Size = new System.Drawing.Size(170, 45);
            this.button_mentes.TabIndex = 13;
            this.button_mentes.Text = "Mentés";
            this.button_mentes.UseVisualStyleBackColor = true;
            this.button_mentes.Click += new System.EventHandler(this.button_mentes_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(415, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(153, 141);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(225)))), ((int)(((byte)(185)))));
            this.ClientSize = new System.Drawing.Size(577, 379);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button_mentes);
            this.Controls.Add(this.button_megse);
            this.Controls.Add(this.button_minus);
            this.Controls.Add(this.button_plus);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label_1);
            this.Controls.Add(this.textBox_mennyiseg);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.textBox_kereses);
            this.Name = "Form1";
            this.Text = "KliensAlkalmazás";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_kereses;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox textBox_mennyiseg;
        private System.Windows.Forms.Label label_1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_plus;
        private System.Windows.Forms.Button button_minus;
        private System.Windows.Forms.Button button_megse;
        private System.Windows.Forms.Button button_mentes;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}