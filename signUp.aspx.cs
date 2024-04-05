using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace mizpa_Yam_Library.signUp
{
    public partial class signUp : System.Web.UI.Page
    {
        public string UserName = "";
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["status"] == null)
            {
                Session["status"] = "guest";
                Session["admin"] = false;
            }

            if (Request.Form["usubmit"] != null)
            {
                string filename = "MyDB.mdf";
                string tableName = "MyDBtable";

                string userName = Request.Form["uname"];
                string upassword = Request.Form["upass"];

                string selectQuery;
                selectQuery = "SELECT * FROM MyDBtable WHERE UsrName='" + userName + "'"; //select all users with the chosen usrename from the database.
                if (MyAdoHelper.IsExist2(filename, selectQuery))
                {
                    UserName = "User aleary exist!!!";
                }
                else
                {
                    string sqlCommand = "INSERT INTO " + tableName + "(UsrName,UsrPass) VALUES ('" + userName + "','" + upassword + "')";
                    MyAdoHelper.DoQuery2(filename, sqlCommand);
                    Session["status"] = Request.Form["uname"].ToString();
                    Response.Redirect("../Home/HomePage.aspx");
                }
            }
        }
    }
}