
namespace ProjectWeek14
{
    partial class Noodle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Noodle));
            this.btnMieGoreng = new System.Windows.Forms.Button();
            this.btnMieRebus = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnMieGoreng
            // 
            this.btnMieGoreng.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMieGoreng.BackgroundImage")));
            this.btnMieGoreng.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMieGoreng.Location = new System.Drawing.Point(12, 12);
            this.btnMieGoreng.Name = "btnMieGoreng";
            this.btnMieGoreng.Size = new System.Drawing.Size(213, 180);
            this.btnMieGoreng.TabIndex = 0;
            this.btnMieGoreng.UseVisualStyleBackColor = true;
            this.btnMieGoreng.Click += new System.EventHandler(this.btnMieGoreng_Click);
            // 
            // btnMieRebus
            // 
            this.btnMieRebus.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMieRebus.BackgroundImage")));
            this.btnMieRebus.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMieRebus.Location = new System.Drawing.Point(241, 12);
            this.btnMieRebus.Name = "btnMieRebus";
            this.btnMieRebus.Size = new System.Drawing.Size(213, 180);
            this.btnMieRebus.TabIndex = 1;
            this.btnMieRebus.UseVisualStyleBackColor = true;
            this.btnMieRebus.Click += new System.EventHandler(this.btnMieRebus_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 219);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 2;
            // 
            // Noodle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnMieRebus);
            this.Controls.Add(this.btnMieGoreng);
            this.Name = "Noodle";
            this.Text = "Noodle";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnMieGoreng;
        private System.Windows.Forms.Button btnMieRebus;
        private System.Windows.Forms.TextBox textBox1;
    }
}