using ClassLibrary2;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Configuration;

public partial class SignIn : System.Web.UI.Page
{
    int role = 15;
    string createdby = "admin";
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnsubmit_Click(object sender, EventArgs e)
    {
        if(IsFormValid())
        { 
            try
            {
                //simple insert code
                
                SaveBrandRecord("proc_AddUser");
                Response.Write("<script>('Record Saved Successfully')</script>");
                
            }
            catch(Exception ex)
            {
                Response.Write("<script>alert('error')</script>");
                Response.Write(ex.Message);
            }
        }
    }

    protected void txtUserName_TextChanged(object sender, EventArgs e)
    {
      

    }
    //private DbParameter[] GetParameters()
    //{
    //    List<DbParameter> parameters = new List<DbParameter>();
    //    DbParameter dbparam1 = new DbParameter();
    //    dbparam1.Parameter = "@UserName";
    //    dbparam1.Value = txtUserName.Text;
    //    parameters.Add(dbparam1);
    //    DbParameter dbparam2 = new DbParameter();
    //    dbparam2.Parameter = "@Password";
    //    dbparam2.Value = txtPassword.Text;
    //    parameters.Add(dbparam2);
    //    return parameters.ToArray();
    //}
    private bool IsFormValid()
    {
        string User = txtUserName.Text;
        string pass = txtPassword.Text;
        if (User == "" )
        {
            Response.Write("<script>alert('Please enter username ');</script>");
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

    public void SaveBrandRecord(string storedProcName)
    {
        DbSQLServer db = new DbSQLServer(AppSetting.ConnectionString());
        db.SaveOrUpdateRecord(storedProcName,GetObject());
        
     }
    public UserDetails GetObject()
    {
        UserDetails User=new UserDetails();
        User.UserName = txtUserName.Text;   
        User.Password = txtPassword.Text;
        User.RoleId = 15;
        User.CreatedBy = "Admin";
        return User;
    }
    
}

public class UserDetails
{
    public string UserName { get; set; }
    public string Password { get; set; }
    public int RoleId { get; set; }
    public string CreatedBy { get; set; }
}
