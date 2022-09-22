
namespace ProjectWeek14
{
    partial class HomeScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomeScreen));
            this.btnMakanan = new System.Windows.Forms.Button();
            this.btnMinuman = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnMakanan
            // 
            this.btnMakanan.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMakanan.BackgroundImage")));
            this.btnMakanan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMakanan.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnMakanan.Location = new System.Drawing.Point(12, 25);
            this.btnMakanan.Name = "btnMakanan";
            this.btnMakanan.Size = new System.Drawing.Size(376, 383);
            this.btnMakanan.TabIndex = 0;
            this.btnMakanan.UseVisualStyleBackColor = true;
            this.btnMakanan.Click += new System.EventHandler(this.btnMakanan_Click);
            // 
            // btnMinuman
            // 
            this.btnMinuman.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMinuman.BackgroundImage")));
            this.btnMinuman.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMinuman.Location = new System.Drawing.Point(412, 25);
            this.btnMinuman.Name = "btnMinuman";
            this.btnMinuman.Size = new System.Drawing.Size(376, 383);
            this.btnMinuman.TabIndex = 1;
            this.btnMinuman.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(66, 440);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(168, 20);
            this.textBox1.TabIndex = 2;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 443);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "No Meja";
            // 
            // HomeScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 486);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnMinuman);
            this.Controls.Add(this.btnMakanan);
            this.Name = "HomeScreen";
            this.Text = "Home Screen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnMakanan;
        private System.Windows.Forms.Button btnMinuman;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
    }
}

