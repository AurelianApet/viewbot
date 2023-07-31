using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;
using Quobject.SocketIoClientDotNet.Client;

namespace ViewBot
{
    public partial class Chat : Form
    {
        public Chat()
        {
            InitializeComponent();
        }

        public List<string> userList = new List<string>();
        public List<string> proxyList = new List<string>();
        public string roomId = "";
        public string commonUserAgent = "";
        public string socketServerUrl = "http://localhost:3000";
        public List<Socket> socketList = new List<Socket>();

        Global Global = new Global();

        public void displayUserList()
        {
            int count = 1;
            for (int i = 0; i < userList.Count - 1; i = i + 2)
            {
                this.GridUser.Rows.Add(count, userList[i], userList[i + 1]);
                count++;
            }

            this.TxtUserStart.Text = roomId;
        }
        private void BtnEnterRoom_Click(object sender, EventArgs e)
        {
            int enterTime = 300;
            try
            {
                enterTime = Convert.ToInt32(this.TxtEnterTime.Text);
            }
            catch(Exception ex)
            {
                MessageBox.Show("입장시간을 바로 입력하세요.");
            }

            //enterRoom("sesskey", "id");
            for (int i = 0; i < userList.Count - 1; i = i + 2)
            {
                Thread enterRoomThread = new Thread(new ThreadStart(() => enterRoom(userList[i], userList[i + 1], i / 2)));
                enterRoomThread.Start();
                Thread.Sleep(enterTime);
            }
        }

        private void enterRoom(string id, string sesskey, int index)
        {
            string proxy = proxyList[index];
            Socket socket = IO.Socket(socketServerUrl);
            socket.Connect();
            socketList.Add(socket);

            socket.On(Socket.EVENT_CONNECT, () =>
            {
                var UserInfo = new JObject();
                UserInfo.Add("proxyUrl", proxy);
                socket.Emit("connect-online", UserInfo);
            });

            socket.On("connect-client", () =>
            {
                writeChattingText("-------소켓 콘넥(" + id + ")-------");
                var UserInfo = new JObject();
                socket.Emit("UserInfo", UserInfo);

                var init = new JObject();
                init.Add("ReturnParam", true);
                init.Add("deviceType", "webPc");
                init.Add("deviceVersion", "1.0.0");
                init.Add("sessKey", sesskey);
                init.Add("site", "pandatv");
                init.Add("userAgent", commonUserAgent);
                socket.Emit("Init", init);
                Thread.Sleep(500);
            });

            socket.On(Socket.EVENT_CONNECT_ERROR, (data) =>
            {
                writeChattingText("소켓연결에 실패하엿습니다.");
                writeChattingText(data.ToString());
            });

            socket.On("new_connection", (data) =>
            {

            });

            socket.On("Init", (data) =>
            {
                var login = new JObject();
                login.Add("id", id);
                login.Add("roomid", null);
                login.Add("roompw", null);
                login.Add("sessKey", sesskey);
                writeChattingText("-------인이트(" + id + ")------");
                socket.Emit("Login", login);
            });

            socket.On("UserInfo", (data) =>
            {

            });

            socket.On("Retry", (data) =>
            {
                Thread.Sleep(1000);
                try
                {
                    JObject dataObject = JObject.Parse(data.ToString());
                    socket.Emit(dataObject["type"].ToString(), dataObject["msg"]);
                }
                catch (Exception ex)
                {

                }
            });

            socket.On("Login", (data) =>
            {
                var watch = new JObject();
                watch.Add("roomid", roomId);
                watch.Add("action", "watch");
                socket.Emit("WatchInfo", watch);
            });

            socket.On("WatchInfo", (data) => {
                var enterRoom = new JObject();
                enterRoom.Add("roomid", roomId);
                enterRoom.Add("password", "");
                socket.Emit("EnterRoom", enterRoom);

                var memberlist = new JObject();
                memberlist.Add("roomid", roomId);
                memberlist.Add("onoff", true);
                memberlist.Add("get", false);
                socket.Emit("MemberList", memberlist);

                var missionInfo = new JObject();
                missionInfo.Add("roomid", roomId);
                socket.Emit("MissionInfo", missionInfo);

                var LiveRecom = new JObject();
                LiveRecom.Add("roomid", roomId);
                socket.Emit("LiveRecom", LiveRecom);
            });

            socket.On("EnterRoom", (data) =>
            {

            });
            socket.On("MemberList", (data) =>
            {

            });
            socket.On("MissionInfo", (data) =>
            {

            });

            socket.On("MemberJoin", (data) =>
            {
                try
                {
                    JObject dataObject = JObject.Parse(data.ToString());
                    string enterid = dataObject["userInfo"]["id"].ToString();
                    string nickname = dataObject["userInfo"]["nick"].ToString();
                    if (enterid == id)
                        writeChattingText("+++++" + id + " 입장+++++");
                }
                catch (Exception ex)
                {

                }
            });

            socket.On("ChatMessage", (data) =>
            {
                JObject dataObject = JObject.Parse(data.ToString());
                string enterid = dataObject["userInfo"]["id"].ToString();
                string message = dataObject["message"].ToString();
                string nickname = dataObject["userInfo"]["nick"].ToString();
                string type = dataObject["type"].ToString();
                if(socket == socketList[0])
                {
                    writeChattingText(enterid + ":\r\n" + message);
                    keywordResponse(message);
                }
            });
        }

