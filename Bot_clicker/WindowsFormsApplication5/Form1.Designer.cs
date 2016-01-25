namespace WindowsFormsApplication5
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label_show_time = new System.Windows.Forms.Label();
            this.label_show_count = new System.Windows.Forms.Label();
            this.track_clicker = new System.Windows.Forms.TrackBar();
            this.label_info_time = new System.Windows.Forms.Label();
            this.label_info_clicks = new System.Windows.Forms.Label();
            this.track_timer = new System.Windows.Forms.TrackBar();
            this.button_start = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.track_clicker)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.track_timer)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Controls.Add(this.label_show_time, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.label_show_count, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.track_clicker, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label_info_time, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label_info_clicks, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.track_timer, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.button_start, 1, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(479, 134);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label_show_time
            // 
            this.label_show_time.AutoSize = true;
            this.label_show_time.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_show_time.Location = new System.Drawing.Point(321, 44);
            this.label_show_time.Name = "label_show_time";
            this.label_show_time.Size = new System.Drawing.Size(155, 44);
            this.label_show_time.TabIndex = 6;
            this.label_show_time.Text = "-";
            // 
            // label_show_count
            // 
            this.label_show_count.AutoSize = true;
            this.label_show_count.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_show_count.Location = new System.Drawing.Point(321, 0);
            this.label_show_count.Name = "label_show_count";
            this.label_show_count.Size = new System.Drawing.Size(155, 44);
            this.label_show_count.TabIndex = 5;
            this.label_show_count.Text = "-";
            // 
            // track_clicker
            // 
            this.track_clicker.Dock = System.Windows.Forms.DockStyle.Fill;
            this.track_clicker.LargeChange = 10;
            this.track_clicker.Location = new System.Drawing.Point(162, 3);
            this.track_clicker.Maximum = 1000000;
            this.track_clicker.Minimum = 1;
            this.track_clicker.Name = "track_clicker";
            this.track_clicker.Size = new System.Drawing.Size(153, 38);
            this.track_clicker.TabIndex = 2;
            this.track_clicker.TickFrequency = 10;
            this.track_clicker.Value = 1;
            this.track_clicker.Scroll += new System.EventHandler(this.track_clicker_Scroll);
            // 
            // label_info_time
            // 
            this.label_info_time.AutoSize = true;
            this.label_info_time.Dock = System.Windows.Forms.DockStyle.Top;
            this.label_info_time.Location = new System.Drawing.Point(3, 44);
            this.label_info_time.Name = "label_info_time";
            this.label_info_time.Size = new System.Drawing.Size(153, 13);
            this.label_info_time.TabIndex = 4;
            this.label_info_time.Text = "Задержка между кликами";
            // 
            // label_info_clicks
            // 
            this.label_info_clicks.AutoSize = true;
            this.label_info_clicks.Dock = System.Windows.Forms.DockStyle.Top;
            this.label_info_clicks.Location = new System.Drawing.Point(3, 0);
            this.label_info_clicks.Name = "label_info_clicks";
            this.label_info_clicks.Size = new System.Drawing.Size(153, 13);
            this.label_info_clicks.TabIndex = 3;
            this.label_info_clicks.Text = "Количество кликов";
            // 
            // track_timer
            // 
            this.track_timer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.track_timer.LargeChange = 10;
            this.track_timer.Location = new System.Drawing.Point(162, 47);
            this.track_timer.Maximum = 1000;
            this.track_timer.Minimum = 1;
            this.track_timer.Name = "track_timer";
            this.track_timer.Size = new System.Drawing.Size(153, 38);
            this.track_timer.TabIndex = 7;
            this.track_timer.TickFrequency = 100;
            this.track_timer.Value = 1;
            this.track_timer.Scroll += new System.EventHandler(this.track_timer_Scroll);
            // 
            // button_start
            // 
            this.button_start.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_start.Location = new System.Drawing.Point(162, 91);
            this.button_start.Name = "button_start";
            this.button_start.Size = new System.Drawing.Size(153, 40);
            this.button_start.TabIndex = 8;
            this.button_start.Text = "Начать кликать!";
            this.button_start.UseVisualStyleBackColor = true;
            this.button_start.Click += new System.EventHandler(this.button1_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(479, 134);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "автокликер";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.track_clicker)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.track_timer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label_show_time;
        private System.Windows.Forms.Label label_show_count;
        private System.Windows.Forms.TrackBar track_clicker;
        private System.Windows.Forms.Label label_info_time;
        private System.Windows.Forms.Label label_info_clicks;
        private System.Windows.Forms.TrackBar track_timer;
        private System.Windows.Forms.Button button_start;
        private System.Windows.Forms.Timer timer1;
    }
}

