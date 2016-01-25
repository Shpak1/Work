namespace secret_picture
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
            this.show_picture_1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // show_picture_1
            // 
            this.show_picture_1.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.show_picture_1.Location = new System.Drawing.Point(12, 12);
            this.show_picture_1.Name = "show_picture_1";
            this.show_picture_1.Size = new System.Drawing.Size(109, 30);
            this.show_picture_1.TabIndex = 0;
            this.show_picture_1.Text = " картинка 1";
            this.show_picture_1.UseVisualStyleBackColor = true;
            this.show_picture_1.Click += new System.EventHandler(this.show_picture_1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(565, 406);
            this.Controls.Add(this.show_picture_1);
            this.DoubleBuffered = true;
            this.Enabled = false;
            this.MinimumSize = new System.Drawing.Size(400, 400);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "секретная картинка";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button show_picture_1;
    }
}

