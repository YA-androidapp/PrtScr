// Copyright (c) 2016 YA-androidapp(https://github.com/YA-androidapp) All rights reserved.
namespace PrtScr
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.numericUpDownTopLeftX = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownTopLeftY = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDownBottomRightY = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownBottomRightX = new System.Windows.Forms.NumericUpDown();
            this.capturedPictureBox = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.numericUpDownScreenNumber = new System.Windows.Forms.NumericUpDown();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.numericUpDownWidth = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownHeight = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.checkBoxTimer = new System.Windows.Forms.CheckBox();
            this.checkBoxSaveToPng = new System.Windows.Forms.CheckBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.TopLeftX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TopLeftY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Width = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Height = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColorName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.checkBoxEnableMasking = new System.Windows.Forms.CheckBox();
            this.toolTipInfo = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.prtScrToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTopLeftX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTopLeftY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBottomRightY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBottomRightX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.capturedPictureBox)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownScreenNumber)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownHeight)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // numericUpDownTopLeftX
            // 
            this.numericUpDownTopLeftX.Location = new System.Drawing.Point(6, 18);
            this.numericUpDownTopLeftX.Name = "numericUpDownTopLeftX";
            this.numericUpDownTopLeftX.Size = new System.Drawing.Size(60, 19);
            this.numericUpDownTopLeftX.TabIndex = 1;
            this.numericUpDownTopLeftX.ValueChanged += new System.EventHandler(this.numericUpDownTopLeftX_ValueChanged);
            // 
            // numericUpDownTopLeftY
            // 
            this.numericUpDownTopLeftY.Location = new System.Drawing.Point(83, 18);
            this.numericUpDownTopLeftY.Name = "numericUpDownTopLeftY";
            this.numericUpDownTopLeftY.Size = new System.Drawing.Size(60, 19);
            this.numericUpDownTopLeftY.TabIndex = 2;
            this.numericUpDownTopLeftY.ValueChanged += new System.EventHandler(this.numericUpDownTopLeftY_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(70, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(7, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = ",";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(70, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(7, 12);
            this.label2.TabIndex = 6;
            this.label2.Text = ",";
            // 
            // numericUpDownBottomRightY
            // 
            this.numericUpDownBottomRightY.Location = new System.Drawing.Point(83, 18);
            this.numericUpDownBottomRightY.Name = "numericUpDownBottomRightY";
            this.numericUpDownBottomRightY.Size = new System.Drawing.Size(60, 19);
            this.numericUpDownBottomRightY.TabIndex = 5;
            this.numericUpDownBottomRightY.ValueChanged += new System.EventHandler(this.numericUpDownBottomRightY_ValueChanged);
            // 
            // numericUpDownBottomRightX
            // 
            this.numericUpDownBottomRightX.Location = new System.Drawing.Point(6, 18);
            this.numericUpDownBottomRightX.Name = "numericUpDownBottomRightX";
            this.numericUpDownBottomRightX.Size = new System.Drawing.Size(60, 19);
            this.numericUpDownBottomRightX.TabIndex = 4;
            this.numericUpDownBottomRightX.ValueChanged += new System.EventHandler(this.numericUpDownBottomRightX_ValueChanged);
            // 
            // capturedPictureBox
            // 
            this.capturedPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.capturedPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.capturedPictureBox.Location = new System.Drawing.Point(3, 175);
            this.capturedPictureBox.Name = "capturedPictureBox";
            this.capturedPictureBox.Size = new System.Drawing.Size(576, 324);
            this.capturedPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.capturedPictureBox.TabIndex = 7;
            this.capturedPictureBox.TabStop = false;
            this.toolTipInfo.SetToolTip(this.capturedPictureBox, "Copyright (c) 2016 YA-androidapp(https://github.com/YA-androidapp) All rights res" +
        "erved.");
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.numericUpDownScreenNumber);
            this.panel1.Controls.Add(this.groupBox3);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Location = new System.Drawing.Point(3, 28);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(223, 130);
            this.panel1.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(155, 5);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 13;
            this.label4.Text = "Screen num";
            // 
            // numericUpDownScreenNumber
            // 
            this.numericUpDownScreenNumber.Location = new System.Drawing.Point(157, 18);
            this.numericUpDownScreenNumber.Name = "numericUpDownScreenNumber";
            this.numericUpDownScreenNumber.Size = new System.Drawing.Size(63, 19);
            this.numericUpDownScreenNumber.TabIndex = 12;
            this.toolTipInfo.SetToolTip(this.numericUpDownScreenNumber, "撮影対象のスクリーン(マルチディスプレイ環境)");
            this.numericUpDownScreenNumber.ValueChanged += new System.EventHandler(this.numericUpDownScreenNumber_ValueChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.numericUpDownWidth);
            this.groupBox3.Controls.Add(this.numericUpDownHeight);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Location = new System.Drawing.Point(39, 46);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(150, 40);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Size";
            // 
            // numericUpDownWidth
            // 
            this.numericUpDownWidth.Location = new System.Drawing.Point(6, 18);
            this.numericUpDownWidth.Name = "numericUpDownWidth";
            this.numericUpDownWidth.Size = new System.Drawing.Size(60, 19);
            this.numericUpDownWidth.TabIndex = 4;
            this.numericUpDownWidth.ValueChanged += new System.EventHandler(this.numericUpDownWidth_ValueChanged);
            // 
            // numericUpDownHeight
            // 
            this.numericUpDownHeight.Location = new System.Drawing.Point(83, 18);
            this.numericUpDownHeight.Name = "numericUpDownHeight";
            this.numericUpDownHeight.Size = new System.Drawing.Size(60, 19);
            this.numericUpDownHeight.TabIndex = 5;
            this.numericUpDownHeight.ValueChanged += new System.EventHandler(this.numericUpDownHeight_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(70, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(7, 12);
            this.label3.TabIndex = 6;
            this.label3.Text = ",";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.numericUpDownBottomRightX);
            this.groupBox2.Controls.Add(this.numericUpDownBottomRightY);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(70, 89);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(150, 40);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "BottomRight";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.numericUpDownTopLeftX);
            this.groupBox1.Controls.Add(this.numericUpDownTopLeftY);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(150, 40);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "TopLeft";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.checkBoxTimer);
            this.panel2.Controls.Add(this.checkBoxSaveToPng);
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Controls.Add(this.checkBoxEnableMasking);
            this.panel2.Location = new System.Drawing.Point(229, 28);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(350, 130);
            this.panel2.TabIndex = 11;
            // 
            // checkBoxTimer
            // 
            this.checkBoxTimer.AutoSize = true;
            this.checkBoxTimer.Location = new System.Drawing.Point(94, 3);
            this.checkBoxTimer.Name = "checkBoxTimer";
            this.checkBoxTimer.Size = new System.Drawing.Size(74, 16);
            this.checkBoxTimer.TabIndex = 15;
            this.checkBoxTimer.Text = "Self timer";
            this.toolTipInfo.SetToolTip(this.checkBoxTimer, "PrtScrメニュー押下時にPNGファイルを保存");
            this.checkBoxTimer.UseVisualStyleBackColor = true;
            // 
            // checkBoxSaveToPng
            // 
            this.checkBoxSaveToPng.AutoSize = true;
            this.checkBoxSaveToPng.Location = new System.Drawing.Point(3, 3);
            this.checkBoxSaveToPng.Name = "checkBoxSaveToPng";
            this.checkBoxSaveToPng.Size = new System.Drawing.Size(90, 16);
            this.checkBoxSaveToPng.TabIndex = 14;
            this.checkBoxSaveToPng.Text = "Save to PNG";
            this.toolTipInfo.SetToolTip(this.checkBoxSaveToPng, "PrtScrメニュー押下時にPNGファイルを保存");
            this.checkBoxSaveToPng.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TopLeftX,
            this.TopLeftY,
            this.Width,
            this.Height,
            this.ColorName});
            this.dataGridView1.Location = new System.Drawing.Point(3, 46);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 21;
            this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView1.Size = new System.Drawing.Size(345, 80);
            this.dataGridView1.TabIndex = 1;
            this.toolTipInfo.SetToolTip(this.dataGridView1, "個人情報など、スクリーンショットには載せたくない情報をマスクします");
            // 
            // TopLeftX
            // 
            this.TopLeftX.HeaderText = "TopLeftX";
            this.TopLeftX.MaxInputLength = 6;
            this.TopLeftX.Name = "TopLeftX";
            this.TopLeftX.Width = 60;
            // 
            // TopLeftY
            // 
            this.TopLeftY.HeaderText = "TopLeftY";
            this.TopLeftY.MaxInputLength = 6;
            this.TopLeftY.Name = "TopLeftY";
            this.TopLeftY.Width = 60;
            // 
            // Width
            // 
            this.Width.FillWeight = 50F;
            this.Width.HeaderText = "Width";
            this.Width.MaxInputLength = 6;
            this.Width.Name = "Width";
            this.Width.Width = 50;
            // 
            // Height
            // 
            this.Height.FillWeight = 50F;
            this.Height.HeaderText = "Height";
            this.Height.MaxInputLength = 6;
            this.Height.Name = "Height";
            this.Height.Width = 50;
            // 
            // ColorName
            // 
            this.ColorName.FillWeight = 80F;
            this.ColorName.HeaderText = "ColorName";
            this.ColorName.Name = "ColorName";
            this.ColorName.Width = 80;
            // 
            // checkBoxEnableMasking
            // 
            this.checkBoxEnableMasking.AutoSize = true;
            this.checkBoxEnableMasking.Location = new System.Drawing.Point(3, 25);
            this.checkBoxEnableMasking.Name = "checkBoxEnableMasking";
            this.checkBoxEnableMasking.Size = new System.Drawing.Size(104, 16);
            this.checkBoxEnableMasking.TabIndex = 0;
            this.checkBoxEnableMasking.Text = "Enable masking";
            this.toolTipInfo.SetToolTip(this.checkBoxEnableMasking, "個人情報など、スクリーンショットには載せたくない情報をマスクします");
            this.checkBoxEnableMasking.UseVisualStyleBackColor = true;
            // 
            // toolTipInfo
            // 
            this.toolTipInfo.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.prtScrToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(584, 24);
            this.menuStrip1.TabIndex = 12;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // prtScrToolStripMenuItem
            // 
            this.prtScrToolStripMenuItem.Name = "prtScrToolStripMenuItem";
            this.prtScrToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.Insert;
            this.prtScrToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.prtScrToolStripMenuItem.Text = "PrtScr";
            this.prtScrToolStripMenuItem.Click += new System.EventHandler(this.prtScrToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 511);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.capturedPictureBox);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "PrtScr";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTopLeftX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTopLeftY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBottomRightY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBottomRightX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.capturedPictureBox)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownScreenNumber)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownHeight)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.NumericUpDown numericUpDownTopLeftX;
        private System.Windows.Forms.NumericUpDown numericUpDownTopLeftY;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericUpDownBottomRightY;
        private System.Windows.Forms.NumericUpDown numericUpDownBottomRightX;
        private System.Windows.Forms.PictureBox capturedPictureBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.CheckBox checkBoxEnableMasking;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.NumericUpDown numericUpDownWidth;
        private System.Windows.Forms.NumericUpDown numericUpDownHeight;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numericUpDownScreenNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn TopLeftX;
        private System.Windows.Forms.DataGridViewTextBoxColumn TopLeftY;
        private System.Windows.Forms.DataGridViewTextBoxColumn Width;
        private System.Windows.Forms.DataGridViewTextBoxColumn Height;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColorName;
        private System.Windows.Forms.ToolTip toolTipInfo;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem prtScrToolStripMenuItem;
        private System.Windows.Forms.CheckBox checkBoxSaveToPng;
        private System.Windows.Forms.CheckBox checkBoxTimer;
    }
}

