<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/AdminMasterPage.master" AutoEventWireup="true" CodeFile="Brand.aspx.cs" Inherits="Admin_Brand" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
   <%-- this is heads section--%>
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.2.3/dist/css/bootstrap.min.css" rel="stylesheet">
  <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.2.3/dist/js/bootstrap.bundle.min.js"></script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div class="container mt-3">
  <h2>Brand Detail</h2>
  
    <div class="mb-3 mt-3">
      <label for="email">Brand Name:</label>
      <asp:TextBox ID="txtBrand" runat="server" class="form-control" placeholder="Enter Brand"></asp:TextBox>
    </div>
   <%-- <div class="mb-3">
      <label for="action">Action:</label>
      <asp:TextBox ID="txtAction" runat="server" class="form-control" placeholder="Enter Action"></asp:TextBox>
    </div>

        <div class="mb-3">
      <label for="cteatedby">Created By:</label>
      <asp:TextBox ID="txtcreatedby" runat="server" class="form-control" placeholder="Enter Created By"></asp:TextBox>
    </div>

        <div class="mb-3">
      <label for="createddate">Created Date:</label>
      <asp:TextBox ID="txtcreateddate" runat="server" class="form-control" placeholder="Enter Created Date"></asp:TextBox>
    </div>--%>
   
        <asp:Button ID="btnSubmit" runat="server" Text="Button"  class="btn btn-primary" OnClick="btnSubmit_Click" onClientClick="return Validate()"/>
        <br />
        <br />

        <hr />
        <asp:GridView ID="GridViewBrand" runat="server" EmptyDataText="Record Not Found" width="100%" CssClass="table table-striped table-bordered table-hover">

        </asp:GridView>


</div>

      
    <script type="text/javascript">
        function Validate() { 
            var brand = document.getElementById("txtBrand").value;
            //var action = document.getElementById("txtAction").value;
            //var createdby = document.getElementById("txtcreatedby").value;
            //var createdate = document.getElementById("txtcreateddate").value;

            if (brand == "") {
                alert("Enter Brand name");
                document.getElementById("txtBrand").focus();
                return false;
            }
            //else if (action == "") {
            //    alert("Enter Action");
            //    document.getElementById("txtAction").focus();
            //    return false;
            //}
            //else if (createdby == "") {
            //    alert("Fill the details");
            //    document.getElementById("txtcreatedby").focus();
            //    return false;
            //}
            //else if (cteateddate == "") {
            //    alert("Fill the details");
            //    document.getElementById("txtcreteddate").focus();
            //    return false;
            //}
            return true;
        }
    </script>
</asp:Content>

