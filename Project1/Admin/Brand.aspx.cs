using ClassLibrary2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Linq;
using ClassLibrary2;
using Microsoft.EntityFrameworkCore;


public partial class Admin_Brand : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
      if(!this.IsPostBack)
        {
            LoadDataIntoGridView();
        }
    }

    private void LoadDataIntoGridView()
    {
        LoadData(GridViewBrand, "sp_ShowBrandIGridView");
    }

    public void LoadData(GridView gv, string storedProcName)
    {
        DbSQLServer db=new DbSQLServer(AppSetting.ConnectionString());
        gv.DataSource = db.GetDataList(storedProcName);
        gv.DataBind();
    }

    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        if(IsFormValid())
        {
            try
            {
                //DbSQLServer db = new DbSQLServer(AppSetting.ConnectionString());
                SaveBrandInfo("sp_Insertbrand");
                Response.Write("<script>alert('Record Saved Successfully')</script>");
                LoadDataIntoGridView();
            }
            catch(Exception ex)
            {
                Response.Write(ex.Message);
            }
        }
    }

    private void SaveBrandInfo(string storedProcName)
    {
        DbSQLServer db = new DbSQLServer(AppSetting.ConnectionString());
        db.SaveOrUpdateRecord(storedProcName, GetObject());
        Response.Write("<script>('Record Saved Successfully')</script>");
    }

    private object GetObject()
    {
        BrandDetails Brand = new BrandDetails();
        Brand.brand = txtBrand.Text;
        Brand.Action = "Insert";
        Brand.CreatedBy = Session["user"].ToString();
        Brand.CreatedDate = DateTime.Today.ToString("yyyyMMdd ");
        return Brand;
    }

    private bool IsFormValid()
    {
        string brand = txtBrand.Text;
        //string action = txtAction.Text;
        //string createdby = Session["user"].ToString();
        //string createddate=txtcreateddate.Text;

      
        if (brand == "" )
        {
            Response.Write("<script>alert('Please enter brand');</script>");
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
    public class BrandDetails
    {
        public string brand { get; set; }
        public string Action { get; set; }
        public string CreatedBy { get; set; }
        public string CreatedDate { get; set; }
    }
}