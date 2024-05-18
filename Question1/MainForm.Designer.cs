namespace Question1
{
    partial class MainForm
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
            this.txtNumber1 = new System.Windows.Forms.TextBox();
            this.txtNumber2 = new System.Windows.Forms.TextBox();
            this.btnFindPrimes1 = new System.Windows.Forms.Button();
            this.btnFindPrimes2 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // txtNumber1
            // 
            this.txtNumber1.Location = new System.Drawing.Point(12, 12);
            this.txtNumber1.Name = "txtNumber1";
            this.txtNumber1.Size = new System.Drawing.Size(153, 20);
            this.txtNumber1.TabIndex = 0;
            this.txtNumber1.Text = "Write the Value 1";
            // 
            // txtNumber2
            // 
            this.txtNumber2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNumber2.Location = new System.Drawing.Point(240, 12);
            this.txtNumber2.Name = "txtNumber2";
            this.txtNumber2.Size = new System.Drawing.Size(153, 20);
            this.txtNumber2.TabIndex = 1;
            this.txtNumber2.Text = "Write the Value 2";
            // 
            // btnFindPrimes1
            // 
            this.btnFindPrimes1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnFindPrimes1.Location = new System.Drawing.Point(12, 345);
            this.btnFindPrimes1.Name = "btnFindPrimes1";
            this.btnFindPrimes1.Size = new System.Drawing.Size(153, 42);
            this.btnFindPrimes1.TabIndex = 2;
            this.btnFindPrimes1.Text = "Find Primes 1";
            this.btnFindPrimes1.UseVisualStyleBackColor = true;
            this.btnFindPrimes1.Click += new System.EventHandler(this.btnFindPrimes1_Click);
            // 
            // btnFindPrimes2
            // 
            this.btnFindPrimes2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFindPrimes2.Location = new System.Drawing.Point(240, 345);
            this.btnFindPrimes2.Name = "btnFindPrimes2";
            this.btnFindPrimes2.Size = new System.Drawing.Size(153, 42);
            this.btnFindPrimes2.TabIndex = 3;
            this.btnFindPrimes2.Text = "Find Primes 2";
            this.btnFindPrimes2.UseVisualStyleBackColor = true;
            this.btnFindPrimes2.Click += new System.EventHandler(this.btnFindPrimes2_Click);
            // 
            // listBox1
            // 
            this.listBox1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(12, 56);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(153, 264);
            this.listBox1.TabIndex = 4;
            // 
            // listBox2
            // 
            this.listBox2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(240, 56);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(153, 264);
            this.listBox2.TabIndex = 5;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(405, 427);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btnFindPrimes2);
            this.Controls.Add(this.btnFindPrimes1);
            this.Controls.Add(this.txtNumber2);
            this.Controls.Add(this.txtNumber1);
            this.Name = "MainForm";
            this.Text = "Find Primes Up to N";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNumber1;
        private System.Windows.Forms.TextBox txtNumber2;
        private System.Windows.Forms.Button btnFindPrimes1;
        private System.Windows.Forms.Button btnFindPrimes2;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox listBox2;
    }
}

