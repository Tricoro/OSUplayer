﻿namespace OSUplayer.Uilties
{
    partial class DelDulp
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button1 = new Telerik.WinControls.UI.RadButton();
            this.button2 = new Telerik.WinControls.UI.RadButton();
            this.button3 = new Telerik.WinControls.UI.RadButton();
            this.BackgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.BackgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.BackgroundWorker3 = new System.ComponentModel.BackgroundWorker();
            this.button4 = new Telerik.WinControls.UI.RadButton();
            this.button5 = new Telerik.WinControls.UI.RadButton();
            this.radStatusStrip1 = new Telerik.WinControls.UI.RadStatusStrip();
            this.progressBar1 = new Telerik.WinControls.UI.RadProgressBarElement();
            this.Label1 = new Telerik.WinControls.UI.RadLabelElement();
            ((System.ComponentModel.ISupportInitialize)(this.button1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.button2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.button3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.button4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.button5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radStatusStrip1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.listView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listView1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listView1.CheckBoxes = true;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(12, 12);
            this.listView1.Name = "listView1";
            this.listView1.ShowGroups = false;
            this.listView1.Size = new System.Drawing.Size(433, 313);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            this.listView1.SizeChanged += new System.EventHandler(this.listView1_SizeChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "";
            this.columnHeader1.Width = 400;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "md5";
            this.columnHeader2.Width = 0;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button1.Enabled = false;
            this.button1.Location = new System.Drawing.Point(451, 206);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 26);
            this.button1.TabIndex = 1;
            this.button1.Text = "删除选中";
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Location = new System.Drawing.Point(451, 267);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 27);
            this.button2.TabIndex = 2;
            this.button2.Text = "取消";
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.Location = new System.Drawing.Point(451, 39);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 31);
            this.button3.TabIndex = 3;
            this.button3.Text = "开始查找";
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // BackgroundWorker1
            // 
            this.BackgroundWorker1.WorkerReportsProgress = true;
            this.BackgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BackgroundWorker1DoWork);
            this.BackgroundWorker1.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.BackgroundWorker1ProgressChanged);
            this.BackgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.BackgroundWorker1RunWorkerCompleted);
            // 
            // BackgroundWorker2
            // 
            this.BackgroundWorker2.WorkerReportsProgress = true;
            this.BackgroundWorker2.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BackgroundWorker2DoWork);
            this.BackgroundWorker2.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.BackgroundWorker2ProgressChanged);
            this.BackgroundWorker2.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.BackgroundWorker2RunWorkerCompleted);
            // 
            // BackgroundWorker3
            // 
            this.BackgroundWorker3.WorkerReportsProgress = true;
            this.BackgroundWorker3.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BackgroundWorker3DoWork);
            this.BackgroundWorker3.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.BackgroundWorker3ProgressChanged);
            this.BackgroundWorker3.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.BackgroundWorker3RunWorkerCompleted);
            // 
            // button4
            // 
            this.button4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button4.Enabled = false;
            this.button4.Location = new System.Drawing.Point(451, 99);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 26);
            this.button4.TabIndex = 5;
            this.button4.Text = "自动选择";
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button5.Enabled = false;
            this.button5.Location = new System.Drawing.Point(451, 151);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 26);
            this.button5.TabIndex = 6;
            this.button5.Text = "清除选中";
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // radStatusStrip1
            // 
            this.radStatusStrip1.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.progressBar1,
            this.Label1});
            this.radStatusStrip1.Location = new System.Drawing.Point(0, 329);
            this.radStatusStrip1.Name = "radStatusStrip1";
            this.radStatusStrip1.Size = new System.Drawing.Size(538, 28);
            this.radStatusStrip1.TabIndex = 7;
            this.radStatusStrip1.Text = "radStatusStrip1";
            // 
            // progressBar1
            // 
            this.progressBar1.AutoSize = false;
            this.progressBar1.Bounds = new System.Drawing.Rectangle(0, 0, 300, 22);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.SeparatorColor1 = System.Drawing.Color.White;
            this.progressBar1.SeparatorColor2 = System.Drawing.Color.White;
            this.progressBar1.SeparatorColor3 = System.Drawing.Color.White;
            this.progressBar1.SeparatorColor4 = System.Drawing.Color.White;
            this.progressBar1.SeparatorGradientAngle = 0;
            this.progressBar1.SeparatorGradientPercentage1 = 0.4F;
            this.progressBar1.SeparatorGradientPercentage2 = 0.6F;
            this.progressBar1.SeparatorNumberOfColors = 2;
            this.radStatusStrip1.SetSpring(this.progressBar1, false);
            this.progressBar1.StepWidth = 14;
            this.progressBar1.SweepAngle = 90;
            this.progressBar1.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            // 
            // Label1
            // 
            this.Label1.Alignment = System.Drawing.ContentAlignment.TopLeft;
            this.Label1.Name = "Label1";
            this.radStatusStrip1.SetSpring(this.Label1, false);
            this.Label1.Text = "";
            this.Label1.TextWrap = true;
            this.Label1.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            // 
            // DelDulp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(538, 357);
            this.Controls.Add(this.radStatusStrip1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listView1);
            this.MinimumSize = new System.Drawing.Size(546, 387);
            this.Name = "DelDulp";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "DelDulp";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DelDulp_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.button1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.button2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.button3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.button4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.button5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radStatusStrip1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion
        private System.Windows.Forms.ListView listView1;
        private Telerik.WinControls.UI.RadButton button1;
        private Telerik.WinControls.UI.RadButton button2;
        private Telerik.WinControls.UI.RadButton button3;
        private System.ComponentModel.BackgroundWorker BackgroundWorker1;
        private System.ComponentModel.BackgroundWorker BackgroundWorker2;
        private System.ComponentModel.BackgroundWorker BackgroundWorker3;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private Telerik.WinControls.UI.RadButton button4;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private Telerik.WinControls.UI.RadButton button5;
        private Telerik.WinControls.UI.RadStatusStrip radStatusStrip1;
        private Telerik.WinControls.UI.RadProgressBarElement progressBar1;
        private Telerik.WinControls.UI.RadLabelElement Label1;
    }
}