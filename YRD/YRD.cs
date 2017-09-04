using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YRD
{
    public partial class YRD : Form
    {
        struct QUERY
        {
            public string month { get; set; }
            public string complete { get; set; }
            public bool open { get; set; }
            public bool chat { get; set; }
        }

        public bool start = false;

        public YRD()
        {
            InitializeComponent();
        }

        private void YRD_Load(object sender, EventArgs e)
        {
            CB_Complete.SelectedIndex = 0;
            CB_Month.SelectedText = "36";
            CB_OpenWhenFound.Checked = false;
            CB_WeChat.Checked = true;
        }

        private void BTN_Start_Click(object sender, EventArgs e)
        {
            QUERY q = new QUERY();
            q.chat = CB_WeChat.Checked;
            q.open = CB_OpenWhenFound.Checked;
            q.month = CB_Month.SelectedText;
            q.complete = CB_Complete.SelectedText;
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
                string res = Web.HttpGet("https://www.yirendai.com/loan/list/1", req_data);
                //Web.WeChat("13630053218",res);
                Console.WriteLine(res);
            }
        }

        private void BTN_Stop_Click(object sender, EventArgs e)
        {
            start = false;
        }

        
    }
}
