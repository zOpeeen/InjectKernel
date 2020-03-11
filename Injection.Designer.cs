namespace Divy
{
    partial class Injection
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Injection));
            this.Inject = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Inject
            // 
            this.Inject.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Inject.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Inject.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.Inject.Location = new System.Drawing.Point(12, 20);
            this.Inject.Name = "Inject";
            this.Inject.Size = new System.Drawing.Size(283, 37);
            this.Inject.TabIndex = 4;
            this.Inject.Text = "Inject";
            this.Inject.UseVisualStyleBackColor = true;
            this.Inject.Click += new System.EventHandler(this.btnInject_Click);
            // 
            // Injection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(309, 76);
            this.Controls.Add(this.Inject);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Injection";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AuRoRa";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.ResumeLayout(false);

        }
        private System.Windows.Forms.Button Inject;
    }
}

