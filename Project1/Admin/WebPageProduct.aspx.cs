using ClassLibrary2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Admin_WebPageProduct : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!this.IsPostBack)
        {
            BindDdlBrand();
        }
    }

    private void BindDdlBrand()
    {
        LoadDataIntoDropDownList(ddlBrand, "sp_searchBrands");
    }

    private void LoadDataIntoDropDownList(DropDownList ddl, string storedProcName)
    {
        DbSQLServer db = new DbSQLServer(AppSetting.ConnectionString());
        ddl.DataSource = db.GetDataList(storedProcName);
        ddl.DataTextField = "brand";
        ddl.DataValueField = "Id";
        ddl.DataBind();
        ddl.SelectedIndex = -1;
    }

    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        if (IsFormValid())
        {
            try
            {
                //DbSQLServer db = new DbSQLServer(AppSetting.ConnectionString());
                SaveProductInfo("sp_InsertProduct");
                Response.Write("<script>alert('Record Saved Successfully')</script>");
               
            }
            catch (Exception ex)
            {
                Response.Write(ex.Message);
            }
        }
    }
    private bool IsFormValid()
        {
            //string cat = txtCategory.Text;
            //string action = txtAction.Text;
            //string createdby = Session["user"].ToString();
            //string createddate=txtcreateddate.Text;


            if (txtProductID.Text == String.Empty)
            {
                Response.Write("<script>alert('Please enter ProductId');</script>");
                return false;
            }
            else if (txtBarcode.Text == String.Empty)
            {
                Response.Write("<script>alert('Barcode must be filled');</script>");
                return false;
            }
            else if (txtDescription.Text == String.Empty)
            {
                Response.Write("<script>alert('Description should be provided must be filled');</script>");
                return false;
            }
            else if (ddlBrand.Text == String.Empty)
            {
                Response.Write("<script>alert('Select Brand is necessary');</script>");
                return false;
            }
            else if (ddlCategory.Text == String.Empty)
            {
                Response.Write("<script>alert('Select category is necessary');</script>");
                return false;
            }
        else if (txtPrice.Text == String.Empty)
        {
            Response.Write("<script>alert('Price should be filled');</script>");
            return false;
        }
        else if (txtQty.Text == String.Empty)
        {
            Response.Write("<script>alert('Quantity should be filled');</script>");
            return false;
        }
        return true;
        }
    private void SaveProductInfo(string storedProcName)
    {
        DbSQLServer db = new DbSQLServer(AppSetting.ConnectionString());
        db.SaveOrUpdateRecord(storedProcName, GetObject());
        Response.Write("<script>('Record Saved Successfully')</script>");
    }

    private object GetObject()
    {
        ProductDetails pd = new ProductDetails();
        pd.pcode = txtProductID.Text;
        pd.barcode = txtBarcode.Text;
        pd.pdesc = txtDescription.Text;
        pd.brandid = ddlBrand.SelectedValue;
        pd.categoryid =ddlCategory.SelectedValue;
        pd.price=Convert.ToDecimal(txtPrice.Text);
        pd.qty=txtQty.Text;
        pd.reorder = 0;
        return pd;
    }

    public class ProductDetails  
    {
        public string pcode { get; set; }
        public string barcode { get; set; }
        public string pdesc { get; set; }
        public string brandid { get; set; }
        public string categoryid { get; set; }
        public decimal price { get; set; }
        public string qty { get; set; }
        public int reorder { get; set; }

    }
}