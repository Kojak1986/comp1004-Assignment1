namespace comp1004_Assignment1
{
    partial class Lab1Form
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
            this.OnlyLabel = new System.Windows.Forms.Label();
            this.NothingButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // OnlyLabel
            // 
            this.OnlyLabel.AutoSize = true;
            this.OnlyLabel.Font = new System.Drawing.Font("Ravie", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OnlyLabel.Location = new System.Drawing.Point(8, 130);
            this.OnlyLabel.Name = "OnlyLabel";
            this.OnlyLabel.Size = new System.Drawing.Size(339, 30);
            this.OnlyLabel.TabIndex = 0;
            this.OnlyLabel.Text = "Looks Like 100% To Me!!";
            // 
            // NothingButton
            // 
            this.NothingButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NothingButton.Location = new System.Drawing.Point(73, 229);
            this.NothingButton.Name = "NothingButton";
            this.NothingButton.Size = new System.Drawing.Size(237, 67);
            this.NothingButton.TabIndex = 1;
            this.NothingButton.Text = "Button to Nowhere";
            this.NothingButton.UseVisualStyleBackColor = true;
            this.NothingButton.Click += new System.EventHandler(this.NothingButton_Click);
            // 
            // Lab1Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(359, 308);
            this.Controls.Add(this.NothingButton);
            this.Controls.Add(this.OnlyLabel);
            this.Name = "Lab1Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Lab1Form_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label OnlyLabel;
        private System.Windows.Forms.Button NothingButton;
    }
}

