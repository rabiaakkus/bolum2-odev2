namespace bolum2_odev2
{
    partial class b
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
            this.btnKarşilaştir = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnKarşilaştir
            // 
            this.btnKarşilaştir.Location = new System.Drawing.Point(12, 40);
            this.btnKarşilaştir.Name = "btnKarşilaştir";
            this.btnKarşilaştir.Size = new System.Drawing.Size(75, 23);
            this.btnKarşilaştir.TabIndex = 0;
            this.btnKarşilaştir.Text = "button1";
            this.btnKarşilaştir.UseVisualStyleBackColor = true;
            this.btnKarşilaştir.Click += new System.EventHandler(this.btnKarşilaştir_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(120, 42);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 1;
            // 
            // b
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(330, 114);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnKarşilaştir);
            this.Name = "b";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnKarşilaştir;
        private System.Windows.Forms.TextBox textBox1;
    }
}

