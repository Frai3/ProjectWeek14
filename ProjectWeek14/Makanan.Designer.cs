
namespace ProjectWeek14
{
    partial class Makanan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Makanan));
            this.btnMie = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnMie
            // 
            this.btnMie.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMie.BackgroundImage")));
            this.btnMie.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnMie.Location = new System.Drawing.Point(12, 12);
            this.btnMie.Name = "btnMie";
            this.btnMie.Size = new System.Drawing.Size(181, 151);
            this.btnMie.TabIndex = 0;
            this.btnMie.UseVisualStyleBackColor = true;
            this.btnMie.Click += new System.EventHandler(this.btnMie_Click);
            // 
            // Makanan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnMie);
            this.Name = "Makanan";
            this.Text = "Makanan";
            this.Load += new System.EventHandler(this.Makanan_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnMie;
    }
}