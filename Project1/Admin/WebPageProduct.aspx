<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/AdminMasterPage.master" AutoEventWireup="true" CodeFile="WebPageProduct.aspx.cs" Inherits="Admin_WebPageProduct" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
     <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.2.3/dist/css/bootstrap.min.css" rel="stylesheet">
  <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.2.3/dist/js/bootstrap.bundle.min.js"></script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div class="container mt-3">
  <h2>Add Product Detail</h2>

    <div class="mb-3 mt-3">
      <label for="ProductCode">Product Code:</label>
      <asp:TextBox ID="txtProductID" runat="server" class="form-control" placeholder="Enter PID"></asp:TextBox>
    </div>
  
    <div class="mb-3 mt-3">
      <label for="Barcode">Barcode:</label>
      <asp:TextBox ID="txtBarcode" runat="server" class="form-control" placeholder="Enter Barcode Name"></asp:TextBox>
    </div>
   <div class="mb-3">
      <label for="#">Description (PName):</label>
      <asp:TextBox ID="txtDescription" runat="server" class="form-control" placeholder="Enter Description"></asp:TextBox>
    </div>

        <div class="mb-3">
      <label for="cteatedby">Select Brand:</label>
            <asp:DropDownList ID="ddlBrand" class="form-control" runat="server">
                <asp:ListItem>Nokia</asp:ListItem>
                <asp:ListItem>Motorolla</asp:ListItem>
                <asp:ListItem>Vivo</asp:ListItem>
            </asp:DropDownList>
       </div>

        <div class="mb-3">
      <label for="Category">Category:</label>
      <asp:DropDownList ID="ddlCategory" class="form-control" runat="server">
          <asp:ListItem>Television</asp:ListItem>
          <asp:ListItem>Mobile</asp:ListItem>
          <asp:ListItem>Laptop</asp:ListItem>
            </asp:DropDownList>
    </div>
   
        <div class="mb-3 mt-3">
      <label for="Price">Price:</label>
      <asp:TextBox ID="txtPrice" runat="server" class="form-control" placeholder="Enter Price"></asp:TextBox>
    </div>

        <div class="mb-3 mt-3">
      <label for="Qty">Quantity:</label>
      <asp:TextBox ID="txtQty" runat="server" class="form-control" placeholder="Enter Quantity"></asp:TextBox>
    </div>
         
        <asp:Button ID="btnSubmit" runat="server" Text="Button"  class="btn btn-primary" OnClick="btnSubmit_Click" />
        <br />
</div>
</asp:Content>

