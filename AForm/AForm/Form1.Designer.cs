namespace AForm
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
            this.lblCalmDown = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblCalmDown
            // 
            this.lblCalmDown.AutoSize = true;
            this.lblCalmDown.Location = new System.Drawing.Point(74, 42);
            this.lblCalmDown.Name = "lblCalmDown";
            this.lblCalmDown.Size = new System.Drawing.Size(88, 13);
            this.lblCalmDown.TabIndex = 0;
            this.lblCalmDown.Text = "Calm Down Shrid";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblCalmDown);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCalmDown;
    }
}

