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

        private void setNumericUpDownLimit()
        {
            int scrNum = 0;
            int.TryParse(Convert.ToString(numericUpDownScreenNumber.Value), out scrNum);

            numericUpDownTopLeftX.Minimum = Screen.AllScreens[scrNum].Bounds.Left;
            numericUpDownTopLeftY.Minimum = Screen.AllScreens[scrNum].Bounds.Top;
            numericUpDownBottomRightX.Minimum = Screen.AllScreens[scrNum].Bounds.Right;
            numericUpDownBottomRightY.Minimum = Screen.AllScreens[scrNum].Bounds.Bottom;
            numericUpDownWidth.Minimum = 0;
            numericUpDownHeight.Minimum = 0;

            numericUpDownTopLeftX.Maximum = Screen.AllScreens[scrNum].Bounds.Left + Screen.AllScreens[scrNum].Bounds.Width;
            numericUpDownTopLeftY.Maximum = Screen.AllScreens[scrNum].Bounds.Top;
            numericUpDownBottomRightX.Maximum = Screen.AllScreens[scrNum].Bounds.Right + Screen.AllScreens[scrNum].Bounds.Width;
            numericUpDownBottomRightY.Maximum = Screen.AllScreens[scrNum].Bounds.Bottom + Screen.AllScreens[scrNum].Bounds.Height;
            numericUpDownWidth.Maximum = Math.Abs(Screen.AllScreens[scrNum].Bounds.Left - Screen.AllScreens[scrNum].Bounds.Right)
                + Math.Abs(Screen.AllScreens[scrNum].Bounds.Width);
            numericUpDownHeight.Maximum = Math.Abs(Screen.AllScreens[scrNum].Bounds.Top - Screen.AllScreens[scrNum].Bounds.Bottom)
                + Math.Abs(Screen.AllScreens[scrNum].Bounds.Height);

            if (!changingNumericUpDown)
            {
                changingNumericUpDown = true;
                numericUpDownTopLeftX.Value = Screen.AllScreens[scrNum].Bounds.Left;
                numericUpDownTopLeftY.Value = Screen.AllScreens[scrNum].Bounds.Top;
                numericUpDownBottomRightX.Value = Screen.AllScreens[scrNum].Bounds.Right;
                numericUpDownBottomRightY.Value = Screen.AllScreens[scrNum].Bounds.Bottom;
                numericUpDownWidth.Value = Screen.AllScreens[scrNum].Bounds.Width;
                numericUpDownHeight.Value = Screen.AllScreens[scrNum].Bounds.Height;
                changingNumericUpDown = false;
            }
        }

        private void buttonPrtscr_Click(object sender, EventArgs e)
        {
        }

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

        private void prtScrToolStripMenuItem_Click(object sender, EventArgs e)
        {
            takePrtscr();
        }

        // HotKey
        void hotKey_HotKeyPush(object sender, EventArgs e)
        {
            takePrtscr();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            hotKey.Dispose();
        }
    }
}
