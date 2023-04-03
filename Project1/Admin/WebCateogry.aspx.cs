using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;
using ClassLibrary2;

public partial class Admin_WebCateogry : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        if (IsFormValid())
        {
            try
            {
                //DbSQLServer db = new DbSQLServer(AppSetting.ConnectionString());
                SaveCategoryInfo("sp_InsertCategory");
                Response.Write("<script>alert('Record Saved Successfully')</script>");
                txtCategory.Text=string.Empty;
            }
            catch (Exception ex)
            {
                Response.Write(ex.Message);
            }
        }
    }
    private void SaveCategoryInfo(string storedProcName)
    {
        DbSQLServer db = new DbSQLServer(AppSetting.ConnectionString());
        db.SaveOrUpdateRecord(storedProcName, GetObject());
        Response.Write("<script>('Record Saved Successfully')</script>");
    }
    private object GetObject()
    {
        CategoryDetails cat = new CategoryDetails();
        cat.category = txtCategory.Text;
        cat.Action = "Insert";
        cat.CreatedBy = Session["user"].ToString();
        cat.CreatedDate = DateTime.Today.ToString("yyyyMMdd ");
        return cat;
    }
    private bool IsFormValid()
    {
        string cat = txtCategory.Text;
        //string action = txtAction.Text;
        //string createdby = Session["user"].ToString();
        //string createddate=txtcreateddate.Text;


        if (cat == "")
        {
            Response.Write("<script>alert('Please enter category');</script>");
            return false;
        }
        //else if (createdby == "")
        //{
        //    Response.Write("<script>alert('Createdby must be filled');</script>");
        //    return false;
        //}
        //else if (createddate == "")
        //{
        //    Response.Write("<script>alert('createddate must be filled');</script>");
        //    return false;
        //}
        return true;
    }
    public class CategoryDetails
    {
        public int id { get; set; }
        public string category { get; set; }
        public string Action { get; set; }
        public string CreatedBy { get; set; }
        public string CreatedDate { get; set; }
    }
}