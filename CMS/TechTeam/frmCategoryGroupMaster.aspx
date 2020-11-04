<%@ Page Title="" Language="C#" MasterPageFile="~/TechAdmin.Master" AutoEventWireup="true" CodeBehind="frmCategoryGroupMaster.aspx.cs" Inherits="CMS.TechTeam.frmCategoryGroupMaster" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHoldersidebar" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolderMenu" runat="server">
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="headertitle" runat="server">
</asp:Content>
<asp:Content ID="Content5" ContentPlaceHolderID="ContentPlaceHolderSearch" runat="server">
    <asp:Label runat ="server" ID="lblMsg"></asp:Label> 
	<table width="100%" cellpadding="3" cellspacing="0" border="0"> 
	<tr> 
	<td style="width:50%;vertical-align:top;text-align:right"> 
 CategoryGroupCode	</td> 
	<td style="vertical-align:top;text-align:left"> 
	<asp:Label runat="server" Style="width: 60%;Height:25px" CssClass="lblField" id="lblCategoryGroupCode"></asp:Label>	</td>
	</tr> 
	<tr> 
	<td style="width:50%;vertical-align:top;text-align:right"> 
 CanteenCode	</td> 
	<td style="width:50%;vertical-align:top;text-align:left;"> 
	<asp:TextBox runat="server" MaxLength="" Style="width: 60%;Height:25px"  id="txtCanteenCode"></asp:TextBox>	</td>
	</tr> 
	<tr> 
	<td style="width:50%;vertical-align:top;text-align:right"> 
 CategoryGroupName	</td> 
	<td style="width:50%;vertical-align:top;text-align:left;"> 
	<asp:TextBox runat="server" MaxLength="50" Style="width: 60%;Height:25px"  id="txtCategoryGroupName"></asp:TextBox>	</td>
	</tr> 
	<tr> 
	<td style="width:50%;vertical-align:top;text-align:right"> 
 CategoryGroupActive	</td> 
	<td style="vertical-align:top;text-align:left"> 
	<asp:CheckBoxList runat="server"  id="chklistCategoryGroupActive"></asp:CheckBoxList>	</td>
	</tr> 
	<tr> 
	<td  colspan="2">
	<table  style="width:100%"> 
	<tr> 
	<td style="text-align:right;padding-right:20px">
	<asp:LinkButton ID="btnSave" Text="Save" runat="server" OnClick="btnSave_Click"/>
 </td>
	<td style="text-align:left;padding-left:20px;">
	<asp:LinkButton ID="btnCancel" Text="Cancel" runat="server" OnClick="btnCancel_Click"/>
	</td> 
	</tr> 
	</table> 
	</td>
	</tr> 
	</table> 

</asp:Content>
<asp:Content ID="Content6" ContentPlaceHolderID="AnalyArea1" runat="server">
</asp:Content>
<asp:Content ID="Content7" ContentPlaceHolderID="AnalyArea2" runat="server">
</asp:Content>
<asp:Content ID="Content8" ContentPlaceHolderID="AnalyArea3" runat="server">
</asp:Content>
<asp:Content ID="Content9" ContentPlaceHolderID="AnalyArea4" runat="server">
</asp:Content>
<asp:Content ID="Content10" ContentPlaceHolderID="AnalyArea5" runat="server">
</asp:Content>
<asp:Content ID="Content11" ContentPlaceHolderID="AnalyArea6" runat="server">
</asp:Content>
<asp:Content ID="Content12" ContentPlaceHolderID="AnalyArea7" runat="server">
</asp:Content>
<asp:Content ID="Content13" ContentPlaceHolderID="AnalyArea8" runat="server">
</asp:Content>
<asp:Content ID="Content14" ContentPlaceHolderID="AnalyAreaOther" runat="server">
</asp:Content>
