using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace mizpa_Yam_Library.logIn
{
    public partial class logIn : System.Web.UI.Page
    {
        public string msg = "";
        protected void Page_Load(object sender, EventArgs e)
        {
            string fileName = "MyDB.mdf";
            string tableName = "myDBtable";

            msg = Session["status"].ToString();

            if (Request.Form["usubmit"] != null)
            {
                string userName = Request.Form["uname"];
                string userPass = Request.Form["upass"];
                string selectQ = "SELECT * FROM " + tableName + " WHERE UsrName = '" + userName + "' AND UsrPass = '" + userPass + "'";

                if (MyAdoHelper.IsExist2(fileName, selectQ))
                {
                    Session["status"] = userName;
                    Session["admin"] = false;
                    Response.Redirect("../Home/HomePage.aspx");
                }
                else
                {
                    if (IsAdminExists(userName, userPass))
                    {
                        Session["status"] = Request.Form["uname"].ToString();
                        Session["admin"] = true;
                        Response.Redirect("../Home/HomePage.aspx");
                    }
                    else
                    {
                        msg = "username or password are incorrect";
                    }
                }
            }
        }

        public static bool IsAdminExists(string user, string password)
        {
            bool flag = false;
            DataSet ds = new DataSet();
            ds.ReadXml(System.Web.HttpContext.Current.Server.MapPath("admins.xml"));
            foreach (DataRow r in ds.Tables[0].Rows)
            {
                if ((user == (r[0].ToString())) && (password == (r[1].ToString())))
                {
                    flag = true;
                }
            }
            return flag;
        }
    }
}