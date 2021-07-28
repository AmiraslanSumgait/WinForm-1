
namespace WindowsFormsApp2
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
            this.CatchMe = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CatchMe
            // 
            this.CatchMe.BackColor = System.Drawing.Color.Red;
            this.CatchMe.Location = new System.Drawing.Point(212, 211);
            this.CatchMe.Name = "CatchMe";
            this.CatchMe.Size = new System.Drawing.Size(75, 45);
            this.CatchMe.TabIndex = 0;
            this.CatchMe.Text = "Catch Me";
            this.CatchMe.UseCompatibleTextRendering = true;
            this.CatchMe.UseVisualStyleBackColor = false;
            this.CatchMe.MouseHover += new System.EventHandler(this.Catch_Me_MouseHover);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CatchMe);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button CatchMe;
    }
}

