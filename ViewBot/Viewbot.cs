using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
//using Excel = Microsoft.Office.Interop.Excel;
using Newtonsoft.Json.Linq;

namespace ViewBot
{
    public partial class Viewbot : Form
    {
        string commonSesskey = "";
        string commonLoginUserId = "";
        public string commonFirstSesskey = "";
        public string commonSecondSesskey = "";
        public string commonThirdSesskey = "";
        public string commonForthSesskey = "";
        public string commonUserAgent = "";

        public Viewbot(string cfk, string csk, string ctk, string crk, string cua)
        {
            InitializeComponent();
            EnableGroup();
            commonFirstSesskey = cfk;
            commonSecondSesskey = csk;
            commonThirdSesskey = ctk;
            commonForthSesskey = crk;
            commonUserAgent = cua;
        }

        Global Global = new Global();
        List<string> pandaUserList = new List<string>();
        List<string> pandaProxyList = new List<string>();
        List<string> successProxyList = new List<string>();
        List<string> pandaLoginUserList = new List<string>();

        public string socketServerUrl = "http://localhost:3000";

        //비밀번호 확인전
        private void DisableGroup()
        {
            GrpUser.Enabled = false;
            GrpProxy.Enabled = false;
            GrpLog.Enabled = false;
            GrpEnterRoom.Enabled = false;
            GrpLogin.Enabled = false;
        }
        //비밀번호 확인후
        private void EnableGroup()
        {
            GrpUser.Enabled = true;
            GrpProxy.Enabled = true;
            GrpLog.Enabled = true;
            GrpEnterRoom.Enabled = true;
            GrpLogin.Enabled = true;
        }

        //유저리스트 추가
        private void BtnAddUser_Click(object sender, EventArgs e)
        {

            try
            {
                OpenFileDialog openDialog = new OpenFileDialog();
                openDialog.ShowDialog();
                string filePath = openDialog.FileName;
                string extension = Path.GetExtension(filePath);
                if (extension != ".csv")
                {
                    MessageBox.Show("CSV파일을 입력하세요.");
                    return;
                }

                List<string> userList = new List<string>();
                pandaUserList = userList;

                StreamReader sr = new StreamReader(filePath, Encoding.GetEncoding("euc-kr"));
                while (!sr.EndOfStream)
                {
                    string s = sr.ReadLine();
                    string[] temp = s.Split(',');        // Split() 메서드를 이용하여 ',' 구분하여 잘라냄
                    userList.Add(temp[0]);
                    userList.Add(temp[1]);
                }

                displayUserList(userList);
            } catch (Exception ex)
            {

            }

            //Excel.Application xlApp = new Excel.Application();
            //Excel.Workbook xlWorkBook = xlApp.Workbooks.Open(filePath, 0, FileAccess.Read);
            //Excel.Worksheet xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);
            //try
            //{
            //    for (int i = 1; i <= xlWorkSheet.Rows.Count; i++)
            //    {
            //        if (xlWorkSheet.Cells[i, 1].value == null)
            //        {
            //            break;
            //        }
            //        else
            //        {
            //            userList.Add(xlWorkSheet.Cells[i, 1].value);
            //            userList.Add(xlWorkSheet.Cells[i, 2].value);
            //        }
            //    }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("유저파일 노딩시 오류가 발생하였습니다.");
            //}
            //xlWorkBook.Close();
            //xlApp.Quit();
            //System.Runtime.InteropServices.Marshal.ReleaseComObject(xlWorkSheet);
            //System.Runtime.InteropServices.Marshal.ReleaseComObject(xlWorkBook);
            //System.Runtime.InteropServices.Marshal.ReleaseComObject(xlApp);
        }

        private void displayUserList(List<string> userList)
        {
            this.GridUser.Rows.Clear();
            int count = 1;
            for(int i = 0; i < userList.Count - 1; i = i + 2 )
            {
                this.GridUser.Rows.Add(count, userList[i], userList[i + 1]);
                count ++;
            }
        }

        private void BtnAddProxy_Click(object sender, EventArgs e)
        {
            OpenFileDialog openDialog = new OpenFileDialog();
            openDialog.ShowDialog();
            string filePath = openDialog.FileName;
            string extension = Path.GetExtension(filePath);
            if (extension != ".txt")
            {
                MessageBox.Show("Txt파일을 입력하세요.");
                return;
            }

            string line = "";
            List<string> proxyList = new List<string>();
            pandaProxyList = proxyList;
            if (File.Exists(filePath))
            {
                using (StreamReader sr = new StreamReader(filePath))
                {
                    while ((line = sr.ReadLine()) != null)
                    {
                        proxyList.Add(line);
                    }
                }
            }
            displayProxyList(proxyList);
        }

