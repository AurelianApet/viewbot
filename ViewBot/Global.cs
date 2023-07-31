using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ViewBot
{
    public class Global
    {
        public string ServerIp = "";
        public string M_LoginSuccess = "비밀번호가 확인되였습니다.";
        public string M_LoginError = "비밀번호 확인이 실패하였습니다.";
        public string M_LoginFail = "비밀번호가 올바르지 않습니다.";


        //prod
        //public string API_Login = "http://46.149.195.23:5555/login";
        //public string API_GetCookie = "http://46.149.195.23:5555/getCookie";

        //dev
        public string API_Login = "http://localhost:5555/login";
        public string API_GetCookie = "http://localhost:5555/getCookie";

        public string PANDA_Login = "https://www.pandalive.co.kr/member/login";
    }
}
