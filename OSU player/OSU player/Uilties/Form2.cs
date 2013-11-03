﻿using System.Collections.Generic;
using System;
using System.Windows.Forms;
using Telerik.WinControls.UI;
using Telerik.WinControls;

namespace OSU_player
{
    public partial class Form2 : RadForm
    {
        public Form2()
        {
            InitializeComponent();

        }
        public QQ qq = new QQ();
        List<QQInfo> tmp = new List<QQInfo>();
        private void Button2_Click(object sender, EventArgs e)
        {
            try
            {
                Core.uin = Convert.ToInt32(ListView1.SelectedItems[0].Text);
                this.Dispose();
            }
            catch (Exception)
            {
                if (ListView1.Items.Count != 0)
                {
                    RadMessageBox.Show("别卖萌不选啊-0-");
                }
                else
                {
                    Core.uin = 0;
                    Core.syncQQ = false;
                }
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            tmp = qq.GetQQList();
            ListView1.Clear();
            ListView1.Columns.Add("ID", 100);
            ListView1.Columns.Add("昵称", 100);
            try
            {

                foreach (QQInfo t in tmp)
                {
                    ListViewItem Tmp = new ListViewItem();
                    Tmp.Text = t.uin.ToString();
                    Tmp.SubItems.Add(t.nick);
                    ListView1.Items.Add(Tmp);
                }

            }
            catch (Exception)
            {
                RadMessageBox.Show("获取当前在线QQ出错！");
            }
        }
    }
}
