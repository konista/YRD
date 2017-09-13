using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic;

namespace YRD
{
    class Web
    {
        public static string HttpGet(string Url, string postDataStr = "")
        {
            try
            {
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(Url + (postDataStr == "" ? "" : "?") + postDataStr);
                request.Method = "GET";
                request.ContentType = "text/html;charset=UTF-8";

                HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                Stream myResponseStream = response.GetResponseStream();
                StreamReader myStreamReader = new StreamReader(myResponseStream, Encoding.UTF8);
                string retString = myStreamReader.ReadToEnd();
                myStreamReader.Close();
                myResponseStream.Close();

                return retString;
            }
            catch
            {

            }
            return "";
        }
        public static string HttpPost(string Url, string postDataStr)
        {
            try
            {
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(Url);
                request.Method = "POST";
                request.ContentType = "application/x-www-form-urlencoded";
                request.ContentLength = postDataStr.Length;
                StreamWriter writer = new StreamWriter(request.GetRequestStream(), Encoding.ASCII);
                writer.Write(postDataStr);
                writer.Flush();
                HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                string encoding = response.ContentEncoding;
                if (encoding == null || encoding.Length < 1)
                {
                    encoding = "UTF-8"; //默认编码  
                }
                StreamReader reader = new StreamReader(response.GetResponseStream(), Encoding.GetEncoding(encoding));
                string retString = reader.ReadToEnd();
                return retString;
            }
            catch
            {

            }
            return "";
        }
        public static void Notice(List<string> lnum,List<YRD.RECORD> lr)
        {
            string msg = "";
            foreach (YRD.RECORD r in lr)
            {
                msg += "**********\n";
                msg += r.user_info + "\n";
                msg += r.detail_uri + "\n";
                msg += r.borrow_info + "\n";
                msg += r.lend_info + "\n";
                msg += r.rate_info + "\n";
                msg += r.month_info + "\n";
            }
            Console.WriteLine(msg);
            SendMail(lnum, msg);
        }

        public static void SendMail(List<string> lnum, string res)
        {
            string emailAcount = Interaction.InputBox("发件箱地址", "请输入发件箱地址", "konista@163.com", -1, -1);
            string emailPassword = Interaction.InputBox("发件箱密码", "请输入发件箱密码", "", -1, -1);
            
            var reciver = "konista@163.com";
            MailMessage message = new MailMessage();
            //设置发件人,发件人需要与设置的邮件发送服务器的邮箱一致
            MailAddress fromAddr = new MailAddress("konista@163.com");
            message.From = fromAddr;
            //设置收件人,可添加多个,添加方法与下面的一样
            message.To.Add(reciver);
            //设置抄送人
            foreach (string addr in lnum)
            {
                message.CC.Add(addr);
            }
            //设置邮件标题
            message.Subject = "YRD_Notice";
            //设置邮件内容
            message.Body = res;
            //设置邮件发送服务器,服务器根据你使用的邮箱而不同,可以到相应的 邮箱管理后台查看,下面是QQ的
            SmtpClient client = new SmtpClient("smtp.163.com", 25);
            //设置发送人的邮箱账号和密码
            client.Credentials = new NetworkCredential(emailAcount, emailPassword);
            //启用ssl,也就是安全发送
            client.EnableSsl = true;
            //发送邮件
            client.Send(message);
        }
    }
}
