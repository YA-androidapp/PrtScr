// Copyright (c) 2016 YA-androidapp(https://github.com/YA-androidapp) All rights reserved.

using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace PrtScr
{
    public partial class Form1 : Form
    {
        // HotKey
        HotKey hotKey;

        static bool changingNumericUpDown = false;

        public Form1()
        {
            InitializeComponent();
            
            // 初期化
            dataGridView1.Rows.Add();
            dataGridView1.Rows[0].Cells[4].Value = "Black";

            int scrNum = Screen.AllScreens.Length;
            numericUpDownScreenNumber.Maximum = scrNum - 1;
            numericUpDownScreenNumber.Minimum = 0;

            setNumericUpDownLimit();
        }

        /// <summary>
        /// NumericUpDownの初期設定を行う
        /// </summary>
        private void setNumericUpDownLimit()
        {
            int scrNum = 0;
            int.TryParse(Convert.ToString(numericUpDownScreenNumber.Value), out scrNum);

            // Graphics desktop = Graphics.FromHwnd(Handle);
            float scaleX = 3; // desktop.DpiX / 96.0f;
            float scaleY = 3; // desktop.DpiY / 96.0f;

            int b = Screen.AllScreens[scrNum].Bounds.Bottom;    //  1080
            int h = Screen.AllScreens[scrNum].Bounds.Height;    //  2160
            int l = Screen.AllScreens[scrNum].Bounds.Left;      //  1920
            int r = Screen.AllScreens[scrNum].Bounds.Right;     //  5760
            int t = Screen.AllScreens[scrNum].Bounds.Top;       // -1080
            int w = Screen.AllScreens[scrNum].Bounds.Width;     //  3840

            numericUpDownTopLeftX.Minimum       = l - w;
            numericUpDownTopLeftY.Minimum       = t - h;
            numericUpDownBottomRightX.Minimum   = l;
            numericUpDownBottomRightY.Minimum   = t;
            numericUpDownWidth.Minimum          = 0;
            numericUpDownHeight.Minimum         = 0;

            numericUpDownTopLeftX.Maximum       = (int)(scaleX * r);
            numericUpDownTopLeftY.Maximum       = (int)(scaleX * b);
            numericUpDownBottomRightX.Maximum   = (int)(scaleX * r + w);
            numericUpDownBottomRightY.Maximum   = (int)(scaleX * b + h);
            numericUpDownWidth.Maximum          = (int)(scaleX * Math.Abs(w));
            numericUpDownHeight.Maximum         = (int)(scaleY * Math.Abs(h));

            if (!changingNumericUpDown)
            {
                changingNumericUpDown = true;
                numericUpDownTopLeftX.Value     = l;
                numericUpDownTopLeftY.Value     = t;
                numericUpDownBottomRightX.Value = r;
                numericUpDownBottomRightY.Value = b;
                numericUpDownWidth.Value        = w;
                numericUpDownHeight.Value       = h;
                changingNumericUpDown = false;
            }
        }

        /// <summary>
        /// フォームをロード
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {
            // HotKey
            hotKey = new HotKey(MOD_KEY.SHIFT, Keys.PrintScreen);
            hotKey.HotKeyPush += new EventHandler(hotKey_HotKeyPush);

            // 初期化
            numericUpDownTopLeftX.Value = 0;
            numericUpDownTopLeftY.Value = 0;
            numericUpDownBottomRightX.Value = Screen.PrimaryScreen.Bounds.Width;
            numericUpDownBottomRightY.Value = Screen.PrimaryScreen.Bounds.Height;
            numericUpDownWidth.Value = Screen.PrimaryScreen.Bounds.Width;
            numericUpDownHeight.Value = Screen.PrimaryScreen.Bounds.Height;
        }

        /// <summary>
        /// 右下を変更→左上はそのままサイズを変更
        /// </summary>
        private void numericUpDownBottomRightX_ValueChanged(object sender, EventArgs e)
        {
            if (!changingNumericUpDown)
            {
                changingNumericUpDown = true;
                int value = Math.Abs((int)(numericUpDownTopLeftX.Value - numericUpDownBottomRightX.Value));
                if (numericUpDownWidth.Minimum <= value && value <= numericUpDownWidth.Maximum)
                    numericUpDownWidth.Value = value;
                changingNumericUpDown = false;
            }
        }

        /// <summary>
        /// 右下を変更→左上はそのままサイズを変更
        /// </summary>
        private void numericUpDownBottomRightY_ValueChanged(object sender, EventArgs e)
        {
            if (!changingNumericUpDown)
            {
                changingNumericUpDown = true;
                int value = Math.Abs((int)(numericUpDownTopLeftY.Value - numericUpDownBottomRightY.Value));
                if (numericUpDownHeight.Minimum <= value && value <= numericUpDownHeight.Maximum)
                    numericUpDownHeight.Value = value;
                changingNumericUpDown = false;
            }
        }

        /// <summary>
        /// サイズを変更→左上はそのまま右下を移動
        /// </summary>
        private void numericUpDownWidth_ValueChanged(object sender, EventArgs e)
        {
            if (!changingNumericUpDown)
            {
                changingNumericUpDown = true;
                int value = Math.Abs((int)(numericUpDownTopLeftX.Value + numericUpDownWidth.Value));
                if (numericUpDownBottomRightX.Minimum <= value && value <= numericUpDownBottomRightX.Maximum)
                    numericUpDownBottomRightX.Value = value;
                changingNumericUpDown = false;
            }
        }

        /// <summary>
        /// サイズを変更→左上はそのまま右下を移動
        /// </summary>
        private void numericUpDownHeight_ValueChanged(object sender, EventArgs e)
        {
            if (!changingNumericUpDown)
            {
                changingNumericUpDown = true;
                int value = Math.Abs((int)(numericUpDownTopLeftY.Value + numericUpDownHeight.Value));
                if (numericUpDownBottomRightY.Minimum <= value && value <= numericUpDownBottomRightY.Maximum)
                    numericUpDownBottomRightY.Value = value;
                changingNumericUpDown = false;
            }
        }

        private void numericUpDownScreenNumber_ValueChanged(object sender, EventArgs e)
        {
            setNumericUpDownLimit();
        }

        /// <summary>
        /// 左上を変更→サイズはそのまま右下を移動
        /// </summary>
        private void numericUpDownTopLeftX_ValueChanged(object sender, EventArgs e)
        {
            if (!changingNumericUpDown)
            {
                changingNumericUpDown = true;
                int value = Math.Abs((int)(numericUpDownTopLeftX.Value + numericUpDownWidth.Value));
                if (numericUpDownBottomRightX.Minimum <= value && value <= numericUpDownBottomRightX.Maximum)
                    numericUpDownBottomRightX.Value = value;
                changingNumericUpDown = false;
            }
        }

        /// <summary>
        /// 左上を変更→サイズはそのまま右下を移動
        /// </summary>
        private void numericUpDownTopLeftY_ValueChanged(object sender, EventArgs e)
        {
            if (!changingNumericUpDown)
            {
                changingNumericUpDown = true;
                int value = Math.Abs((int)(numericUpDownTopLeftY.Value + numericUpDownHeight.Value));
                if (numericUpDownBottomRightY.Minimum <= value && value <= numericUpDownBottomRightY.Maximum)
                    numericUpDownBottomRightY.Value = value;
                changingNumericUpDown = false;
            }
        }

        /// <summary>
        /// マスクする
        /// </summary>
        /// <param name="bmp">加工対象のBitmap</param>
        /// <returns></returns>
        private Bitmap mask(Bitmap bmp)
        {
            if (dataGridView1.RowCount > 0)
            {
                for (int i = 0; i < dataGridView1.RowCount; i++)
                {
                    using (Graphics g = Graphics.FromImage(bmp))
                    {
                        Rectangle rect;

                        int x = -1, y = -1, w = -1, h = -1;
                        int.TryParse(Convert.ToString(dataGridView1.Rows[i].Cells[0].Value), out x);
                        int.TryParse(Convert.ToString(dataGridView1.Rows[i].Cells[1].Value), out y);
                        int.TryParse(Convert.ToString(dataGridView1.Rows[i].Cells[2].Value), out w);
                        int.TryParse(Convert.ToString(dataGridView1.Rows[i].Cells[3].Value), out h);

                        if (x > -1 && y > -1 && w > -1 && h > -1)
                        {
                            rect = new Rectangle(x, y, w, h);

                            Color color = Color.Black;
                            string c = Convert.ToString(dataGridView1.Rows[i].Cells[4].Value);
                            if (c != "")
                            {
                                try
                                {
                                    color = ColorTranslator.FromHtml(c);
                                }
                                catch (Exception)
                                {
                                    color = Color.Black;
                                }
                            }

                            // SolidBrush b = new SolidBrush(Color.FromArgb(100, 200, 50, 100)); // Brushes.Blue
                            SolidBrush b = new SolidBrush(color);
                            g.FillRectangle(b, rect);
                        }
                    }
                }
            }

            return bmp;
        }

        /// <summary>
        /// スクリーンショットを撮る
        /// </summary>
        private void takePrtscr()
        {
            int bmpWidth = Math.Abs((int)(numericUpDownBottomRightX.Value - numericUpDownTopLeftX.Value));
            int bmpHeight = Math.Abs((int)(numericUpDownBottomRightY.Value - numericUpDownTopLeftY.Value));


            int scrNum = 0;
            int.TryParse(Convert.ToString(numericUpDownScreenNumber.Value), out scrNum);
            Bitmap bmp = new Bitmap(bmpWidth, bmpHeight);

            using (Graphics g = Graphics.FromImage(bmp))
            {
                g.CopyFromScreen(new Point((int)numericUpDownTopLeftX.Value, (int)numericUpDownTopLeftY.Value), new Point(0, 0), bmp.Size, CopyPixelOperation.SourceCopy);
            }

            string datetime = DateTime.Now.ToString("yyyyMMddHHmmss");
            string filename = @".\" + datetime + ".png";
            if (checkBoxEnableMasking.Checked)
            {
                capturedPictureBox.Image = mask(bmp);
                if (checkBoxSaveToPng.Checked)
                    mask(bmp).Save(filename, ImageFormat.Png);
            }
            else
            {
                capturedPictureBox.Image = bmp;
                if (checkBoxSaveToPng.Checked)
                    bmp.Save(filename, ImageFormat.Png);
            }
        }

        /// <summary>
        /// フォームを隠したうえでスクリーンショットを撮る
        /// </summary>
        private void takePrtscrWithHiding()
        {
            this.ShowInTaskbar = false;
            this.Opacity = 0;
            if(checkBoxTimer.Checked)
                System.Threading.Thread.Sleep(2000);
            takePrtscr();
            System.Media.SystemSounds.Asterisk.Play();
            this.Opacity = 1;
            this.ShowInTaskbar = true;
        }

        /// <summary>
        /// メニュー押下時
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void prtScrToolStripMenuItem_Click(object sender, EventArgs e)
        {
            takePrtscrWithHiding();
        }

        /// <summary>
        /// ホットキー押下時
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void hotKey_HotKeyPush(object sender, EventArgs e)
        {
            takePrtscrWithHiding();
        }

        /// <summary>
        /// 後片付け
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            hotKey.Dispose();
        }
    }
}
