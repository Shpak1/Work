namespace WindowsFormsApplication11
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.picture3 = new System.Windows.Forms.PictureBox();
            this.picture2 = new System.Windows.Forms.PictureBox();
            this.picture1 = new System.Windows.Forms.PictureBox();
            this.button_start = new System.Windows.Forms.Button();
            this.label_mode = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label_rules = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture1)).BeginInit();
            this.SuspendLayout();
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(623, 42);
            this.trackBar1.Maximum = 20;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBar1.Size = new System.Drawing.Size(45, 133);
            this.trackBar1.SmallChange = 4;
            this.trackBar1.TabIndex = 4;
            this.trackBar1.TickFrequency = 4;
            this.trackBar1.ValueChanged += new System.EventHandler(this.trackBar1_ValueChanged);
            // 
            // picture3
            // 
            this.picture3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picture3.Image = global::WindowsFormsApplication11.Properties.Resources.mole3;
            this.picture3.Location = new System.Drawing.Point(447, 42);
            this.picture3.Name = "picture3";
            this.picture3.Size = new System.Drawing.Size(118, 133);
            this.picture3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picture3.TabIndex = 2;
            this.picture3.TabStop = false;
            this.picture3.Click += new System.EventHandler(this.picture2_Click);
            // 
            // picture2
            // 
            this.picture2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picture2.Image = global::WindowsFormsApplication11.Properties.Resources.mole2;
            this.picture2.Location = new System.Drawing.Point(241, 42);
            this.picture2.Name = "picture2";
            this.picture2.Size = new System.Drawing.Size(118, 133);
            this.picture2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picture2.TabIndex = 1;
            this.picture2.TabStop = false;
            this.picture2.Click += new System.EventHandler(this.picture2_Click);
            // 
            // picture1
            // 
            this.picture1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picture1.Image = global::WindowsFormsApplication11.Properties.Resources.mole1;
            this.picture1.Location = new System.Drawing.Point(53, 42);
            this.picture1.Name = "picture1";
            this.picture1.Size = new System.Drawing.Size(118, 133);
            this.picture1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picture1.TabIndex = 0;
            this.picture1.TabStop = false;
            this.picture1.Click += new System.EventHandler(this.picture2_Click);
            // 
            // button_start
            // 
            this.button_start.Font = new System.Drawing.Font("Algerian", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_start.Location = new System.Drawing.Point(228, 210);
            this.button_start.Name = "button_start";
            this.button_start.Size = new System.Drawing.Size(141, 34);
            this.button_start.TabIndex = 5;
            this.button_start.Text = "Начало игры";
            this.button_start.UseVisualStyleBackColor = true;
            this.button_start.Click += new System.EventHandler(this.button_start_Click);
            // 
            // label_mode
            // 
            this.label_mode.Font = new System.Drawing.Font("Algerian", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_mode.Location = new System.Drawing.Point(561, 183);
            this.label_mode.Name = "label_mode";
            this.label_mode.Size = new System.Drawing.Size(129, 21);
            this.label_mode.TabIndex = 6;
            this.label_mode.Text = "Скорость равна";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label_rules
            // 
            this.label_rules.Font = new System.Drawing.Font("Algerian", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_rules.Location = new System.Drawing.Point(53, 13);
            this.label_rules.Name = "label_rules";
            this.label_rules.Size = new System.Drawing.Size(512, 23);
            this.label_rules.TabIndex = 7;
            this.label_rules.Text = "Кликайте на картинки сразу же после их появления";
            this.label_rules.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(53, 181);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(480, 23);
            this.progressBar1.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(680, 265);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.label_rules);
            this.Controls.Add(this.label_mode);
            this.Controls.Add(this.button_start);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.picture3);
            this.Controls.Add(this.picture2);
            this.Controls.Add(this.picture1);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Быстрощелк";
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picture1;
        private System.Windows.Forms.PictureBox picture2;
        private System.Windows.Forms.PictureBox picture3;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Button button_start;
        private System.Windows.Forms.Label label_mode;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label_rules;
        private System.Windows.Forms.ProgressBar progressBar1;
    }
}

