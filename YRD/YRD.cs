using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace YRD
{
    public partial class YRD : Form
    {
        public struct QUERY
        {
            public string month { get; set; }
            public string complete { get; set; }
            public bool open { get; set; }
            public bool chat { get; set; }
        }
        public struct RECORD
        {
            public string user_info { get; set; }
            public string detail_uri { get; set; }
            public string borrow_info { get; set; }
            public string lend_info { get; set; }
            public string rate_info { get; set; }
            public string month_info { get; set; }
        }

        public bool start = false;
        public int query_rate = 600;
        public int send_rate = 3600;
        public bool bwechat = true;
        public bool bdialog = false;
        public List<string> lnum = new List<string>();
        static public string website = "https://www.yirendai.com/";

        public YRD()
        {
            InitializeComponent();
        }

        private void YRD_Load(object sender, EventArgs e)
        {
            CB_Complete.SelectedIndex = 2;
            CB_Month.SelectedIndex = 3;
            CB_OpenWhenFound.Checked = false;
            CB_WeChat.Checked = true;
            CB_ShowDialog.Checked = false;
            TB_QueryRate.Text = "600";
            TB_SendRate.Text = "3600";
            linkLabel1.Links[0].LinkData = website;
        }

        private void BTN_Start_Click(object sender, EventArgs e)
        {
            if (TB_QueryRate.Text != "")
            {
                query_rate = int.Parse(TB_QueryRate.Text);
                if (query_rate == 0) { query_rate = 600; }
            }
            if (TB_SendRate.Text != "")
            {
                send_rate = int.Parse(TB_SendRate.Text);
                if (send_rate == 0) { send_rate = 3600; }
            }
            bwechat = CB_WeChat.Checked;
            bdialog = CB_ShowDialog.Checked;

            lnum.Clear();
            foreach (string num in LB_Number.Items)
            {
                lnum.Add(num);
            }
            
            QUERY q = new QUERY();
            q.chat = CB_WeChat.Checked;
            q.open = CB_OpenWhenFound.Checked;
            q.month = CB_Month.SelectedItem.ToString();
            //q.complete = System.Web.HttpUtility.UrlEncode(CB_Complete.SelectedItem.ToString(),Encoding.UTF8);
            q.complete = CB_Complete.SelectedItem.ToString();
            System.Threading.Thread t = new System.Threading.Thread(QueryData);
            t.Start(q);
        }

        private void QueryData(object obj)
        {
            start = true;
            QUERY q = (QUERY)obj;
            string req_data = "period=" + q.month + "&currRate=&amt=&progress=" + q.complete;
            while (start)
            {
                string res = Web.HttpGet(website + "loan/list/1", req_data);
                linkLabel1.Links[0].LinkData = website + "loan/list/1?" + req_data;
                List<RECORD> lr = new List<RECORD>();
                Parse(res, lr);
                if (lr.Count > 0)
                {
                    if (bdialog)
                    {
                        MessageBox.Show("Found!!!");
                    }
                    if (bwechat)
                    {
                        Web.Notice(lnum, lr);
                        System.Threading.Thread.Sleep(1000 * send_rate); //1hour/time
                    }
                    
                }
                System.Threading.Thread.Sleep(1000*query_rate); //10min/time
            }
        }

        static private void Parse(string res, List<RECORD> lr)
        {
            Regex r = new Regex("<li class=\"clearfix\" num=[\\s\\S]+?</li>", RegexOptions.Multiline);
            Regex user = new Regex("<a href=\"([\\s\\S]+?)\">([\\s\\S]+?)<span [\\s\\S]+?</span>", RegexOptions.Multiline);
            Regex lend = new Regex("l bidDetail[\\s\\S]+?<p class=\"cont\">([\\s\\S]+?)</p>", RegexOptions.Multiline);
            Regex borrow = new Regex("<ps class=\"xsnum\">([\\s\\S]+?)</ps>", RegexOptions.Multiline);
            Regex rate = new Regex("<span class=\"money\">([\\s\\S]+?)</span>", RegexOptions.Multiline);
            Regex month = new Regex("l bidInfor[\\s\\S]+?<h4><span>([\\s\\S]+?)</span>", RegexOptions.Multiline);
            foreach (Match item in r.Matches(res))
            {
                GroupCollection matches = item.Groups;
                for (int i = 0; i < matches.Count; i++)
                {
                    RECORD record = new RECORD();

                    string li = matches[i].Value.ToString();

                    Match user_match = user.Match(li);
                    record.user_info = user_match.Groups[2].Value.Trim();
                    record.detail_uri = website + user_match.Groups[1].Value;
                    

                    Match lend_match = lend.Match(li);
                    record.lend_info = lend_match.Groups[1].Value;

                    Match borrow_match = borrow.Match(li);
                    record.borrow_info = borrow_match.Groups[1].Value;

                    Match rate_match = rate.Match(li);
                    record.rate_info = rate_match.Groups[1].Value + "%";

                    Match month_match = month.Match(li);
                    record.month_info = month_match.Groups[1].Value + "月";

                    lr.Add(record);
                }
            }
        }

        private void BTN_Stop_Click(object sender, EventArgs e)
        {
            start = false;
        }

        private void TB_QueryRate_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != '\b' && !Char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void TB_SendRate_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != '\b' && !Char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
            System.Diagnostics.Process.Start(e.Link.LinkData.ToString());
        }

        private void BTN_AddReciver_Click(object sender, EventArgs e)
        {
            string str = Interaction.InputBox("邮箱地址", "请输入邮箱地址", "文本内容", -1, -1);
            LB_Number.Items.Add(str);
        }
    }
}
