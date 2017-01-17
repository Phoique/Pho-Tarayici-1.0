using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tarayıcı_1._0
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            webBrowser1.GoBack();
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            webBrowser1.GoForward();
        }

        private void bunifuImageButton3_Click(object sender, EventArgs e)
        {
            webBrowser1.Refresh();
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            if (ara.text == "")
            {
                MessageBox.Show("Lütfen URL kısmını boş bırakmayın.", "URL KISMI BOŞ");
            }
            else
            {
                string url= ara.text;
                webBrowser1.Navigate(url);
            }
            //switch (ara.text)
            //{
            //    case "google":
            //        {
            //            ara.text = "www.google.com.tr";
            //            webBrowser1.Navigate("www.google.com.tr");
            //            break;
            //        }
            //    case "facebook":
            //        {
            //            webBrowser1.Navigate("www.facebook.com.tr");
            //            break;
            //        }
            //    case "tht":
            //        {
            //            webBrowser1.Navigate("www.turkhackteam.org");
            //            break;
            //        }
            //    default:
            //        break;
            //}
        }

        private void bunifuImageButton4_Click(object sender, EventArgs e)
        {
            string url = "www.google.com.tr";
            webBrowser1.Navigate(url);
        }

        private void ara_OnTextChange(object sender, EventArgs e)
        {
            switch (ara.text)
            {
                case "google":
                    {
                        ara.text = "www.google.com.tr";
                        webBrowser1.Navigate("www.google.com.tr");
                        break;
                    }
                case "facebook":
                    {
                        ara.text = "www.facebook.com.tr";
                        webBrowser1.Navigate("www.facebook.com.tr");
                        break;
                    }
                case "yandex":
                    {
                        ara.text = "www.yandex.com.tr";
                        webBrowser1.Navigate("www.yandex.com.tr");
                        break;
                    }
                default:
                    break;
            }
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }
    }
}
