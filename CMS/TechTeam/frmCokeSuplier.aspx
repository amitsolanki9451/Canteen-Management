<%@ Page Title="" Language="C#" MasterPageFile="~/TechAdmin.Master" AutoEventWireup="true" CodeBehind="frmCokeSuplier.aspx.cs" Inherits="CMS.TechTeam.frmCokeSuplier" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHoldersidebar" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolderMenu" runat="server">
         <ul class="nav navbar-nav mai-top-nav">
        <li class="nav-item"><a href="frmCokeSuplier.aspx" class="nav-link">Add Coke Supplier Type</a>
        </li>
        <li class="nav-item"><a href="frmCokeSuplierEdit.aspx" class="nav-link">View Coke Supplier Type </a>
        </li>        
    </ul>
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="headertitle" runat="server">
    <div class="col-md-10">

        <div>
            <h3><span style="color: #130349; margin-left: 25%;"> Coke Supplier Name</span></h3>
        </div>
    </div>
</asp:Content>
<asp:Content ID="Content5" ContentPlaceHolderID="ContentPlaceHolderSearch" runat="server">
    <div class="col-lg-12 col-md-12 col-sm-12">
        <div style="padding: 10px;">

            <div class="row">
               

                <div class="col-lg-3 col-md-3 col-sm-3"></div>
                <div class="col-lg-6 col-md-6 col-sm-6">

                  
                    <table class="table table-bordered" style="-webkit-box-shadow: 0 10px 20px 0 rgba(0,0,0,0.3); box-shadow: 0 10px 20px 0 rgba(0,0,0,0.3);">
                        <tr style="text-align: center;">
                            <td colspan="2">                                
                                    <span style="color:#b60f0f; font-size:18px; font-weight:bold;"> <asp:Label runat="server" ID="lblMsg"></asp:Label></span>
                            </td>
                        </tr>
                         <tr>
                            <td style="width: 30%; vertical-align: top; text-align: right">Coke Supplier </td>
                            <td style="vertical-align: top; text-align: left; width:70%;">
                                <asp:TextBox runat="server" MaxLength="50" Style="height: 30px" ID="txtCokeSupplier" CssClass="form-control" placeholder="Enter Supplier Name"></asp:TextBox>
                                  <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" EnableClientScript="true" ValidationGroup="ValGroupinsert" ControlToValidate="txtCokeSupplier" ErrorMessage="Enter Coke Supplier Name" Display="None" ForeColor="#FF3300"></asp:RequiredFieldValidator>

                            </td>
                        </tr>
                        <tr>
                            <td style="width: 30%; vertical-align: top; text-align: right">Address-1 </td>
                            <td style="width: 70%; vertical-align: top; text-align: left">
                                <asp:TextBox runat="server" MaxLength="50" Style="height: 30px" ID="txtAddress1" CssClass="form-control" placeholder="Enter Address (Line 1)"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td style="width: 30%; vertical-align: top; text-align: right">Address-2 </td>
                            <td style="width: 70%; vertical-align: top; text-align: left">
                                <asp:TextBox runat="server" MaxLength="50" Style="height: 30px" ID="txtAddress2" CssClass="form-control" placeholder="Enter Address (Line 2)"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td style="width: 30%; vertical-align: top; text-align: right">Address-3 </td>
                            <td style="width: 70%; vertical-align: top; text-align: left">
                                <asp:TextBox runat="server" MaxLength="50" Style="height: 30px" ID="txtAddress3" CssClass="form-control" placeholder="Enter Address (Line 3)"></asp:TextBox>
                            </td>
                        </tr>
                        

                        <tr>
                            <td style="width: 30%; vertical-align: top; text-align: right">Contact Person </td>
                            <td style="width: 70%; vertical-align: top; text-align: left">
                                <asp:TextBox runat="server" MaxLength="50" Style="height: 30px" ID="txtContactPerson" CssClass="form-control" placeholder="Enter Contact Person"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td style="width: 30%; vertical-align: top; text-align: right">Mobile No</td>
                            <td style="width: 70%; vertical-align: top; text-align: left">
                                <asp:TextBox runat="server" MaxLength="10" Style="height: 30px" ID="txtMobNo"  CssClass="form-control" placeholder="Enter Mobile No"></asp:TextBox>
                                <div>
                                <ajaxToolkit:FilteredTextBoxExtender ID="FilteredTextBoxExtender5" runat="server" TargetControlID="txtMobNo" ValidChars="." FilterType="Numbers,Custom" />
                           </div>  
                            </td>
                        </tr>

                        <tr>
                            <td style="width: 30%; vertical-align: top; text-align: right">Email</td>
                            <td style="width: 70%; vertical-align: top; text-align: left">
                                <asp:TextBox runat="server" MaxLength="50" Style="height: 30px" ID="txtEmail" CssClass="form-control" placeholder="Enter Email"></asp:TextBox> 
                               <div>
                                    <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="txtEmail" ErrorMessage="Please Enter Correct Email ID"
                                    ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"
                                    ValidationGroup="ValGroupinsert" Font-Size="Smaller" ForeColor="#CC3300" Display="None"></asp:RegularExpressionValidator>
                               </div>
                            </td>
                        </tr>
                        <tr>
                            <td style="width: 30%; vertical-align: top; text-align: right">Remarks</td>
                            <td style="width: 70%; vertical-align: top; text-align: left">
                                <asp:TextBox runat="server" MaxLength="50" Style="height: 30px" ID="txtRemarks" TextMode="MultiLine" CssClass="form-control" placeholder="Enter Remarks"></asp:TextBox>
                            </td>
                        </tr>
                         <tr style="text-align:center;">
                           
                            <td colspan="2">
                                <asp:Button ID="btnSave" Text="Save" runat="server" OnClick="btnSave_Click" ValidationGroup="ValGroupinsert" class="btn btn-success" />
                                &nbsp;<asp:Button ID="btnCancel" Text="Cancel" runat="server" OnClick="btnCancel_Click" CausesValidation="false" class="btn btn-danger" />
                                <asp:ValidationSummary HeaderText="You must enter a value in the following fields :" DisplayMode="BulletList" EnableClientScript="true" runat="server" ForeColor="#0033CC" ShowMessageBox="True" ShowSummary="False" ValidationGroup="ValGroupinsert" />
                            </td>
                        </tr>
                         <tr>
                                        <td colspan="2">
                                            <asp:ValidationSummary HeaderText="You must enter a value in the following fields :" DisplayMode="BulletList" EnableClientScript="true" runat="server" ForeColor="#0033CC" ShowMessageBox="True" ShowSummary="False" />
                                        </td>
                                    </tr>
                    </table>

                    <div class="col-lg-2 col-md-2 col-sm-2"></div>
                </div>
                  <div class="col-lg-3 col-md-3 col-sm-3"></div>
            </div>
            </div>
        </div>
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