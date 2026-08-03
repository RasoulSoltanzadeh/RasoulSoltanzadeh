
namespace Tower_of_hanoi
{
    partial class FrmHanoi_Ctrl
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
            this.StripPnl_Ctrl = new System.Windows.Forms.Panel();
            this.btnRun_Ctrl = new System.Windows.Forms.Button();
            this.btnNext_Ctrl = new System.Windows.Forms.Button();
            this.lblDOM_Ctrl = new System.Windows.Forms.Label();
            this.NUDdelay_Ctrl = new System.Windows.Forms.NumericUpDown();
            this.lblNN_Ctrl = new System.Windows.Forms.Label();
            this.NUDnut_Ctrl = new System.Windows.Forms.NumericUpDown();
            this.btnPause_Ctrl = new System.Windows.Forms.Button();
            this.btnBack_Ctrl = new System.Windows.Forms.Button();
            this.timerMv = new System.Windows.Forms.Timer(this.components);
            this.CenterViewPnl_Ctrl = new System.Windows.Forms.Panel();
            this.Middle = new System.Windows.Forms.Panel();
            this.lblColumnMiddle_Ctrl = new System.Windows.Forms.Label();
            this.Right = new System.Windows.Forms.Panel();
            this.lblColumnRight_Ctrl = new System.Windows.Forms.Label();
            this.Left = new System.Windows.Forms.Panel();
            this.N = new System.Windows.Forms.Label();
            this.lblColumnLeft_Ctrl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ViewPnl_Ctrl = new System.Windows.Forms.Panel();
            this.StepList_Ctrl = new System.Windows.Forms.ListBox();
            this.MoveList_Ctrl = new System.Windows.Forms.ListBox();
            this.StripPnl_Ctrl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUDdelay_Ctrl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDnut_Ctrl)).BeginInit();
            this.CenterViewPnl_Ctrl.SuspendLayout();
            this.Middle.SuspendLayout();
            this.Right.SuspendLayout();
            this.Left.SuspendLayout();
            this.ViewPnl_Ctrl.SuspendLayout();
            this.SuspendLayout();
            // 
            // StripPnl_Ctrl
            // 
            this.StripPnl_Ctrl.BackColor = System.Drawing.Color.Gainsboro;
            this.StripPnl_Ctrl.Controls.Add(this.btnRun_Ctrl);
            this.StripPnl_Ctrl.Controls.Add(this.btnNext_Ctrl);
            this.StripPnl_Ctrl.Controls.Add(this.lblDOM_Ctrl);
            this.StripPnl_Ctrl.Controls.Add(this.NUDdelay_Ctrl);
            this.StripPnl_Ctrl.Controls.Add(this.lblNN_Ctrl);
            this.StripPnl_Ctrl.Controls.Add(this.NUDnut_Ctrl);
            this.StripPnl_Ctrl.Controls.Add(this.btnPause_Ctrl);
            this.StripPnl_Ctrl.Controls.Add(this.btnBack_Ctrl);
            this.StripPnl_Ctrl.Dock = System.Windows.Forms.DockStyle.Top;
            this.StripPnl_Ctrl.Location = new System.Drawing.Point(0, 0);
            this.StripPnl_Ctrl.Name = "StripPnl_Ctrl";
            this.StripPnl_Ctrl.Size = new System.Drawing.Size(714, 44);
            this.StripPnl_Ctrl.TabIndex = 0;
            // 
            // btnRun_Ctrl
            // 
            this.btnRun_Ctrl.Location = new System.Drawing.Point(12, 8);
            this.btnRun_Ctrl.Name = "btnRun_Ctrl";
            this.btnRun_Ctrl.Size = new System.Drawing.Size(57, 30);
            this.btnRun_Ctrl.TabIndex = 0;
            this.btnRun_Ctrl.Text = "Run";
            this.btnRun_Ctrl.UseVisualStyleBackColor = true;
            this.btnRun_Ctrl.Click += new System.EventHandler(this.btnRun_Ctrl_Click);
            // 
            // btnNext_Ctrl
            // 
            this.btnNext_Ctrl.Enabled = false;
            this.btnNext_Ctrl.Location = new System.Drawing.Point(216, 8);
            this.btnNext_Ctrl.Name = "btnNext_Ctrl";
            this.btnNext_Ctrl.Size = new System.Drawing.Size(50, 30);
            this.btnNext_Ctrl.TabIndex = 3;
            this.btnNext_Ctrl.Text = "Next";
            this.btnNext_Ctrl.UseVisualStyleBackColor = true;
            this.btnNext_Ctrl.Click += new System.EventHandler(this.btnNext_Ctrl_Click);
            // 
            // lblDOM_Ctrl
            // 
            this.lblDOM_Ctrl.AutoSize = true;
            this.lblDOM_Ctrl.Location = new System.Drawing.Point(430, 15);
            this.lblDOM_Ctrl.Name = "lblDOM_Ctrl";
            this.lblDOM_Ctrl.Size = new System.Drawing.Size(113, 17);
            this.lblDOM_Ctrl.TabIndex = 5;
            this.lblDOM_Ctrl.Text = "Delay of moving:";
            // 
            // NUDdelay_Ctrl
            // 
            this.NUDdelay_Ctrl.Location = new System.Drawing.Point(549, 13);
            this.NUDdelay_Ctrl.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.NUDdelay_Ctrl.Minimum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.NUDdelay_Ctrl.Name = "NUDdelay_Ctrl";
            this.NUDdelay_Ctrl.Size = new System.Drawing.Size(63, 22);
            this.NUDdelay_Ctrl.TabIndex = 5;
            this.NUDdelay_Ctrl.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.NUDdelay_Ctrl.ValueChanged += new System.EventHandler(this.NUDdelay_Ctrl_ValueChanged);
            // 
            // lblNN_Ctrl
            // 
            this.lblNN_Ctrl.AutoSize = true;
            this.lblNN_Ctrl.Location = new System.Drawing.Point(281, 15);
            this.lblNN_Ctrl.Name = "lblNN_Ctrl";
            this.lblNN_Ctrl.Size = new System.Drawing.Size(93, 17);
            this.lblNN_Ctrl.TabIndex = 3;
            this.lblNN_Ctrl.Text = "Nuts number:";
            // 
            // NUDnut_Ctrl
            // 
            this.NUDnut_Ctrl.Location = new System.Drawing.Point(380, 13);
            this.NUDnut_Ctrl.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.NUDnut_Ctrl.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NUDnut_Ctrl.Name = "NUDnut_Ctrl";
            this.NUDnut_Ctrl.Size = new System.Drawing.Size(42, 22);
            this.NUDnut_Ctrl.TabIndex = 4;
            this.NUDnut_Ctrl.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NUDnut_Ctrl.ValueChanged += new System.EventHandler(this.NUDnut_Ctrl_ValueChanged);
            // 
            // btnPause_Ctrl
            // 
            this.btnPause_Ctrl.Enabled = false;
            this.btnPause_Ctrl.Location = new System.Drawing.Point(147, 8);
            this.btnPause_Ctrl.Name = "btnPause_Ctrl";
            this.btnPause_Ctrl.Size = new System.Drawing.Size(63, 30);
            this.btnPause_Ctrl.TabIndex = 1;
            this.btnPause_Ctrl.Text = "Start";
            this.btnPause_Ctrl.UseVisualStyleBackColor = true;
            this.btnPause_Ctrl.Click += new System.EventHandler(this.btnPause_Ctrl_Click);
            // 
            // btnBack_Ctrl
            // 
            this.btnBack_Ctrl.Enabled = false;
            this.btnBack_Ctrl.Location = new System.Drawing.Point(84, 8);
            this.btnBack_Ctrl.Name = "btnBack_Ctrl";
            this.btnBack_Ctrl.Size = new System.Drawing.Size(57, 30);
            this.btnBack_Ctrl.TabIndex = 2;
            this.btnBack_Ctrl.Text = "Back";
            this.btnBack_Ctrl.UseVisualStyleBackColor = true;
            this.btnBack_Ctrl.Click += new System.EventHandler(this.btnBack_Ctrl_Click);
            // 
            // timerMv
            // 
            this.timerMv.Tick += new System.EventHandler(this.TimerMove);
            // 
            // CenterViewPnl_Ctrl
            // 
            this.CenterViewPnl_Ctrl.Controls.Add(this.Middle);
            this.CenterViewPnl_Ctrl.Controls.Add(this.Right);
            this.CenterViewPnl_Ctrl.Controls.Add(this.Left);
            this.CenterViewPnl_Ctrl.Controls.Add(this.label1);
            this.CenterViewPnl_Ctrl.Location = new System.Drawing.Point(5, 24);
            this.CenterViewPnl_Ctrl.Name = "CenterViewPnl_Ctrl";
            this.CenterViewPnl_Ctrl.Size = new System.Drawing.Size(478, 269);
            this.CenterViewPnl_Ctrl.TabIndex = 0;
            // 
            // Middle
            // 
            this.Middle.BackColor = System.Drawing.Color.Gainsboro;
            this.Middle.Controls.Add(this.lblColumnMiddle_Ctrl);
            this.Middle.Location = new System.Drawing.Point(165, 10);
            this.Middle.Name = "Middle";
            this.Middle.Size = new System.Drawing.Size(145, 230);
            this.Middle.TabIndex = 3;
            this.Middle.Tag = "Middle";
            // 
            // lblColumnMiddle_Ctrl
            // 
            this.lblColumnMiddle_Ctrl.BackColor = System.Drawing.Color.DarkKhaki;
            this.lblColumnMiddle_Ctrl.Location = new System.Drawing.Point(64, 0);
            this.lblColumnMiddle_Ctrl.Name = "lblColumnMiddle_Ctrl";
            this.lblColumnMiddle_Ctrl.Size = new System.Drawing.Size(16, 230);
            this.lblColumnMiddle_Ctrl.TabIndex = 8;
            // 
            // Right
            // 
            this.Right.BackColor = System.Drawing.Color.Gainsboro;
            this.Right.Controls.Add(this.lblColumnRight_Ctrl);
            this.Right.Location = new System.Drawing.Point(316, 10);
            this.Right.Name = "Right";
            this.Right.Size = new System.Drawing.Size(145, 230);
            this.Right.TabIndex = 3;
            this.Right.Tag = "Right";
            // 
            // lblColumnRight_Ctrl
            // 
            this.lblColumnRight_Ctrl.BackColor = System.Drawing.Color.DarkKhaki;
            this.lblColumnRight_Ctrl.Location = new System.Drawing.Point(65, 0);
            this.lblColumnRight_Ctrl.Name = "lblColumnRight_Ctrl";
            this.lblColumnRight_Ctrl.Size = new System.Drawing.Size(16, 230);
            this.lblColumnRight_Ctrl.TabIndex = 9;
            // 
            // Left
            // 
            this.Left.BackColor = System.Drawing.Color.Gainsboro;
            this.Left.Controls.Add(this.N);
            this.Left.Controls.Add(this.lblColumnLeft_Ctrl);
            this.Left.Location = new System.Drawing.Point(15, 10);
            this.Left.Name = "Left";
            this.Left.Size = new System.Drawing.Size(145, 230);
            this.Left.TabIndex = 2;
            this.Left.Tag = "Left";
            // 
            // N
            // 
            this.N.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(50)))), ((int)(((byte)(0)))));
            this.N.Location = new System.Drawing.Point(56, 212);
            this.N.Name = "N";
            this.N.Size = new System.Drawing.Size(30, 18);
            this.N.TabIndex = 11;
            this.N.Text = "1";
            this.N.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblColumnLeft_Ctrl
            // 
            this.lblColumnLeft_Ctrl.BackColor = System.Drawing.Color.DarkKhaki;
            this.lblColumnLeft_Ctrl.Location = new System.Drawing.Point(64, 0);
            this.lblColumnLeft_Ctrl.Name = "lblColumnLeft_Ctrl";
            this.lblColumnLeft_Ctrl.Size = new System.Drawing.Size(17, 230);
            this.lblColumnLeft_Ctrl.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.label1.Location = new System.Drawing.Point(0, 240);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(475, 21);
            this.label1.TabIndex = 6;
            this.label1.Text = "                    A                                   B                        " +
    "            C";
            // 
            // ViewPnl_Ctrl
            // 
            this.ViewPnl_Ctrl.BackColor = System.Drawing.Color.Gainsboro;
            this.ViewPnl_Ctrl.Controls.Add(this.CenterViewPnl_Ctrl);
            this.ViewPnl_Ctrl.Location = new System.Drawing.Point(222, 50);
            this.ViewPnl_Ctrl.Name = "ViewPnl_Ctrl";
            this.ViewPnl_Ctrl.Size = new System.Drawing.Size(490, 319);
            this.ViewPnl_Ctrl.TabIndex = 1;
            // 
            // StepList_Ctrl
            // 
            this.StepList_Ctrl.ColumnWidth = 100;
            this.StepList_Ctrl.FormattingEnabled = true;
            this.StepList_Ctrl.IntegralHeight = false;
            this.StepList_Ctrl.ItemHeight = 16;
            this.StepList_Ctrl.Location = new System.Drawing.Point(0, 50);
            this.StepList_Ctrl.Name = "StepList_Ctrl";
            this.StepList_Ctrl.Size = new System.Drawing.Size(218, 319);
            this.StepList_Ctrl.TabIndex = 5;
            this.StepList_Ctrl.SelectedIndexChanged += new System.EventHandler(this.StepList_Ctrl_SelectedIndexChanged);
            // 
            // MoveList_Ctrl
            // 
            this.MoveList_Ctrl.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.MoveList_Ctrl.FormattingEnabled = true;
            this.MoveList_Ctrl.ItemHeight = 16;
            this.MoveList_Ctrl.Location = new System.Drawing.Point(0, 368);
            this.MoveList_Ctrl.Name = "MoveList_Ctrl";
            this.MoveList_Ctrl.Size = new System.Drawing.Size(714, 132);
            this.MoveList_Ctrl.TabIndex = 6;
            // 
            // FrmHanoi_Ctrl
            // 
            this.AcceptButton = this.btnRun_Ctrl;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(714, 500);
            this.Controls.Add(this.MoveList_Ctrl);
            this.Controls.Add(this.StepList_Ctrl);
            this.Controls.Add(this.ViewPnl_Ctrl);
            this.Controls.Add(this.StripPnl_Ctrl);
            this.Name = "FrmHanoi_Ctrl";
            this.Text = "Hanoi";
            this.Load += new System.EventHandler(this.FrmHanoi_Ctrl_Load);
            this.Resize += new System.EventHandler(this.FrmHanoi_Ctrl_Resize);
            this.StripPnl_Ctrl.ResumeLayout(false);
            this.StripPnl_Ctrl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUDdelay_Ctrl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDnut_Ctrl)).EndInit();
            this.CenterViewPnl_Ctrl.ResumeLayout(false);
            this.Middle.ResumeLayout(false);
            this.Right.ResumeLayout(false);
            this.Left.ResumeLayout(false);
            this.ViewPnl_Ctrl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel StripPnl_Ctrl;
        private System.Windows.Forms.Button btnPause_Ctrl;
        private System.Windows.Forms.Button btnBack_Ctrl;
        private System.Windows.Forms.NumericUpDown NUDnut_Ctrl;
        private System.Windows.Forms.Label lblNN_Ctrl;
        private System.Windows.Forms.Label lblDOM_Ctrl;
        private System.Windows.Forms.NumericUpDown NUDdelay_Ctrl;
        private System.Windows.Forms.Timer timerMv;
        private System.Windows.Forms.Button btnNext_Ctrl;
        private System.Windows.Forms.Button btnRun_Ctrl;
        private System.Windows.Forms.Panel CenterViewPnl_Ctrl;
        private System.Windows.Forms.Panel Middle;
        private System.Windows.Forms.Label lblColumnMiddle_Ctrl;
        private System.Windows.Forms.Panel Right;
        private System.Windows.Forms.Label lblColumnRight_Ctrl;
        private System.Windows.Forms.Panel Left;
        private System.Windows.Forms.Label N;
        private System.Windows.Forms.Label lblColumnLeft_Ctrl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel ViewPnl_Ctrl;
        private System.Windows.Forms.ListBox StepList_Ctrl;
        private System.Windows.Forms.ListBox MoveList_Ctrl;
    }
}

