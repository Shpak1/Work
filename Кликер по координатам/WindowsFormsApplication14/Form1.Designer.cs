namespace WindowsFormsApplication14
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
            this.text_x = new System.Windows.Forms.TextBox();
            this.text_y = new System.Windows.Forms.TextBox();
            this.button_add = new System.Windows.Forms.Button();
            this.buttonrepeat = new System.Windows.Forms.Button();
            this.buttonreset = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // text_x
            // 
            this.text_x.BackColor = System.Drawing.Color.Tan;
            this.text_x.Location = new System.Drawing.Point(12, 12);
            this.text_x.Multiline = true;
            this.text_x.Name = "text_x";
            this.text_x.ReadOnly = true;
            this.text_x.Size = new System.Drawing.Size(58, 204);
            this.text_x.TabIndex = 1;
            // 
            // text_y
            // 
            this.text_y.BackColor = System.Drawing.Color.Tan;
            this.text_y.Location = new System.Drawing.Point(87, 12);
            this.text_y.Multiline = true;
            this.text_y.Name = "text_y";
            this.text_y.ReadOnly = true;
            this.text_y.Size = new System.Drawing.Size(58, 204);
            this.text_y.TabIndex = 2;
            // 
            // button_add
            // 
            this.button_add.Location = new System.Drawing.Point(187, 12);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(85, 51);
            this.button_add.TabIndex = 3;
            this.button_add.Text = "Добавить координаты мышки";
            this.button_add.UseVisualStyleBackColor = true;
            this.button_add.Click += new System.EventHandler(this.button_add_Click);
            // 
            // buttonrepeat
            // 
            this.buttonrepeat.Location = new System.Drawing.Point(187, 87);
            this.buttonrepeat.Name = "buttonrepeat";
            this.buttonrepeat.Size = new System.Drawing.Size(85, 23);
            this.buttonrepeat.TabIndex = 4;
            this.buttonrepeat.Text = "повторить";
            this.buttonrepeat.UseVisualStyleBackColor = true;
            this.buttonrepeat.Click += new System.EventHandler(this.buttonrepeat_Click);
            // 
            // buttonreset
            // 
            this.buttonreset.Location = new System.Drawing.Point(187, 193);
            this.buttonreset.Name = "buttonreset";
            this.buttonreset.Size = new System.Drawing.Size(85, 23);
            this.buttonreset.TabIndex = 5;
            this.buttonreset.Text = "сбросить";
            this.buttonreset.UseVisualStyleBackColor = true;
            this.buttonreset.Click += new System.EventHandler(this.buttonreset_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.buttonreset);
            this.Controls.Add(this.buttonrepeat);
            this.Controls.Add(this.button_add);
            this.Controls.Add(this.text_y);
            this.Controls.Add(this.text_x);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox text_x;
        private System.Windows.Forms.TextBox text_y;
        private System.Windows.Forms.Button button_add;
        private System.Windows.Forms.Button buttonrepeat;
        private System.Windows.Forms.Button buttonreset;
    }
}