        private bool uploadProxyData(string data)
        {
            try
            {
                HttpClientHandler cookiehandler = new HttpClientHandler();
                HttpClient cookiehttpClient = new HttpClient(cookiehandler);
                List<KeyValuePair<string, string>> cookieinputs = new List<KeyValuePair<string, string>>();
                cookieinputs.Add(new KeyValuePair<string, string>("data", data));

                HttpResponseMessage cookieresponseMessageMain = cookiehttpClient.PostAsync(socketServerUrl + "/uploadProxy", (HttpContent)new FormUrlEncodedContent((IEnumerable<KeyValuePair<string, string>>)cookieinputs)).Result;

                cookieresponseMessageMain.EnsureSuccessStatusCode();
                string cookieresponseMessageLoginString = cookieresponseMessageMain.Content.ReadAsStringAsync().Result;
                if (cookieresponseMessageLoginString.Contains("true"))
                {
                    //success upload
                }
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("프록시리스트 업로드가 실패하엿습니다.");
            }
            return false;
        }
        private void displayProxyList(List<string> proxyList)
        {
            try
            {
                this.GridProxy.Rows.Clear();
                int count = 1;
                for (int i = 0; i < proxyList.Count; i = i + 1)
                {
                    this.GridProxy.Rows.Add(count, proxyList[i].Split(':')[0], proxyList[i].Split(':')[1]);
                    count++;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("프록시 파일형식이 올바르지 않습니다.");
            }
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            int sNum = 0;
            int eNum = 0;
            try
            {
                sNum = Convert.ToInt32(this.TxtUserStart.Text.Trim());
                eNum = Convert.ToInt32(this.TxtEndUser.Text.Trim());
            }
            catch(Exception ex)
            {
                MessageBox.Show("유저 시작번호와 마감번호를 바로 입력하세요.");
                return;
            }
            if(eNum < sNum || eNum > pandaUserList.Count / 2)
            {
                MessageBox.Show("유저 시작번호와 마감번호를 바로 입력하세요.");
                return;
            }

            if (pandaProxyList.Count() == 0)
            {
                MessageBox.Show("프록시리스트를 추가하세요.");
                return;
            }

            if (pandaProxyList.Count() < eNum - 1)
            {
                MessageBox.Show("프록시리스트를 더 추가하세요.");
                return;
            }

            //List<string> cookieList = getCookieList();
            //if (cookieList.Count != 6)
            //{
            //    MessageBox.Show("서버로부터 쿠키 로딩시 오류가 발생하엇습니다.");
            //    return;
            //}

            // 보트 1/0 구현부분
            //if (cookieList[4] != "enable")
            //{
            //    MessageBox.Show("사이트에서 에러가 발생하였습니다.");
            //    return;
            //}


            string proxyStr = "";
            for (int i = sNum - 1; i < eNum; i ++)
            {
                if (i > sNum - 1)
                {
                    proxyStr += "\n";
                }
                proxyStr += pandaProxyList[i];
            }

            //if (!uploadProxyData(proxyStr))
            //{
            //    return;
            //}

            successProxyList.Clear();


            for (int i = sNum - 1; i < eNum; i ++ )
            {
                List<string> sesskeyAndId = new List<string>();
                string proxyInfo = pandaProxyList.Count() > i ? pandaProxyList[i] : "";

                //prod
                sesskeyAndId = pandaLogin(pandaUserList[2 * i], pandaUserList[2 * i + 1], proxyInfo);
                if (sesskeyAndId.Count == 2)
                {
                    pandaLoginUserList.Add(pandaUserList[2 * i]);
                    pandaLoginUserList.Add(sesskeyAndId[0]); //Sesskey
                    int bjNumber = this.GridLoginUser.Rows.Count;
                    this.GridLoginUser.Rows.Add(bjNumber, pandaUserList[2 * i], sesskeyAndId[0]);
                }

                //dev
                //pandaLoginUserList.Add(pandaUserList[2 * i]);
                //pandaLoginUserList.Add("sessKey"); //Sesskey
                //int bjNumber = this.GridLoginUser.Rows.Count;
                //this.GridLoginUser.Rows.Add(bjNumber, pandaUserList[2 * i], "sessKey");
                //successProxyList.Add(proxyInfo);
            }
        }

        public List<string> getCookieList()
        {
            HttpClientHandler cookiehandler = new HttpClientHandler();
            string cookieresponseMessageLoginString = "";
            List<string> cookieList = new List<string>();

            try
            {
                HttpClient cookiehttpClient = new HttpClient(cookiehandler);
                List<KeyValuePair<string, string>> cookieinputs = new List<KeyValuePair<string, string>>();
                cookieinputs.Add(new KeyValuePair<string, string>("id", "2"));
                HttpResponseMessage cookieresponseMessageMain = cookiehttpClient.PostAsync(Global.API_GetCookie, (HttpContent)new FormUrlEncodedContent((IEnumerable<KeyValuePair<string, string>>)cookieinputs)).Result;
                cookieresponseMessageMain.EnsureSuccessStatusCode();
                cookieresponseMessageLoginString = cookieresponseMessageMain.Content.ReadAsStringAsync().Result;
            }
            catch (Exception ex)
            {
                MessageBox.Show("서버로부터 쿠키 로딩시 오류가 발생하엇습니다.");
                return cookieList;
            }

            JObject data = Newtonsoft.Json.Linq.JObject.Parse(cookieresponseMessageLoginString);

            //서버로부터 얻은 쿠키리스트
            cookieList.Add((string)data.GetValue("first_value"));
            cookieList.Add((string)data.GetValue("second_value"));
            cookieList.Add((string)data.GetValue("third_value"));
            cookieList.Add((string)data.GetValue("forth_value"));
            cookieList.Add((string)data.GetValue("status_value"));
            cookieList.Add((string)data.GetValue("header_value"));

            commonUserAgent = (string)data.GetValue("header_value");
            socketServerUrl = (string)data.GetValue("socket_server");

            return cookieList;
        }

        public List<string> pandaLogin(string id, string pass, string proxy)
        {
            string proxyIp = proxy != "" ? proxy.Split(':')[0] : "";
            string proxyPort = proxy != "" ? proxy.Split(':')[1] : "";

            List<string> result = new List<string>();
            string cookieresponseMessageLoginString = "";
            HttpClientHandler cookiehandler = new HttpClientHandler();
            if (proxyIp != "" && proxyPort != "")
            {
                try
                {
                    cookiehandler.Proxy = new WebProxy(proxyIp, Convert.ToInt32(proxyPort));
                }
                catch (Exception ex)
                {
                    MessageBox.Show("프록시 정보를 올바로 입력하세요.");
                    return result;
                }
            }
            

            System.Threading.Thread.Sleep(100);

            CookieContainer container = new CookieContainer();
            ServicePointManager.Expect100Continue = false;
            ServicePointManager.SecurityProtocol |= SecurityProtocolType.Tls11 | SecurityProtocolType.Tls12;
            ServicePointManager.DefaultConnectionLimit = 2;
            ServicePointManager.ServerCertificateValidationCallback = delegate { return true; };
            //HttpClientHandler handler = new HttpClientHandler();

            cookiehandler.CookieContainer = container;
            HttpClient httpClient = new HttpClient(cookiehandler);

            //팬더TV에 요청보내서 쿠키 얻어오는 부분
            var beforeLoginSesskey = "";
            try
            {
                HttpResponseMessage responseMessageMain = httpClient.GetAsync("https://www.pandalive.co.kr/").Result;
                var loginSesskey = Convert.ToString(responseMessageMain.EnsureSuccessStatusCode().Headers);
                string[] words = loginSesskey.Split(' ');
                for (var i = 0; i < words.Length; i++)
                {
                    if (words[i].Contains("sessKey"))
                    {
                        var start = words[i].IndexOf("=") + 1;
                        var end = words[i].IndexOf(";");
                        var length = end - start;
                        beforeLoginSesskey = words[i].Substring(start, length);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("팬더TV 쿠키 로딩중 오류가 발생하엇습니다.");
                return result;
            }

            httpClient.DefaultRequestHeaders.Add("Accept", "application/json, text/javascript, */*; q=0.01");
            httpClient.DefaultRequestHeaders.Add("Accept-Encoding", "gzip,deflate,br");
            httpClient.DefaultRequestHeaders.Add("User-Agent", commonUserAgent);
            httpClient.DefaultRequestHeaders.Add("Accept-Language", "en-US,en;q=0.9");
            httpClient.DefaultRequestHeaders.Add("Connection", "keep-alive");
            httpClient.DefaultRequestHeaders.Host = "api.pandalive.co.kr";

            DateTime origin = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc);
            TimeSpan diff = DateTime.Now.ToUniversalTime() - origin;
            string Date = Convert.ToString(Math.Floor(diff.TotalSeconds));

            List<KeyValuePair<string, string>> inputs = new List<KeyValuePair<string, string>>();
            inputs.Add(new KeyValuePair<string, string>("29X__Q4yowex4Bzo", id));
            inputs.Add(new KeyValuePair<string, string>("2wqZ_Q4yowex4Bzo", pass));
            inputs.Add(new KeyValuePair<string, string>("AYUcv2W9f-yi4dNLpZWlOU", "off"));
            inputs.Add(new KeyValuePair<string, string>("o36w9w_N3d85AZ_Q4yowex4Bzo", ""));
            inputs.Add(new KeyValuePair<string, string>("_i3nY6v7ot9WIAugPuZ6Pj3WlOU", commonFirstSesskey));
            inputs.Add(new KeyValuePair<string, string>("Yt40SkS4eFP1sNLe4Dna", Date));
            inputs.Add(new KeyValuePair<string, string>("AYohuyc98ugPuZ6Pj3WlOU", commonSecondSesskey));
            inputs.Add(new KeyValuePair<string, string>("yQv1sB81otLfILAZU_XYXoaA", beforeLoginSesskey));  // cookie
            inputs.Add(new KeyValuePair<string, string>("o3GVexFtLZADj4Idn1w0S34Bzo", commonThirdSesskey));
            inputs.Add(new KeyValuePair<string, string>("YtK1kkS4aBf-Yxfc4Dna", "webPc"));
            inputs.Add(new KeyValuePair<string, string>("y6RycBO1oZLfADX_9tKZXoaA", "1.0.0"));

            try
            {
                HttpResponseMessage responseMessageLogin = httpClient.PostAsync(Global.PANDA_Login, (HttpContent)new FormUrlEncodedContent((IEnumerable<KeyValuePair<string, string>>)inputs)).Result;
                responseMessageLogin.EnsureSuccessStatusCode();
                string responseMessageLoginString = responseMessageLogin.Content.ReadAsStringAsync().Result;
                var sesskeyStart = responseMessageLoginString.IndexOf("sessKey");
                var loginstring = responseMessageLoginString.Substring(sesskeyStart);
                string[] loginwords = loginstring.Split('"');
                string SessKeys = loginwords[2];

                successProxyList.Add(proxy);

                if (responseMessageLoginString.Contains("true"))
                {
                    writeLogText(id + "님이 팬더TV 로그인에 성공하었습니다.");
                }
                else
                {
                    writeLogText(id + "님이 팬더TV 로그인에 실패하었습니다.");
                    return result;
                }
                //세션키 추가 
                result.Add(SessKeys);
                string responseMessageLoginHeader = responseMessageLogin.Headers.GetValues("Set-Cookie").FirstOrDefault();
                string process = responseMessageLoginHeader.Split(';')[0];
                string userIdLoginIdx = process.Substring(process.IndexOf("=") + 1, process.Length - process.IndexOf("=") - 1);
                //유저 아이디 추가
                result.Add(userIdLoginIdx);
                System.Threading.Thread.Sleep(500);
                return result;
            }
            catch (Exception ex)
            {
                writeLogText("팬더TV 로그인 요청시 오류가 발생하었습니다.");
                return result;
            }
        }

        delegate void SetTextCallback(string text);
        private void writeLogText(string message)
        {
            try
            {
                if (this.TxtLog.InvokeRequired)
                {
                    SetTextCallback d = new SetTextCallback(writeLogText);
                    this.Invoke(d, new object[] { message });
                }
                else
                {
                    this.TxtLog.Text = message + "\r\n" + this.TxtLog.Text;
                    this.TxtLog.Update();
                }
            }
            catch (Exception ex)
            {

            }
        }

        private void BtnEnterRoom_Click(object sender, EventArgs e)
        {
            int sNum = 0;
            int eNum = 0;
            string roomId = this.TxtRoomId.Text;
            try
            {
                sNum = Convert.ToInt32(this.TxtUserRoomStart.Text.Trim());
                eNum = Convert.ToInt32(this.TxtUserRoomEnd.Text.Trim());
            }
            catch (Exception ex)
            {
                MessageBox.Show("유저 시작번호와 마감번호를 바로 입력하세요.");
                return;
            }
            if (eNum < sNum || eNum > pandaLoginUserList.Count / 2)
            {
                MessageBox.Show("유저 시작번호와 마감번호를 바로 입력하세요.");
                return;
            }

            List<string> data = new List<string>();
            List<string> proxyList = new List<string>();
            
            for (int i = sNum - 1; i < eNum; i++)
            {
                data.Add(pandaLoginUserList[2 * i]);
                data.Add(pandaLoginUserList[2 * i + 1]); //Sesskey
                proxyList.Add(successProxyList[i]);
            }

            Thread chattingThread = new Thread(new ThreadStart(() => viewChat(data, roomId, proxyList)));
            chattingThread.Start();
            Thread.Sleep(500);
        }

        private void viewChat(List<string> userList, string roomId, List<string> proxyList)
        {
            Chat chat = new Chat();
            chat.userList = userList;
            chat.proxyList = proxyList;
            chat.roomId = roomId;
            chat.commonUserAgent = commonUserAgent;
            chat.socketServerUrl = socketServerUrl;
            chat.displayUserList();
            chat.ShowDialog();
        }
    }
}
