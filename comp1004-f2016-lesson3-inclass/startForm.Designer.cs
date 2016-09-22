namespace comp1004_f2016_lesson3_inclass
{
    partial class StartForm
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
            this.nextButton = new System.Windows.Forms.Button();
            this.clickMeButton = new System.Windows.Forms.Button();
            this.MessageLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // nextButton
            // 
            this.nextButton.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nextButton.Location = new System.Drawing.Point(193, 215);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(79, 34);
            this.nextButton.TabIndex = 0;
            this.nextButton.Text = "Next";
            this.nextButton.UseVisualStyleBackColor = true;
            this.nextButton.Click += new System.EventHandler(this.nextButton_Click);
            // 
            // clickMeButton
            // 
            this.clickMeButton.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clickMeButton.Location = new System.Drawing.Point(73, 123);
            this.clickMeButton.Name = "clickMeButton";
            this.clickMeButton.Size = new System.Drawing.Size(140, 60);
            this.clickMeButton.TabIndex = 1;
            this.clickMeButton.Text = "Click me!";
            this.clickMeButton.UseVisualStyleBackColor = true;
            this.clickMeButton.Click += new System.EventHandler(this.clickMeButton_Click);
            // 
            // MessageLabel
            // 
            this.MessageLabel.AutoSize = true;
            this.MessageLabel.Location = new System.Drawing.Point(73, 57);
            this.MessageLabel.Name = "MessageLabel";
            this.MessageLabel.Size = new System.Drawing.Size(0, 13);
            this.MessageLabel.TabIndex = 2;
            // 
            // startForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.MessageLabel);
            this.Controls.Add(this.clickMeButton);
            this.Controls.Add(this.nextButton);
            this.Name = "startForm";
            this.Text = "Sales";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button nextButton;
        private System.Windows.Forms.Button clickMeButton;
        private System.Windows.Forms.Label MessageLabel;
    }
}

