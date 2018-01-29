namespace FormNavigationExample
{
    partial class Form2
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
            this.ShowForm1Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ShowForm1Button
            // 
            this.ShowForm1Button.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowForm1Button.Location = new System.Drawing.Point(52, 83);
            this.ShowForm1Button.Name = "ShowForm1Button";
            this.ShowForm1Button.Size = new System.Drawing.Size(181, 78);
            this.ShowForm1Button.TabIndex = 0;
            this.ShowForm1Button.Text = "Show Form 1";
            this.ShowForm1Button.UseVisualStyleBackColor = true;
            this.ShowForm1Button.Click += new System.EventHandler(this.ShowForm1Button_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.ShowForm1Button);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form 2";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ShowForm1Button;
    }
}