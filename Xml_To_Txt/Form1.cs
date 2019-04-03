using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Xml_To_Txt
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Control.CheckForIllegalCrossThreadCalls = false;
            string[] type = {"file_url", "jpeg_url", "preview_url", "sample_url"};
            cb_type.DataSource = type;
            string[] protocal = { "http", "https" };
            cb_protocal.DataSource = protocal;
            string[] level = { "all", "s", "e", "q" };
            cb_rating.DataSource = level;
            tb_path.Text = path;
        }

        string path = "E://konachan.txt";

        #region
        private void xml_to_text() {
            string type = cb_type.Text;
            string protocal = cb_protocal.Text;
            string rating = cb_rating.Text;
            int limit;
            int page;
            int total;
            int num = 0;
            try
            {
                limit = Convert.ToInt32(tb_limit.Text);
                page = Convert.ToInt32(tb_page.Text);
                total = Convert.ToInt32(tb_total.Text);
            }
            catch
            {
                limit = 10;
                page = 1;
                total = 100;
                tb_limit.Text = limit.ToString();
                tb_page.Text = page.ToString();
                tb_total.Text = total.ToString();
            }

            if (tb_path.Text != "")
            {
                path = tb_path.Text;
            }
            else
            {
                bt_path_Click(null, null);
            }

            FileStream fs = new FileStream(path, FileMode.Append);
            StreamWriter sw = new StreamWriter(fs);

            #region Xmldoc版本，非常慢（废）
            /*
            do
            {
                string xml_url = "http://konachan.com/post.xml?limit=" + limit.ToString() + "&page=" + page.ToString();
                lb_xml.Text = xml_url;
                XmlDocument xmlDoc = new XmlDocument();
                xmlDoc.Load(xml_url);
                XmlNode xn = xmlDoc.SelectSingleNode("posts");
                XmlNodeList xnl = xn.ChildNodes;
                foreach (XmlNode xn1 in xnl)
                {
                    XmlElement xe = (XmlElement)xn1;
                    string file_url = xe.GetAttribute(type).ToString();
                    lb_url.Text = file_url.Substring(79,6);
                    if (protocal == "http")
                    {
                        sw.Write("http" + file_url.Substring(5) + "\r\n");
                    }
                    else {
                        sw.Write(file_url + "\r\n");
                    }
                    num++;
                    lb_num.Text = num.ToString();
                }

                page++;
                //num += limit;
                //lb_num.Text = num.ToString();
            } while (num < total);
            */
            #endregion

            do
            {
                //string base_url = "http://konachan.com/post.xml?limit=";
                string base_url = "http://konachan.net/post.xml?limit=";
                string xml_url = base_url + limit.ToString() + "&page=" + page.ToString();
                lb_xml.Text = xml_url;
                XmlReader reader = null;
                
                try
                {
                    reader = XmlReader.Create(xml_url);
                    while (reader.Read())
                    {
                        if (reader.NodeType== XmlNodeType.Element)
                        {
                            if (reader.Name == "posts")
                                continue;
                            if (reader.HasAttributes)
                            {
                                string file_url = "";
                                string rating_value = "";
                                while (reader.MoveToNextAttribute())
                                {
                                    if (reader.Name == type)
                                    {
                                        file_url = reader.Value;
                                    }
                                    if (reader.Name == "rating")
                                    {
                                        rating_value = reader.Value;
                                    }
                                }
                                if (rating!="all"&&rating!=rating_value)
                                {
                                    continue;
                                }
                                lb_url.Text = file_url.Substring(79, 6);
                                if (protocal == "http")
                                {
                                    sw.Write("http" + file_url.Substring(5) + "\r\n");
                                }
                                else
                                {
                                    sw.Write(file_url + "\r\n");
                                }
                                num++;
                                lb_num.Text = num.ToString();
                            }
                        }
                    }
                }
                catch(Exception e)
                {
                    lb_xml.Text = "获取异常:"+xml_url;
                    //lb_xml.Text = e.ToString();
                    break;
                    //sw.Close();
                    //fs.Close();
                    //return e.ToString();
                }
                page++;
            } while (num < total);
            
            lb_url.Text = "OVER";
            sw.Close();
            fs.Close();
        }
        #endregion

        private void bt_start_Click(object sender, EventArgs e)
        {
            Thread t1 = new Thread(new ThreadStart(xml_to_text));
            t1.Start();
        }

        private void bt_path_Click(object sender, EventArgs e)
        {
            SaveFileDialog FileDialog = new SaveFileDialog();
            FileDialog.Filter = "文本文件|*.txt|所有文件|*.*";
            if (FileDialog.ShowDialog() == DialogResult.OK)
            {
                path = FileDialog.FileName;
                tb_path.Text = path;
            }
        }
    }
}
