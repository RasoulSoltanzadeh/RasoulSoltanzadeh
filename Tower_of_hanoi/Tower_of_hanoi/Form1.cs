using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Drawing;
namespace Tower_of_hanoi
{
    public partial class FrmHanoi_Ctrl : Form
    {
        int n = 0;
        List<Label> labels = new List<Label>();
        public FrmHanoi_Ctrl()
        {
            InitializeComponent();
        }
        private void FrmHanoi_Ctrl_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
            lblColumnLeft_Ctrl.SendToBack();
            lblColumnMiddle_Ctrl.SendToBack();
            lblColumnRight_Ctrl.SendToBack();
            StepList_Ctrl.Height = 355 - MoveList_Ctrl.Height + 6;
            ViewPnl_Ctrl.Height = StepList_Ctrl.Height;
            ViewPnl_Ctrl.Width = 409;
            CenterViewPnl_Ctrl.Left = (ViewPnl_Ctrl.Width / 2) - (CenterViewPnl_Ctrl.Width / 2) - 16;
            CenterViewPnl_Ctrl.Top = (ViewPnl_Ctrl.Height / 2) - (CenterViewPnl_Ctrl.Height / 2) - 16;
        }
        private void FrmHanoi_Ctrl_Resize(object sender, EventArgs e)
        {
            StepList_Ctrl.Height = this.Height - 82 - MoveList_Ctrl.Height -2;
            ViewPnl_Ctrl.Height = StepList_Ctrl.Height;
            ViewPnl_Ctrl.Width = this.Width - 184;
            CenterViewPnl_Ctrl.Left = (ViewPnl_Ctrl.Width / 2) - (CenterViewPnl_Ctrl.Width / 2);
            CenterViewPnl_Ctrl.Top = (ViewPnl_Ctrl.Height / 2) - (CenterViewPnl_Ctrl.Height / 2);
        }
        private void btnBack_Ctrl_Click(object sender, EventArgs e)
        {
            StepList_Ctrl.SelectedIndex = StepList_Ctrl.SelectedIndex == 0 ? 1 : StepList_Ctrl.SelectedIndex;
            StepList_Ctrl.SelectedIndex -= 1;
        }
        private void btnPause_Ctrl_Click(object sender, EventArgs e)
        {
            btnRun_Ctrl.Enabled = false;
            NUDdelay_Ctrl.Enabled = !btnNext_Ctrl.Enabled;
            timerMv.Enabled = !timerMv.Enabled;
            btnPause_Ctrl.Text = timerMv.Enabled ? "Pause" : "Start";
            btnBack_Ctrl.Enabled = btnNext_Ctrl.Enabled = !timerMv.Enabled;
        }
        private void NUDnut_Ctrl_ValueChanged(object sender, EventArgs e)
        {
            Label[] lbl = new Label[(int)NUDnut_Ctrl.Value];
            for (int i = 0; i < lbl.Length; i++)
            {
                lbl[i] = new Label();
                lbl[i].Height = 15;
                lbl[i].Width = ((lbl.Length-i)*10)+10;
                lbl[i].BackColor = Color.FromArgb(200, 50 + (i * 20), 0);
                lbl[i].Name = "N";
                lbl[i].Top = Left.Bottom-(i*15)-23;
                lbl[i].Left = ((Left.Width / 2)-(lbl[i].Width/2))+1;
                lbl[i].TextAlign = ContentAlignment.MiddleCenter;
                lbl[i].Text = "" + (i + 1);
                lbl[i].Parent = Left;
            }
            Left.Controls.Clear();
            Left.Controls.Add(lblColumnLeft_Ctrl);
            Middle.Controls.Clear();
            Middle.Controls.Add(lblColumnMiddle_Ctrl);
            Right.Controls.Clear();
            Right.Controls.Add(lblColumnRight_Ctrl);
            lblColumnLeft_Ctrl.SendToBack();
            Left.Controls.AddRange(lbl);
            lblColumnLeft_Ctrl.SendToBack();
            labels.Clear();
            labels.AddRange(lbl);
            btnBack_Ctrl.Enabled = btnPause_Ctrl.Enabled = btnNext_Ctrl.Enabled = false;
        }
        private void NUDdelay_Ctrl_ValueChanged(object sender, EventArgs e)
        {
            timerMv.Interval = (int)NUDdelay_Ctrl.Value;
            MoveList_Ctrl.Items.Add($"{n++}   You changed delay of moving on {(int)NUDdelay_Ctrl.Value} Millisecond.");
        }
        private void StepList_Ctrl_SelectedIndexChanged(object sender, EventArgs e)
        {
            Panel[] pnls = new Panel[] { Left, Middle, Right };
            Label lbl = new Label();
            int j = 0;
            for (int i = 0; i < 3; i++)
            {
                foreach (string item in ExutableString()[i])
                {
                    j++;
                    lbl = GetLable(item);
                    if (lbl.Visible && (lbl.Parent.Name != pnls[i].Name))  MoveList_Ctrl.Items.Add($"{n++}   Disk {lbl.Text} Moved from {lbl.Parent.Name} rod to {pnls[i].Name} rod.");
                    lbl.Parent = pnls[i];
                    lbl.Top = lbl.Parent.Height - (j * 15);
                    lblColumnLeft_Ctrl.SendToBack();
                    lblColumnMiddle_Ctrl.SendToBack();
                    lblColumnRight_Ctrl.SendToBack();
                }
                j = 0;
            }
        }
        private void TimerMove(object sender, EventArgs e)
        {
            StepList_Ctrl.SelectedIndex = StepList_Ctrl.SelectedIndex == (StepList_Ctrl.Items.Count - 1) ? 0 : StepList_Ctrl.SelectedIndex;
            StepList_Ctrl.SelectedIndex++;
            if (StepList_Ctrl.SelectedIndex == (StepList_Ctrl.Items.Count - 1)) 
            {
                timerMv.Stop();
                btnPause_Ctrl.Text = "Start";
                NUDdelay_Ctrl.Enabled = NUDnut_Ctrl.Enabled = btnNext_Ctrl.Enabled = btnBack_Ctrl.Enabled = true;
                btnRun_Ctrl.Enabled = true;
            }
        }
        private void btnNext_Ctrl_Click(object sender, EventArgs e)
        {
            StepList_Ctrl.SelectedIndex = StepList_Ctrl.SelectedIndex == (StepList_Ctrl.Items.Count - 1) ? 0 : StepList_Ctrl.SelectedIndex;
            StepList_Ctrl.SelectedIndex += 1;
        }
        private void btnRun_Ctrl_Click(object sender, EventArgs e)
        {
            string[] rods = new string[3];
            Nut[] nuts = new Nut[(int)NUDnut_Ctrl.Value];
            for (int i = 0; i < nuts.Length; i++) nuts[i] = new Nut();
            Tower tower = new Tower(nuts);
            StepList_Ctrl.Width = (((int)NUDnut_Ctrl.Value) * 10) + 130;
            ViewPnl_Ctrl.Left = StepList_Ctrl.Right + 3;
            StepList_Ctrl.Items.Clear();
            for (int i = 0; i < Tower.Answer.Count; i++) 
            {
                rods = new string[] { "", "", "" };
                foreach (Nut item in Tower.Answer[i].Nuts) rods[(int)item.Culomn] += (item.Size + 1).ToString() + " ";
                StepList_Ctrl.Items.Add($"Step {i + 1}: (A: {rods[0]}) (B: {rods[1]}) (C: {rods[2]})"); 
            }
            btnPause_Ctrl.Enabled = true;
            NUDdelay_Ctrl.Enabled = NUDnut_Ctrl.Enabled = false;
            MoveList_Ctrl.Items.AddRange(new object[] { $"{n++}",$"{n++}   You Started a new hanoi problem with {(int)NUDnut_Ctrl.Value} disks to solve.",$"{n++}"});
        }
        private string[][] ExutableString() 
        {
            string[] str1 = StepList_Ctrl.SelectedItem.ToString().Remove(0, 2+StepList_Ctrl.SelectedItem.ToString().IndexOf('A')).Replace("(", "").Replace("B","").Replace("C","").Replace(":","").Split(')');
            string[][] str2 = new string[3][];
            int[,] nums = new int[3, (int)NUDnut_Ctrl.Value];
            for (int i = 0; i < str2.Length; i++) str2[i] = str1[i].Trim().Replace(" ",",").Split(',');
            return str2;
        }
        private Label GetLable(string num) 
        {
            Label label = new Label();
            label.Hide();
            foreach (Label item in labels) if (item.Text == num) return item;
            return label;
        }
    }
}
