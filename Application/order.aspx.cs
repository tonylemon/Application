using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Application
{
    public partial class order : System.Web.UI.Page
    {
        protected string TarinNo;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                TarinNo = Request.QueryString["TarinNo"];
                this.HiddenField1.Value = TarinNo;
            }
        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            string TarinNo = this.HiddenField1.Value;
            int seat = int.Parse(this.DropDownList1.Text);
            int num = int.Parse(this.DropDownList2.Text);
            OrderInfo orderInfo = (OrderInfo)Application[TarinNo];
            switch (seat)
            {
                case 100:
                    if (orderInfo.FirstClass < num)
                    {
                        ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "order", "alert(\"特等座目前排队数大于剩余票数，请重新选择\");window.location,href='Default.aspx';", true);
                        return;
                    }
                    else
                    {
                        orderInfo.FirstClass = orderInfo.FirstClass - num;
                    }
                    break;
                case 1:
                    if (orderInfo.BusinessClass < num)
                    {
                        ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "order", "alert(\"一等座目前排队数大于剩余票数，请重新选择\");window.location,href='Default.aspx';", true);
                        return;
                    }
                    else
                    {
                        orderInfo.BusinessClass = orderInfo.BusinessClass - num;
                    }
                    break;
                case 2:
                    if (orderInfo.EconomyClass < num)
                    {
                        ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "order", "alert(\"二等座目前排队数大于剩余票数，请重新选择\");window.location,href='Default.aspx';", true);
                        return;
                    }
                    else
                    {
                        orderInfo.EconomyClass = orderInfo.EconomyClass - num;
                    }
                    break;
            }
            Application[TarinNo] = orderInfo;
            Response.Redirect("success.aspx");
        }
    }
}