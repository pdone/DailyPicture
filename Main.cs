using System;
using System.Drawing;
using System.Windows.Forms;
using System.Runtime.InteropServices;  //调用WINDOWS API函数时要用到
using Newtonsoft.Json.Linq;
using System.Net;
using System.IO;
/*
 * Author: Pdone
 * Create Date: 2017-12-31
 * GitHub: https://github.com/pdone/DailyPicture
 * Weibo: https://weibo.com/pdone/
*/

namespace DailyPicture
{
    public partial class Main : Form
    {
        public string verInfo = "当前版本：1.2.1\n\r更新日期：2018.01.02\n\r开发人员：pdone\n\r图片来源：Bing 每日一图";
        public string bingUrl = "http://cn.bing.com/";
        public string setFileName = DateTime.Now.ToString("yyyyMMdd") + ".jpg";
        public static string savePath = Application.StartupPath + "\\images\\";
        JObject jo = new JObject();
        public Main()
        {
            InitializeComponent();
        }
        private void Main_Load(object sender, EventArgs e)
        {
            try
            {
                DateTime internetTime = getInternetTime();//获取网络时间
                DateTime localTime = DateTime.Now;
                TimeSpan sp = localTime.Subtract(internetTime);
                int days = (internetTime - localTime).Days;//对比本地时间差

                var apiUrl = getApiUrl(days, 5);//获取5天的图片地址
                var jsonStr = getRequest(apiUrl);
                jo = JObject.Parse(jsonStr);
                init(days, 5);//初始化
            }
            catch (WebException)
            {
                MessageBox.Show("网络异常");
            }
            catch (FileNotFoundException)
            {
                MessageBox.Show("系统本地时间异常");
            }
        }

