<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="HindalcoCarbon._78_data.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<link rel="stylesheet" href="78_data/bootstrap.min.css"/>

    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:TextBox ID="TextBox1" runat="server">
           </asp:TextBox>
    <div>
  <asp:DropDownList ID="DropDownList1" CssClass="selectpicker" runat="server">
     <asp:ListItem>Allahabad</asp:ListItem>
      <asp:ListItem>Kanpur</asp:ListItem>
      <asp:ListItem>Rewa</asp:ListItem>
      <asp:ListItem>Bhopal</asp:ListItem>
      <asp:ListItem>Indore</asp:ListItem>
      <asp:ListItem>Jabalpur</asp:ListItem>
   </asp:DropDownList>
    </div>
    </form>  
    
    <script type="text/javascript">
                $(document).ready(function () {
                    $(".selectpicker").selectpicker();
                });
</script>
<script src="js/jquery-3.3.1.min.js"></script>
      <script src="js/bootstrap.min.js"></script>
      <script src="js/bootstrap-select.js"></script>

</body>
</html>