        private void keywordResponse(string message)
        {
            if (this.GridKeyword.Rows.Count > 1)
            {
                for (int i = 0; i < this.GridKeyword.Rows.Count - 1; i++)
                {
                    try
                    {
                        string[] keyword = this.GridKeyword.Rows[i].Cells[1].Value.ToString().Split(',');
                        string chattingMecro = this.GridKeyword.Rows[i].Cells[2].Value.ToString();
                        int userStart = Convert.ToInt32(this.GridKeyword.Rows[i].Cells[3].Value);
                        int userEnd = Convert.ToInt32(this.GridKeyword.Rows[i].Cells[4].Value);
                        for (int j = 0; j < keyword.Length; j++)
                        {
                            if (message.Contains(keyword[j]))
                            {
                                for (int k = userStart - 1; k < userEnd - 1; k++)
                                {
                                    Thread.Sleep(1000);
                                    sendMessage(k, chattingMecro);
                                }
                            }
                        }
                    }
                    catch (Exception ex)
                    {

                    }
                }
            }   
        }

        delegate void SetTextCallback(string text);
        private void writeChattingText(string message)
        {
            try
            {
                if (this.TxtLog.InvokeRequired)
                {
                    SetTextCallback d = new SetTextCallback(writeChattingText);
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

        private void BtnExitRoom_Click(object sender, EventArgs e)
        {
            int exitTime = 300;
            try
            {
                exitTime = Convert.ToInt32(this.TxtEnterTime.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("방나가는 시간을 바로 입력하세요.");
            }

            for (int i = 0; i < socketList.Count; i ++)
            {
                socketList[i].Disconnect();
                Thread.Sleep(exitTime);
            }
        }

        private void BtnSendMessage_Click(object sender, EventArgs e)
        {
            int userNum = 0;
            try
            {
                userNum = Convert.ToInt32(this.TxtSendUserNum.Text);
            }
            catch(Exception ex)
            {
                MessageBox.Show("유저번호를 바로 입력하세요.");
                return;
            }

            if(userNum > userList.Count / 2)
            {
                MessageBox.Show("유저번호를 바로 입력하세요.");
                return;
            }

            string message = this.TxtMessage.Text;
            sendMessage(userNum, message);
        }

        public void sendMessage(int userNum, string message)
        {
            JObject Message = new JObject();
            Message.Add("roomid", roomId);
            Message.Add("message", message);
            socketList[userNum - 1].Emit("ChatMessage", Message);
        }

        private void BtnKeyAdd_Click(object sender, EventArgs e)
        {
            string keyword = this.TxtKeyword.Text;
            string response = this.TxtKeyResponse.Text;
            int start = 0;
            int end = 0;
            try
            {
                start = Convert.ToInt32(this.TxtKeyStart.Text);
                end = Convert.ToInt32(this.TxtKeyEnd.Text);
            }
            catch(Exception ex)
            {
                MessageBox.Show("유저시작번호와 마감번호를 바로 입력하세요.");
                return;
            }
            int count = this.GridKeyword.Rows.Count;
            this.GridKeyword.Rows.Add(count, keyword, response, start, end);
        }
    }
}
