namespace DailyPicture
{
    partial class Main
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.Notify = new System.Windows.Forms.NotifyIcon(this.components);
            this.TxtMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.show = new System.Windows.Forms.ToolStripMenuItem();
            this.about = new System.Windows.Forms.ToolStripMenuItem();
            this.exit = new System.Windows.Forms.ToolStripMenuItem();
            this.PicBox1 = new System.Windows.Forms.PictureBox();
            this.PicBox2 = new System.Windows.Forms.PictureBox();
            this.PicBox3 = new System.Windows.Forms.PictureBox();
            this.PicBox4 = new System.Windows.Forms.PictureBox();
            this.PicBox5 = new System.Windows.Forms.PictureBox();
            this.MainPicBox = new System.Windows.Forms.PictureBox();
            this.PicInfo = new System.Windows.Forms.Label();
            this.Tip = new System.Windows.Forms.ToolTip(this.components);
            this.NextPic = new System.Windows.Forms.Button();
            this.LastPic = new System.Windows.Forms.Button();
            this.TxtMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MainPicBox)).BeginInit();
            this.SuspendLayout();
            // 
            // Notify
            // 
            this.Notify.BalloonTipText = "程序在后台运行，已经最小化到通知栏。";
            this.Notify.BalloonTipTitle = "Daily Picture";
            this.Notify.ContextMenuStrip = this.TxtMenu;
            this.Notify.Icon = ((System.Drawing.Icon)(resources.GetObject("Notify.Icon")));
            this.Notify.Visible = true;
            this.Notify.MouseClick += new System.Windows.Forms.MouseEventHandler(this.notify_MouseClick);
            // 
            // TxtMenu
            // 
            this.TxtMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.show,
            this.about,
            this.exit});
            this.TxtMenu.Name = "txtMenu";
            this.TxtMenu.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.TxtMenu.Size = new System.Drawing.Size(101, 70);
            // 
            // show
            // 
            this.show.Name = "show";
            this.show.Size = new System.Drawing.Size(100, 22);
            this.show.Text = "显示";
            this.show.Click += new System.EventHandler(this.show_Click);
            // 
            // about
            // 
            this.about.Name = "about";
            this.about.Size = new System.Drawing.Size(100, 22);
            this.about.Text = "关于";
            this.about.Click += new System.EventHandler(this.about_Click);
            // 
            // exit
            // 
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(100, 22);
            this.exit.Text = "退出";
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // PicBox1
            // 
            this.PicBox1.BackColor = System.Drawing.SystemColors.Window;
            this.PicBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PicBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PicBox1.ErrorImage = null;
            this.PicBox1.InitialImage = null;
            this.PicBox1.Location = new System.Drawing.Point(827, 12);
            this.PicBox1.Name = "PicBox1";
            this.PicBox1.Size = new System.Drawing.Size(149, 87);
            this.PicBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicBox1.TabIndex = 2;
            this.PicBox1.TabStop = false;
            this.PicBox1.Click += new System.EventHandler(this.PicBox1_Click);
            // 
            // PicBox2
            // 
            this.PicBox2.BackColor = System.Drawing.SystemColors.Window;
            this.PicBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PicBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PicBox2.ErrorImage = null;
            this.PicBox2.InitialImage = null;
            this.PicBox2.Location = new System.Drawing.Point(827, 105);
            this.PicBox2.Name = "PicBox2";
            this.PicBox2.Size = new System.Drawing.Size(149, 87);
            this.PicBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicBox2.TabIndex = 4;
            this.PicBox2.TabStop = false;
            this.PicBox2.Click += new System.EventHandler(this.PicBox2_Click);
            // 
            // PicBox3
            // 
            this.PicBox3.BackColor = System.Drawing.SystemColors.Window;
            this.PicBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PicBox3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PicBox3.ErrorImage = null;
            this.PicBox3.InitialImage = null;
            this.PicBox3.Location = new System.Drawing.Point(827, 198);
            this.PicBox3.Name = "PicBox3";
            this.PicBox3.Size = new System.Drawing.Size(149, 87);
            this.PicBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicBox3.TabIndex = 5;
            this.PicBox3.TabStop = false;
            this.PicBox3.Click += new System.EventHandler(this.PicBox3_Click);
            // 
            // PicBox4
            // 
            this.PicBox4.BackColor = System.Drawing.SystemColors.Window;
            this.PicBox4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PicBox4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PicBox4.ErrorImage = null;
            this.PicBox4.InitialImage = null;
            this.PicBox4.Location = new System.Drawing.Point(827, 291);
            this.PicBox4.Name = "PicBox4";
            this.PicBox4.Size = new System.Drawing.Size(149, 87);
            this.PicBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicBox4.TabIndex = 6;
            this.PicBox4.TabStop = false;
            this.PicBox4.Click += new System.EventHandler(this.PicBox4_Click);
            // 
            // PicBox5
            // 
            this.PicBox5.BackColor = System.Drawing.SystemColors.Window;
            this.PicBox5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PicBox5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PicBox5.ErrorImage = null;
            this.PicBox5.InitialImage = null;
            this.PicBox5.Location = new System.Drawing.Point(827, 384);
            this.PicBox5.Name = "PicBox5";
            this.PicBox5.Size = new System.Drawing.Size(149, 87);
            this.PicBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicBox5.TabIndex = 7;
            this.PicBox5.TabStop = false;
            this.PicBox5.Click += new System.EventHandler(this.PicBox5_Click);
            // 
            // MainPicBox
            // 
            this.MainPicBox.BackColor = System.Drawing.SystemColors.Window;
            this.MainPicBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MainPicBox.ErrorImage = null;
            this.MainPicBox.InitialImage = null;
            this.MainPicBox.Location = new System.Drawing.Point(12, 12);
            this.MainPicBox.Name = "MainPicBox";
            this.MainPicBox.Size = new System.Drawing.Size(809, 459);
            this.MainPicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.MainPicBox.TabIndex = 8;
            this.MainPicBox.TabStop = false;
            this.Tip.SetToolTip(this.MainPicBox, "双击设置为桌面壁纸");
            this.MainPicBox.DoubleClick += new System.EventHandler(this.MainPicBox_DoubleClick);
            // 
            // PicInfo
            // 
            this.PicInfo.AutoSize = true;
            this.PicInfo.Font = new System.Drawing.Font("微软雅黑", 14.25F);
            this.PicInfo.Location = new System.Drawing.Point(12, 474);
            this.PicInfo.Name = "PicInfo";
            this.PicInfo.Size = new System.Drawing.Size(0, 25);
            this.PicInfo.TabIndex = 9;
            // 
            // Tip
            // 
            this.Tip.AutoPopDelay = 5000;
            this.Tip.InitialDelay = 150;
            this.Tip.ReshowDelay = 150;
            // 
            // NextPic
            // 
            this.NextPic.Location = new System.Drawing.Point(924, 479);
            this.NextPic.Name = "NextPic";
            this.NextPic.Size = new System.Drawing.Size(52, 23);
            this.NextPic.TabIndex = 10;
            this.NextPic.Text = "下一张";
            this.NextPic.UseVisualStyleBackColor = true;
            this.NextPic.Click += new System.EventHandler(this.NextPic_Click);
            // 
            // LastPic
            // 
            this.LastPic.Location = new System.Drawing.Point(866, 479);
            this.LastPic.Name = "LastPic";
            this.LastPic.Size = new System.Drawing.Size(52, 23);
            this.LastPic.TabIndex = 11;
            this.LastPic.Text = "上一张";
            this.LastPic.UseVisualStyleBackColor = true;
            this.LastPic.Click += new System.EventHandler(this.LastPic_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(988, 508);
            this.Controls.Add(this.LastPic);
            this.Controls.Add(this.NextPic);
            this.Controls.Add(this.PicInfo);
            this.Controls.Add(this.MainPicBox);
            this.Controls.Add(this.PicBox5);
            this.Controls.Add(this.PicBox4);
            this.Controls.Add(this.PicBox3);
            this.Controls.Add(this.PicBox2);
            this.Controls.Add(this.PicBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Daily Picture";
            this.Load += new System.EventHandler(this.Main_Load);
            this.Resize += new System.EventHandler(this.Main_Resize);
            this.TxtMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PicBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MainPicBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NotifyIcon Notify;
        private System.Windows.Forms.ContextMenuStrip TxtMenu;
        private System.Windows.Forms.ToolStripMenuItem show;
        private System.Windows.Forms.ToolStripMenuItem exit;
        private System.Windows.Forms.PictureBox PicBox1;
        private System.Windows.Forms.PictureBox PicBox2;
        private System.Windows.Forms.PictureBox PicBox3;
        private System.Windows.Forms.PictureBox PicBox4;
        private System.Windows.Forms.PictureBox PicBox5;
        private System.Windows.Forms.PictureBox MainPicBox;
        private System.Windows.Forms.Label PicInfo;
        private System.Windows.Forms.ToolTip Tip;
        private System.Windows.Forms.ToolStripMenuItem about;
        private System.Windows.Forms.Button NextPic;
        private System.Windows.Forms.Button LastPic;
    }
}

