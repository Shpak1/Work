namespace WindowsFormsApplication12
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.text_decision = new System.Windows.Forms.TextBox();
            this.label_work = new System.Windows.Forms.Label();
            this.button_plus = new System.Windows.Forms.Button();
            this.progress = new System.Windows.Forms.ProgressBar();
            this.button_minus = new System.Windows.Forms.Button();
            this.button_multip = new System.Windows.Forms.Button();
            this.button_div = new System.Windows.Forms.Button();
            this.text_max = new System.Windows.Forms.TextBox();
            this.label_counter = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // text_decision
            // 
            this.text_decision.Font = new System.Drawing.Font("Book Antiqua", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.text_decision.Location = new System.Drawing.Point(503, 33);
            this.text_decision.Name = "text_decision";
            this.text_decision.Size = new System.Drawing.Size(153, 85);
            this.text_decision.TabIndex = 0;
            this.text_decision.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.text_decision.KeyDown += new System.Windows.Forms.KeyEventHandler(this.text_decision_KeyDown);
            // 
            // label_work
            // 
            this.label_work.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label_work.Font = new System.Drawing.Font("Bodoni MT", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_work.Location = new System.Drawing.Point(39, 33);
            this.label_work.Name = "label_work";
            this.label_work.Size = new System.Drawing.Size(453, 85);
            this.label_work.TabIndex = 1;
            this.label_work.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // button_plus
            // 
            this.button_plus.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_plus.Location = new System.Drawing.Point(32, 159);
            this.button_plus.Name = "button_plus";
            this.button_plus.Size = new System.Drawing.Size(151, 54);
            this.button_plus.TabIndex = 2;
            this.button_plus.Text = "Сложение";
            this.button_plus.UseVisualStyleBackColor = true;
            this.button_plus.Click += new System.EventHandler(this.button_plus_Click);
            // 
            // progress
            // 
            this.progress.Location = new System.Drawing.Point(32, 129);
            this.progress.Name = "progress";
            this.progress.Size = new System.Drawing.Size(624, 23);
            this.progress.TabIndex = 3;
            // 
            // button_minus
            // 
            this.button_minus.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_minus.Location = new System.Drawing.Point(187, 159);
            this.button_minus.Name = "button_minus";
            this.button_minus.Size = new System.Drawing.Size(151, 54);
            this.button_minus.TabIndex = 4;
            this.button_minus.Text = "Вычитание";
            this.button_minus.UseVisualStyleBackColor = true;
            this.button_minus.Click += new System.EventHandler(this.button_minus_Click);
            // 
            // button_multip
            // 
            this.button_multip.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_multip.Location = new System.Drawing.Point(344, 158);
            this.button_multip.Name = "button_multip";
            this.button_multip.Size = new System.Drawing.Size(151, 54);
            this.button_multip.TabIndex = 5;
            this.button_multip.Text = "Умножение";
            this.button_multip.UseVisualStyleBackColor = true;
            this.button_multip.Click += new System.EventHandler(this.button_multip_Click);
            // 
            // button_div
            // 
            this.button_div.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_div.Location = new System.Drawing.Point(501, 158);
            this.button_div.Name = "button_div";
            this.button_div.Size = new System.Drawing.Size(151, 54);
            this.button_div.TabIndex = 6;
            this.button_div.Text = "Деление";
            this.button_div.UseVisualStyleBackColor = true;
            this.button_div.Click += new System.EventHandler(this.button_div_Click);
            // 
            // text_max
            // 
            this.text_max.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.text_max.Location = new System.Drawing.Point(667, 169);
            this.text_max.Name = "text_max";
            this.text_max.Size = new System.Drawing.Size(60, 31);
            this.text_max.TabIndex = 7;
            // 
            // label_counter
            // 
            this.label_counter.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label_counter.Enabled = false;
            this.label_counter.Font = new System.Drawing.Font("Book Antiqua", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_counter.Location = new System.Drawing.Point(44, 1);
            this.label_counter.Name = "label_counter";
            this.label_counter.Size = new System.Drawing.Size(448, 18);
            this.label_counter.TabIndex = 8;
            this.label_counter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(753, 224);
            this.Controls.Add(this.label_counter);
            this.Controls.Add(this.text_max);
            this.Controls.Add(this.button_div);
            this.Controls.Add(this.button_multip);
            this.Controls.Add(this.button_minus);
            this.Controls.Add(this.progress);
            this.Controls.Add(this.button_plus);
            this.Controls.Add(this.label_work);
            this.Controls.Add(this.text_decision);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Устный счет";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox text_decision;
        private System.Windows.Forms.Label label_work;
        private System.Windows.Forms.Button button_plus;
        private System.Windows.Forms.ProgressBar progress;
        private System.Windows.Forms.Button button_minus;
        private System.Windows.Forms.Button button_multip;
        private System.Windows.Forms.Button button_div;
        private System.Windows.Forms.TextBox text_max;
        private System.Windows.Forms.Label label_counter;
    }
}

