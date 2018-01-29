namespace FormNavigationExample
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
            this.OpenForm2Button = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // OpenForm2Button
            // 
            this.OpenForm2Button.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OpenForm2Button.Location = new System.Drawing.Point(47, 90);
            this.OpenForm2Button.Name = "OpenForm2Button";
            this.OpenForm2Button.Size = new System.Drawing.Size(172, 65);
            this.OpenForm2Button.TabIndex = 0;
            this.OpenForm2Button.Text = "Show Form Two";
            this.OpenForm2Button.UseVisualStyleBackColor = true;
            this.OpenForm2Button.Click += new System.EventHandler(this.OpenForm2Button_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(174, 215);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(91, 34);
            this.ExitButton.TabIndex = 1;
            this.ExitButton.Text = "E&xit";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleLabel.Location = new System.Drawing.Point(25, 21);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(226, 22);
            this.TitleLabel.TabIndex = 2;
            this.TitleLabel.Text = "Form Navigation Example";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.TitleLabel);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.OpenForm2Button);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form 1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button OpenForm2Button;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Label TitleLabel;
    }
}

