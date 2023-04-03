<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/AdminMasterPage.master" AutoEventWireup="true" CodeFile="WebCateogry.aspx.cs" Inherits="Admin_WebCateogry" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
     <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.2.3/dist/css/bootstrap.min.css" rel="stylesheet">
  <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.2.3/dist/js/bootstrap.bundle.min.js"></script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
     <div class="container mt-3">
  <h2>Cateogry Detail</h2>
  
    <div class="mb-3 mt-3">
      <label for="email">Cateogry Name:</label>
      <asp:TextBox ID="txtCategory" runat="server" class="form-control" placeholder="Enter Category"></asp:TextBox>
    </div>
    <asp:Button ID="btnSubmit" runat="server" Text="Button"  class="btn btn-primary" OnClick="btnSubmit_Click" />
        <br />
</div>
</asp:Content>

