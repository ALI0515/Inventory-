using System;
using System.Collections.Generic;
using System.EnterpriseServices;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Linq;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;
using ClassLibrary2;


public partial class Login : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        if (IsFormValid())
        {
            try
            {
                DbSQLServer db = new DbSQLServer(AppSetting.ConnectionString());

                
              
                bool isLoginDetailsCorrect = Convert.ToBoolean(db.GetsScalarValue("usp_CheckLoginDetails",GetParameters()));
                if(isLoginDetailsCorrect)
                {
                    if(CheckBox1.Checked)
                    {
                        HttpCookie co = new HttpCookie(txtUserName.Text,txtPassword.Text);
                        co.Expires= DateTime.Now.AddMonths(1);
                        Response.Cookies.Add(co);

                    }
                    Session["User"] = txtUserName.Text;
                    Response.Write("<script>alert('Login Successfully by new method');</script>");
                    txtUserName.Text = string.Empty; txtPassword.Text = string.Empty;
                    Response.Redirect("Admin/AdminHome.aspx");
                    
                }
                else
                {
                    Response.Write("<script>alert('Login Failed');</script>");
                    txtUserName.Text = string.Empty;
                    txtPassword.Text = string.Empty;
                    txtUserName.Focus();
                }
               
               

            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('Exception Occur Login Failed');</script>");
                Response.Write(ex.Message);
            }
            
        }
        else
        {
            Response.Write("<script>alert('Login Failed error')</script>");
        }
    }
    private bool IsFormValid()
    {
        string User = txtUserName.Text;
        string pass = txtPassword.Text;
        if (User == "" && pass == "")
        {
            Response.Write("<script>alert('Please enter username and password');</script>");
            return false;
        }
        else if (User == "")
        {
            Response.Write("<script>alert('UserName must be filled');</script>");
            return false;
        }
        else if (pass == "")
        {
            Response.Write("<script>alert('Password must be filled');</script>");
            return false;
        }
        else if (User.Length < 4)
        {
            Response.Write("<script>alert('UserName length must be 4');</script>");
            return false;
        }
        else if (pass.Length < 4 || pass.Length >= 18)
        {
            Response.Write("<script>alert('Password must be 4');</script>");
            return false;
        }
        return true;
    }

    private DbParameter[] GetParameters()
    {
        List<DbParameter> parameters = new List<DbParameter>();
        DbParameter dbparam1=new DbParameter();
        dbparam1.Parameter = "@UserName";
        dbparam1.Value=txtUserName.Text;
        parameters.Add(dbparam1);
        DbParameter dbparam2 = new DbParameter();
        dbparam2.Parameter = "@Password";
        dbparam2.Value = txtPassword.Text;
        parameters.Add(dbparam2);
        return parameters.ToArray();
    }

}
    
    