        #region 通知栏图标
        private void notify_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                TxtMenu.Show();
            }
            if (e.Button == MouseButtons.Left)
            {
                if (Visible == false)
                {
                    ShowInTaskbar = true;
                    Show();
                    WindowState = FormWindowState.Normal;
                }
                else
                {
                    Hide();
                    Notify.ShowBalloonTip(5);
                }
            }
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Notify.Visible = false;
            Close();
            Application.Exit();
        }

        private void show_Click(object sender, EventArgs e)
        {
            Show();
            WindowState = FormWindowState.Normal;
        }

        private void Main_Resize(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                Visible = false;
                Hide();
                ShowInTaskbar = false;
                Notify.ShowBalloonTip(5);
            }
        }
        #endregion

        #region 预览图切换
        public void indexChange(int index, Image image)
        {
            Text = "Daily Picture " + "- 当前图片日期" + jo["images"][index]["enddate"].ToString();
            MainPicBox.Image = image;
            PicInfo.Text = jo["images"][index]["copyright"].ToString();
            setFileName = jo["images"][index]["enddate"].ToString() + ".jpg";
        }
        private void PicBox1_Click(object sender, EventArgs e)
        {
            indexChange(0, PicBox1.Image);
        }

        private void PicBox2_Click(object sender, EventArgs e)
        {
            indexChange(1, PicBox2.Image);
        }

        private void PicBox3_Click(object sender, EventArgs e)
        {
            indexChange(2, PicBox3.Image);
        }

        private void PicBox4_Click(object sender, EventArgs e)
        {
            indexChange(3, PicBox4.Image);
        }

        private void PicBox5_Click(object sender, EventArgs e)
        {
            indexChange(4, PicBox5.Image);
        }
        #endregion

        /// <summary>
        /// 获取接口地址
        /// day：0为今天，1为昨天，以此类推 
        /// count：要获取的天数
        /// </summary>
        /// <param name="day"></param>
        /// <param name="count"></param>
        public string getApiUrl(int day, int count)
        {
            return bingUrl + string.Format("HPImageArchive.aspx?format=js&idx={0}&n={1}", day, count);
        }

        /// <summary>
        /// 初始化窗体内容
        /// day：0为今天，1为昨天，以此类推 
        /// count：要获取的天数
        /// initType：1为正常初始化，2为下一张初始化，3为上一张初始化
        /// </summary>
        /// <param name="day"></param>
        /// <param name="count"></param>
        /// <param name="initType"></param>
        public void init(int day, int count, int initType = 1)
        {
            for (int i = 0; i < count; i++)
            {
                //缓存今天到五天前的图片
                SaveImageFromWeb(bingUrl + jo["images"][i]["url"].ToString(), jo["images"][i]["enddate"].ToString());
            }
            //PicBox1.Image = Image.FromFile(savePath + DateTime.Now.AddDays(0 - day).ToString("yyyyMMdd") + ".jpg");
            //PicBox2.Image = Image.FromFile(savePath + DateTime.Now.AddDays(-1 - day).ToString("yyyyMMdd") + ".jpg");
            //PicBox3.Image = Image.FromFile(savePath + DateTime.Now.AddDays(-2 - day).ToString("yyyyMMdd") + ".jpg");
            //PicBox4.Image = Image.FromFile(savePath + DateTime.Now.AddDays(-3 - day).ToString("yyyyMMdd") + ".jpg");
            //PicBox5.Image = Image.FromFile(savePath + DateTime.Now.AddDays(-4 - day).ToString("yyyyMMdd") + ".jpg");
            PicBox1.Image = Image.FromFile(savePath + jo["images"][0]["enddate"].ToString() + ".jpg");
            PicBox2.Image = Image.FromFile(savePath + jo["images"][1]["enddate"].ToString() + ".jpg");
            PicBox3.Image = Image.FromFile(savePath + jo["images"][2]["enddate"].ToString() + ".jpg");
            PicBox4.Image = Image.FromFile(savePath + jo["images"][3]["enddate"].ToString() + ".jpg");
            PicBox5.Image = Image.FromFile(savePath + jo["images"][4]["enddate"].ToString() + ".jpg");

            switch (initType)
            {
                case 1:
                    Text = "Daily Picture " + "- 当前图片日期" + jo["images"][0]["enddate"].ToString();
                    MainPicBox.Image = PicBox1.Image;
                    PicInfo.Text = jo["images"][0]["copyright"].ToString();
                    break;
                case 2:
                    MainPicBox.Image = PicBox5.Image;
                    PicInfo.Text = jo["images"][4]["copyright"].ToString();
                    break;
                case 3:
                    MainPicBox.Image = PicBox5.Image;
                    PicInfo.Text = jo["images"][4]["copyright"].ToString();
                    break;
            }
        }

        /// <summary>
        /// GET请求
        /// </summary>
        /// <param name="url"></param>
        /// <returns></returns>
        public string getRequest(string url)
        {
            WebRequest request = WebRequest.Create(url);
            WebResponse response = request.GetResponse();
            return new StreamReader(response.GetResponseStream()).ReadToEnd();
        }

        public DateTime getInternetTime()
        {
            string timeStamp = getRequest("http://www.hko.gov.hk/cgi-bin/gts/time5a.pr?a=1").Substring(2);
            long jsTimeStamp = long.Parse(timeStamp);
            DateTime startTime = TimeZone.CurrentTimeZone.ToLocalTime(new System.DateTime(1970, 1, 1)); // 当地时区
            DateTime dt = startTime.AddMilliseconds(jsTimeStamp);
            return dt;
        }

        /// <summary>
        /// 下载图片 imgUrl为图片网络地址  fileName为文件名
        /// </summary>
        /// <param name="imgUrl"></param>
        /// <param name="fileName"></param>
        /// <returns></returns>
        public static string SaveImageFromWeb(string imgUrl, string fileName)
        {
            if (File.Exists(savePath + fileName + ".jpg"))
            {
                return null;
            }
            string imgName = imgUrl.ToString().Substring(imgUrl.ToString().LastIndexOf("/") + 1);
            string defaultType = ".jpg";
            string[] imgTypes = new string[] { ".jpg", ".jpeg", ".png", ".gif", ".bmp" };
            string imgType = imgUrl.ToString().Substring(imgUrl.ToString().LastIndexOf("."));
            string imgPath = "";
            foreach (string it in imgTypes)
            {
                if (imgType.ToLower().Equals(it))
                    break;
                if (it.Equals(".bmp"))
                    imgType = defaultType;
            }

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(imgUrl);
            request.UserAgent = "Mozilla/6.0 (MSIE 6.0; Windows NT 5.1; Natas.Robot)";
            request.Timeout = 3000;

            WebResponse response = request.GetResponse();
            Stream stream = response.GetResponseStream();

            if (response.ContentType.ToLower().StartsWith("image/"))
            {
                byte[] arrayByte = new byte[1024];
                int imgLong = (int)response.ContentLength;
                int l = 0;

                if (fileName == "")
                    fileName = imgName;

                if (Directory.Exists(savePath) == false)
                {
                    Directory.CreateDirectory(savePath);
                }
                FileStream fso = new FileStream(savePath + fileName + imgType, FileMode.Create);
                while (l < imgLong)
                {
                    int i = stream.Read(arrayByte, 0, 1024);
                    fso.Write(arrayByte, 0, i);
                    l += i;
                }

                fso.Close();
                stream.Close();
                response.Close();
                imgPath = fileName + imgType;
                return imgPath;
            }
            else
            {
                return "";
            }
        }

        [DllImport("user32.dll", EntryPoint = "SystemParametersInfo")]
        private static extern int SystemParametersInfo(int uAction, int uParam, string lpvParam, int fuWinIni);

        private void MainPicBox_DoubleClick(object sender, EventArgs e)
        {
            //设置墙纸
            string strSavePath = Application.StartupPath + "\\images\\" + setFileName;
            SystemParametersInfo(20, 1, strSavePath, 0x1|0x2);
        }

        private void about_Click(object sender, EventArgs e)
        {
            MessageBox.Show(verInfo, "关于");
        }

        int temp = 1;
        private void NextPic_Click(object sender, EventArgs e)
        {
            if (temp < 8)
            {
                var apiUrl = getApiUrl(temp, 5);//获取5天的图片地址
                var jsonStr = getRequest(apiUrl);
                jo = JObject.Parse(jsonStr);
                init(temp, 5, 2);
                indexChange(4, PicBox5.Image);
                temp++;
            }
            else
            {
                MessageBox.Show("暂时只支持显示到当前日期前10天的图片");
            }
        }

        private void LastPic_Click(object sender, EventArgs e)
        {
            if (temp > 1)
            {
                temp = temp - 2;
                var apiUrl = getApiUrl(temp, 5);//获取5天的图片地址
                var jsonStr = getRequest(apiUrl);
                jo = JObject.Parse(jsonStr);
                init(temp, 5, 3);
                indexChange(4, PicBox5.Image);
                temp++;
            }
        }
    }
}
