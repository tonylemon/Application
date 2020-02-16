using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;

namespace Application
{
    public class Global : System.Web.HttpApplication
    {
        protected void Application_Start(object sender, EventArgs e)
        {
            //将计数器变量初始化为0
            Application["count"] = 0;
            Application["PC"] = 0;
            Application["Android"] = 0;
            Application["Iphone"] = 0;
            Application["Ipad"] = 0;
        }
        void Session_Start(object sender, EventArgs e)
        {
            Application.Lock();       //对Application对象加锁，以防止因为多个用户同时访问页面造成并行同时将访问人数加1
            //实例05：网站访问计数器
            Application["count"] = (int)Application["count"] + 1;          //当用户访问网站时将计数器加1

            //训练九：分别统计PC端、Android端、iPhone端、以及iPad端访问的总次数
            var Names = new
            {
                Android = "Android",
                iPhone = "iPhone",
                iPad = "iPad"
            };

            string userAgent = Request.UserAgent.ToLower();
            if (userAgent.Contains(Names.Android.ToLower()))
            {
                Application["Android"] = (int)Application["Android"] + 1;
            }
            else if (userAgent.Contains(Names.iPhone.ToLower()))
            {
                Application["Iphone"] = (int)Application["Iphone"] + 1;
            }
            else if (userAgent.Contains(Names.iPad.ToLower()))
            {
                Application["iPad"] = (int)Application["ipad"] + 1;
            }
            else
            {
                Application["PC"] = (int)Application["PC"] + 1;
            }
            Application.UnLock();
        }
        void Session_End(object sender, EventArgs e)
        {
            // 在会话结束时运行的代码。
            // 注意！！！: 只有在 Web.config 文件中的 sessionstate 模式设置为
            // InProc 时，才会引发 Session_End 事件。如果会话模式设置为 StateServer
            // 或 SQLServer，则不会引发该事件。
            Application.Lock();
            Application["count"] = (int)Application["count"] - 1;              //如果用户退出了网站，再将计数器减1
            Application.UnLock();
        }
    }
}