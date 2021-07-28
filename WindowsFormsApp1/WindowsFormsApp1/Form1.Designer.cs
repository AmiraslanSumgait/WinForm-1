
namespace WindowsFormsApp1
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
            this.BakuButton = new System.Windows.Forms.Button();
            this.LondonButton = new System.Windows.Forms.Button();
            this.time_lbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BakuButton
            // 
            this.BakuButton.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.BakuButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BakuButton.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.BakuButton.Location = new System.Drawing.Point(94, 246);
            this.BakuButton.Name = "BakuButton";
            this.BakuButton.Size = new System.Drawing.Size(130, 83);
            this.BakuButton.TabIndex = 0;
            this.BakuButton.Text = "Baku";
            this.BakuButton.UseVisualStyleBackColor = false;
            this.BakuButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.BakuButton_MouseClick);
            // 
            // LondonButton
            // 
            this.LondonButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.LondonButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LondonButton.Location = new System.Drawing.Point(378, 245);
            this.LondonButton.Name = "LondonButton";
            this.LondonButton.Size = new System.Drawing.Size(130, 83);
            this.LondonButton.TabIndex = 1;
            this.LondonButton.Text = "London";
            this.LondonButton.UseVisualStyleBackColor = false;
            this.LondonButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.LondonButton_MouseClick);
            // 
            // time_lbl
            // 
            this.time_lbl.AutoSize = true;
            this.time_lbl.BackColor = System.Drawing.Color.Red;
            this.time_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.time_lbl.Location = new System.Drawing.Point(51, 40);
            this.time_lbl.Name = "time_lbl";
            this.time_lbl.Size = new System.Drawing.Size(0, 25);
            this.time_lbl.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.BakuImage;
            this.ClientSize = new System.Drawing.Size(607, 450);
            this.Controls.Add(this.time_lbl);
            this.Controls.Add(this.LondonButton);
            this.Controls.Add(this.BakuButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion
        private System.Windows.Forms.Button BakuButton;
        private System.Windows.Forms.Button LondonButton;
        private System.Windows.Forms.Label time_lbl;
    }
}

