namespace WindowsFormsApplication9
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
            this.user_panel_paper = new System.Windows.Forms.Panel();
            this.user_panel_scissors = new System.Windows.Forms.Panel();
            this.user_panel_stone = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.picture_stone = new System.Windows.Forms.PictureBox();
            this.picture_paper = new System.Windows.Forms.PictureBox();
            this.picture_scissors = new System.Windows.Forms.PictureBox();
            this.comp_picture_scissors = new System.Windows.Forms.PictureBox();
            this.comp_picture_paper = new System.Windows.Forms.PictureBox();
            this.comp_picture_stone = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label_messege = new System.Windows.Forms.Label();
            this.label_score = new System.Windows.Forms.Label();
            this.label_comp = new System.Windows.Forms.Label();
            this.trackBar_speed = new System.Windows.Forms.TrackBar();
            this.user_panel_paper.SuspendLayout();
            this.user_panel_scissors.SuspendLayout();
            this.user_panel_stone.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picture_stone)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_paper)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_scissors)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comp_picture_scissors)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comp_picture_paper)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comp_picture_stone)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_speed)).BeginInit();
            this.SuspendLayout();
            // 
            // user_panel_paper
            // 
            this.user_panel_paper.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.user_panel_paper.Controls.Add(this.picture_paper);
            this.user_panel_paper.Location = new System.Drawing.Point(375, 86);
            this.user_panel_paper.Name = "user_panel_paper";
            this.user_panel_paper.Size = new System.Drawing.Size(120, 120);
            this.user_panel_paper.TabIndex = 0;
            this.user_panel_paper.MouseEnter += new System.EventHandler(this.user_panel_paper_MouseEnter);
            // 
            // user_panel_scissors
            // 
            this.user_panel_scissors.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.user_panel_scissors.Controls.Add(this.picture_scissors);
            this.user_panel_scissors.Location = new System.Drawing.Point(211, 86);
            this.user_panel_scissors.Name = "user_panel_scissors";
            this.user_panel_scissors.Size = new System.Drawing.Size(120, 120);
            this.user_panel_scissors.TabIndex = 1;
            this.user_panel_scissors.MouseEnter += new System.EventHandler(this.user_panel_scissors_MouseEnter);
            // 
            // user_panel_stone
            // 
            this.user_panel_stone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.user_panel_stone.Controls.Add(this.picture_stone);
            this.user_panel_stone.Location = new System.Drawing.Point(39, 86);
            this.user_panel_stone.Name = "user_panel_stone";
            this.user_panel_stone.Size = new System.Drawing.Size(120, 120);
            this.user_panel_stone.TabIndex = 1;
            this.user_panel_stone.MouseEnter += new System.EventHandler(this.user_panel_stone_MouseEnter);
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.comp_picture_stone);
            this.panel4.Controls.Add(this.comp_picture_paper);
            this.panel4.Controls.Add(this.comp_picture_scissors);
            this.panel4.Location = new System.Drawing.Point(585, 86);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(120, 120);
            this.panel4.TabIndex = 2;
            // 
            // picture_stone
            // 
            this.picture_stone.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picture_stone.Image = ((System.Drawing.Image)(resources.GetObject("picture_stone.Image")));
            this.picture_stone.Location = new System.Drawing.Point(0, 0);
            this.picture_stone.Name = "picture_stone";
            this.picture_stone.Size = new System.Drawing.Size(118, 118);
            this.picture_stone.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picture_stone.TabIndex = 3;
            this.picture_stone.TabStop = false;
            this.picture_stone.Visible = false;
            this.picture_stone.Click += new System.EventHandler(this.picture_stone_Click);
            // 
            // picture_paper
            // 
            this.picture_paper.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picture_paper.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picture_paper.Image = ((System.Drawing.Image)(resources.GetObject("picture_paper.Image")));
            this.picture_paper.Location = new System.Drawing.Point(0, 0);
            this.picture_paper.Name = "picture_paper";
            this.picture_paper.Size = new System.Drawing.Size(118, 118);
            this.picture_paper.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picture_paper.TabIndex = 4;
            this.picture_paper.TabStop = false;
            this.picture_paper.Visible = false;
            this.picture_paper.Click += new System.EventHandler(this.picture_stone_Click);
            // 
            // picture_scissors
            // 
            this.picture_scissors.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picture_scissors.Image = ((System.Drawing.Image)(resources.GetObject("picture_scissors.Image")));
            this.picture_scissors.Location = new System.Drawing.Point(0, 0);
            this.picture_scissors.Name = "picture_scissors";
            this.picture_scissors.Size = new System.Drawing.Size(118, 118);
            this.picture_scissors.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picture_scissors.TabIndex = 5;
            this.picture_scissors.TabStop = false;
            this.picture_scissors.Visible = false;
            this.picture_scissors.Click += new System.EventHandler(this.picture_stone_Click);
            // 
            // comp_picture_scissors
            // 
            this.comp_picture_scissors.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.comp_picture_scissors.Image = ((System.Drawing.Image)(resources.GetObject("comp_picture_scissors.Image")));
            this.comp_picture_scissors.Location = new System.Drawing.Point(0, 0);
            this.comp_picture_scissors.Name = "comp_picture_scissors";
            this.comp_picture_scissors.Size = new System.Drawing.Size(120, 120);
            this.comp_picture_scissors.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.comp_picture_scissors.TabIndex = 3;
            this.comp_picture_scissors.TabStop = false;
            this.comp_picture_scissors.Visible = false;
            // 
            // comp_picture_paper
            // 
            this.comp_picture_paper.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.comp_picture_paper.Image = ((System.Drawing.Image)(resources.GetObject("comp_picture_paper.Image")));
            this.comp_picture_paper.Location = new System.Drawing.Point(0, 0);
            this.comp_picture_paper.Name = "comp_picture_paper";
            this.comp_picture_paper.Size = new System.Drawing.Size(120, 120);
            this.comp_picture_paper.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.comp_picture_paper.TabIndex = 4;
            this.comp_picture_paper.TabStop = false;
            this.comp_picture_paper.Visible = false;
            // 
            // comp_picture_stone
            // 
            this.comp_picture_stone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.comp_picture_stone.Image = ((System.Drawing.Image)(resources.GetObject("comp_picture_stone.Image")));
            this.comp_picture_stone.Location = new System.Drawing.Point(-1, -2);
            this.comp_picture_stone.Name = "comp_picture_stone";
            this.comp_picture_stone.Size = new System.Drawing.Size(120, 120);
            this.comp_picture_stone.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.comp_picture_stone.TabIndex = 5;
            this.comp_picture_stone.TabStop = false;
            this.comp_picture_stone.Visible = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 300;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label_messege
            // 
            this.label_messege.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_messege.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_messege.Location = new System.Drawing.Point(38, 19);
            this.label_messege.Name = "label_messege";
            this.label_messege.Size = new System.Drawing.Size(457, 23);
            this.label_messege.TabIndex = 3;
            this.label_messege.Text = "Выбери Свою Фигуру!";
            this.label_messege.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_score
            // 
            this.label_score.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_score.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_score.Location = new System.Drawing.Point(37, 243);
            this.label_score.Name = "label_score";
            this.label_score.Size = new System.Drawing.Size(668, 23);
            this.label_score.TabIndex = 4;
            this.label_score.Text = "label2";
            this.label_score.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_comp
            // 
            this.label_comp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_comp.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_comp.Location = new System.Drawing.Point(585, 19);
            this.label_comp.Name = "label_comp";
            this.label_comp.Size = new System.Drawing.Size(120, 23);
            this.label_comp.TabIndex = 5;
            this.label_comp.Text = "Рука компьютера";
            this.label_comp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // trackBar_speed
            // 
            this.trackBar_speed.LargeChange = 1;
            this.trackBar_speed.Location = new System.Drawing.Point(718, 87);
            this.trackBar_speed.Minimum = 1;
            this.trackBar_speed.Name = "trackBar_speed";
            this.trackBar_speed.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBar_speed.Size = new System.Drawing.Size(45, 118);
            this.trackBar_speed.TabIndex = 6;
            this.trackBar_speed.Value = 1;
            this.trackBar_speed.ValueChanged += new System.EventHandler(this.trackBar_speed_ValueChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(775, 356);
            this.Controls.Add(this.trackBar_speed);
            this.Controls.Add(this.label_comp);
            this.Controls.Add(this.label_score);
            this.Controls.Add(this.label_messege);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.user_panel_scissors);
            this.Controls.Add(this.user_panel_stone);
            this.Controls.Add(this.user_panel_paper);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "камень ножницы бумага";
            this.user_panel_paper.ResumeLayout(false);
            this.user_panel_scissors.ResumeLayout(false);
            this.user_panel_stone.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picture_stone)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_paper)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_scissors)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comp_picture_scissors)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comp_picture_paper)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comp_picture_stone)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_speed)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel user_panel_paper;
        private System.Windows.Forms.Panel user_panel_scissors;
        private System.Windows.Forms.Panel user_panel_stone;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PictureBox picture_stone;
        private System.Windows.Forms.PictureBox picture_paper;
        private System.Windows.Forms.PictureBox picture_scissors;
        private System.Windows.Forms.PictureBox comp_picture_stone;
        private System.Windows.Forms.PictureBox comp_picture_paper;
        private System.Windows.Forms.PictureBox comp_picture_scissors;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label_messege;
        private System.Windows.Forms.Label label_score;
        private System.Windows.Forms.Label label_comp;
        private System.Windows.Forms.TrackBar trackBar_speed;
    }
}

