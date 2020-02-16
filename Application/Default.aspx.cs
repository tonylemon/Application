using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Application
{
    public partial class Default : System.Web.UI.Page
    {
        protected static bool IsData = false;
        protected void Page_Load(object sender, EventArgs e)
        {
            Label1.Text = "您是该网站的第" + Application["count"].ToString() + "个访问者";
            PC.Text = Application["PC"].ToString();
            Android.Text = Application["Android"].ToString();
            Iphone.Text = Application["Iphone"].ToString();
            Ipad.Text = Application["Ipad"].ToString();
        }
        public void SetApplication(string TarinNo, int FirstClass, int BusinessClass, int EconomyClass)
        {
            Application[TarinNo] = new OrderInfo { FirstClass = FirstClass, BusinessClass = BusinessClass, EconomyClass = EconomyClass };
        }
    }
   
}
public class CreateTarinNoInfo
{
    public static IList<TarinNoInfo> Get()
    {
        IList<TarinNoInfo> TarinNoInfos = new List<TarinNoInfo>();
        TarinNoInfos.Add(new TarinNoInfo() { TarinNo = "D102", FirstStation = "长春西", LastStation = "北京", FirstTime = "12:03", LastTime = "18:31", ToLast = "06:28", FirstClass = 20, BusinessClass = 32, EconomyClass = 5 });
        TarinNoInfos.Add(new TarinNoInfo() { TarinNo = "Z158", FirstStation = "长春", LastStation = "北京", FirstTime = "12:48", LastTime = "21:08", ToLast = "08:20", FirstClass = 15, BusinessClass = 50, EconomyClass = 6 });
        TarinNoInfos.Add(new TarinNoInfo() { TarinNo = "D30", FirstStation = "长春西", LastStation = "北京", FirstTime = "16:00", LastTime = "22:22", ToLast = "06:22", FirstClass = 30, BusinessClass = 43, EconomyClass = 3 });
        TarinNoInfos.Add(new TarinNoInfo() { TarinNo = "D22", FirstStation = "长春", LastStation = "北京", FirstTime = "16:01", LastTime = "22:30", ToLast = "06:29", FirstClass = 18, BusinessClass = 25, EconomyClass = 2 });
        TarinNoInfos.Add(new TarinNoInfo() { TarinNo = "G384", FirstStation = "长春", LastStation = "北京南", FirstTime = "16:44", LastTime = "22:56", ToLast = "06:12", FirstClass = 25, BusinessClass = 29, EconomyClass = 17 });
        TarinNoInfos.Add(new TarinNoInfo() { TarinNo = "G382", FirstStation = "长春西", LastStation = "北京南", FirstTime = "17:21", LastTime = "23:30", ToLast = "06:09", FirstClass = 27, BusinessClass = 60, EconomyClass = 28 });
        TarinNoInfos.Add(new TarinNoInfo() { TarinNo = "K340", FirstStation = "长春", LastStation = "北京", FirstTime = "20:38", LastTime = "09:58", ToLast = "13:20", FirstClass = 14, BusinessClass = 80, EconomyClass = 26 });
        TarinNoInfos.Add(new TarinNoInfo() { TarinNo = "K266", FirstStation = "长春", LastStation = "北京", FirstTime = "21:42", LastTime = "12:53", ToLast = "15:11", FirstClass = 19, BusinessClass = 12, EconomyClass = 1 });
        TarinNoInfos.Add(new TarinNoInfo() { TarinNo = "Z62", FirstStation = "长春", LastStation = "北京", FirstTime = "21:58", LastTime = "06:08", ToLast = "08:10", FirstClass = 21, BusinessClass = 23, EconomyClass = 3 });
        TarinNoInfos.Add(new TarinNoInfo() { TarinNo = "Z64", FirstStation = "长春", LastStation = "北京", FirstTime = "22:33", LastTime = "07:54", ToLast = "09:21", FirstClass = 24, BusinessClass = 62, EconomyClass = 16 });
        TarinNoInfos.Add(new TarinNoInfo() { TarinNo = "Z118", FirstStation = "长春", LastStation = "北京", FirstTime = "23:41", LastTime = "08:36", ToLast = "08:55", FirstClass = 17, BusinessClass = 15, EconomyClass = 32 });
        return TarinNoInfos;
    }
}
public class TarinNoInfo
{
    public string TarinNo { get; set; }
    public string FirstStation { get; set; }
    public string LastStation { get; set; }
    public string FirstTime { get; set; }
    public string LastTime { get; set; }
    public string ToLast { get; set; }
    public int FirstClass { get; set; }
    public int BusinessClass { get; set; }
    public int EconomyClass { get; set; }
}