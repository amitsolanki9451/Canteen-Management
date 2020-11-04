<%@ Page Title="" Language="C#" MasterPageFile="~/TechAdmin.Master" AutoEventWireup="true" CodeBehind="frmUser.aspx.cs" Inherits="CMS.TechTeam.frmUser" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="ajaxToolkit" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        #pageloaddiv {
            position: fixed;
            left: 0px;
            top: 0px;
            width: 100%;
            height: 100%;
            z-index: 1000;
            background: url('pageloader.gif') no-repeat center center;
        }

        #overlay {
            position: fixed;
            z-index: 99;
            top: 0px;
            left: 0px;
            background-color: #f8f8f8;
            width: 100%;
            height: 100%;
            filter: Alpha(Opacity=90);
            opacity: 0.9;
            -moz-opacity: 0.9;
        }

        #theprogress {
            background-color: #fff;
            border: 1px solid #ccc;
            padding: 10px;
            width: 300px;
            height: 30px;
            line-height: 30px;
            text-align: center;
            filter: Alpha(Opacity=100);
            opacity: 1;
            -moz-opacity: 1;
        }

        #modalprogress {
            position: absolute;
            top: 40%;
            left: 50%;
            margin: -11px 0 0 -150px;
            color: #990000;
            font-weight: bold;
            font-size: 14px;
        }

        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHoldersidebar" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolderMenu" runat="server">

    <ul class="nav navbar-nav mai-top-nav">
        <li class="nav-item"><a href="frmUser.aspx" class="nav-link">Add User</a>
        </li>
        <li class="nav-item"><a href="frmUserEdit.aspx" class="nav-link">View User </a>
        </li>
    </ul>
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="headertitle" runat="server">
    <div class="col-md-10">

        <div>
            <h3><span style="color: #130349; margin-left: 25%;">User Registration</span></h3>
        </div>
    </div>
</asp:Content>
<asp:Content ID="Content5" ContentPlaceHolderID="ContentPlaceHolderSearch" runat="server">
    <div class="col-md-12">
        <div style="padding: 10px;">

            <div class="row">


                <div class="col-sm-2"></div>
                <div class="col-sm-8">

                    <table class="table table-bordered" style="-webkit-box-shadow: 0 10px 20px 0 rgba(0,0,0,0.3); box-shadow: 0 10px 20px 0 rgba(0,0,0,0.3);">
                        <tr style="text-align: center;">
                            <td colspan="2">
                                <b>
                                    <asp:Label runat="server" ID="lblMsg"></asp:Label></b>
                            </td>
                        </tr>
                        <tr>
                            <td style="width: 35%; vertical-align: middle; text-align: right">
                                <asp:Label runat="server" ID="lblGlobalUserType" Text="User Type "></asp:Label></td>
                            <td style="width: 50%; vertical-align: middle; text-align: left">
                                <asp:DropDownList runat="server" Style="width: 60%; height: 30px" ValidationGroup="usergroup" ID="ddlUserType" CssClass="form-control"></asp:DropDownList>
                                <div>
                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator8" runat="server" ValidationGroup="usergroup" ControlToValidate="ddlUserType" InitialValue="-1" ErrorMessage="*" Display="Dynamic" ForeColor="#FF3300"></asp:RequiredFieldValidator>
                                </div>
                            </td>

                        </tr>
                        <tr>
                            <td style="width: 35%; vertical-align: middle; text-align: right">User Name</td>
                            <td style="width: 50%; vertical-align: middle; text-align: left">
                                <asp:TextBox runat="server" MaxLength="50" Style="width: 60%; height: 30px" ID="txtUserName" ValidationGroup="usergroup" CssClass="form-control"></asp:TextBox>
                                <div>
                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ValidationGroup="ValGroupinsert" ControlToValidate="txtUserName" ErrorMessage="*" Display="Dynamic" ForeColor="#FF3300"></asp:RequiredFieldValidator>
                                    <ajaxToolkit:FilteredTextBoxExtender ID="FilteredTextBoxExtender2" runat="server" TargetControlID="txtUserName" ValidChars="@._" FilterType="LowercaseLetters,UppercaseLetters,Numbers,Custom" />
                                </div>
                            </td>

                        </tr>

                        <tr>
                            <td style="width: 35%; vertical-align: middle; text-align: right">First Name </td>
                            <td style="width: 50%; vertical-align: middle; text-align: left">
                                <asp:TextBox runat="server" MaxLength="50" Style="width: 60%; height: 30px" ID="txtFirstName" ValidationGroup="usergroup" CssClass="form-control"></asp:TextBox>
                                <div>
                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ValidationGroup="usergroup" ControlToValidate="txtFirstName" ErrorMessage="*" Display="Dynamic" ForeColor="#FF3300"></asp:RequiredFieldValidator>
                                    <ajaxToolkit:FilteredTextBoxExtender ID="FilteredTextBoxExtender1" runat="server" TargetControlID="txtFirstName" ValidChars=" " FilterType="LowercaseLetters,UppercaseLetters,Custom" />
                                </div>
                            </td>

                        </tr>
                        <tr>
                            <td style="width: 35%; vertical-align: middle; text-align: right">Last Name </td>
                            <td style="width: 15%; vertical-align: middle; text-align: left">
                                <asp:TextBox runat="server" MaxLength="50" Style="width: 60%; height: 30px" ID="txtLastName" ValidationGroup="usergroup" CssClass="form-control"></asp:TextBox>
                                <div>
                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ValidationGroup="usergroup" ControlToValidate="txtLastName" ErrorMessage="*" Display="Dynamic" ForeColor="#FF3300"></asp:RequiredFieldValidator>
                                    <ajaxToolkit:FilteredTextBoxExtender ID="FilteredTextBoxExtender3" runat="server" TargetControlID="txtLastName" ValidChars=" " FilterType="LowercaseLetters,UppercaseLetters,Custom" />
                                </div>
                            </td>

                        </tr>
                        <tr>
                            <td style="width: 35%; vertical-align: middle; text-align: right">Email </td>
                            <td style="width: 50%; vertical-align: middle; text-align: left">
                                <asp:TextBox runat="server" MaxLength="50" Style="width: 60%; height: 30px"
                                    ID="txtEmail" TextMode="Email" ValidationGroup="usergroup" CssClass="form-control"></asp:TextBox>
                                <div>
                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ValidationGroup="usergroup" ControlToValidate="txtEmail" ErrorMessage="*" Display="Dynamic" ForeColor="#FF3300"></asp:RequiredFieldValidator>

                                    <ajaxToolkit:FilteredTextBoxExtender ID="FilteredTextBoxExtender4" runat="server" TargetControlID="txtEmail" ValidChars="(@)(.+)$" FilterType="LowercaseLetters,UppercaseLetters,Numbers,Custom" />
                                </div>
                            </td>

                        </tr>
                        <tr>
                            <td style="width: 35%; vertical-align: middle; text-align: right">Telephone </td>
                            <td style="width: 50%; vertical-align: middle; text-align: left">
                                <asp:TextBox runat="server" MaxLength="11" Style="width: 60%; height: 30px" ID="txtTelephone" ValidationGroup="usergroup" CssClass="form-control"></asp:TextBox>
                                <div>
                                    <ajaxToolkit:FilteredTextBoxExtender ID="FilteredTextBoxExtender8" runat="server" TargetControlID="txtTelephone" ValidChars="" FilterType="Numbers,Custom" />
                                </div>
                            </td>

                        </tr>
                        <tr>
                            <td style="width: 35%; vertical-align: middle; text-align: right">Mobile </td>
                            <td style="width: 50%; vertical-align: middle; text-align: left">
                                <asp:TextBox runat="server" MaxLength="11" Style="width: 60%; height: 30px" ID="txtMobile" ValidationGroup="usergroup" CssClass="form-control"></asp:TextBox>
                                <div>
                                    <ajaxToolkit:FilteredTextBoxExtender ID="FilteredTextBoxExtender5" runat="server" TargetControlID="txtMobile" ValidChars="" FilterType="Numbers,Custom" />
                                </div>
                            </td>

                        </tr>

                        <tr>
                            <td style="width: 35%; vertical-align: middle; text-align: right">Password </td>
                            <td style="width: 50%; vertical-align: middle; text-align: left">
                                <asp:TextBox runat="server" MaxLength="50" Style="width: 60%; height: 30px" ID="txtPassword" TextMode="Password" ValidationGroup="usergroup" CssClass="form-control"></asp:TextBox>
                                <div>
                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ValidationGroup="usergroup" ControlToValidate="txtPassword" ErrorMessage="*" Display="Dynamic" ForeColor="#FF3300"></asp:RequiredFieldValidator>
                                    <ajaxToolkit:FilteredTextBoxExtender ID="FilteredTextBoxExtender6" runat="server" TargetControlID="txtPassword" ValidChars="@#" FilterType="LowercaseLetters,UppercaseLetters,Numbers,Custom" />
                                </div>
                            </td>

                        </tr>
                        <tr>
                            <td style="width: 35%; vertical-align: middle; text-align: right">Re-Password </td>
                            <td style="width: 50%; vertical-align: middle; text-align: left">
                                <asp:TextBox runat="server" MaxLength="50" Style="width: 60%; height: 30px" ID="txtRePassword" TextMode="Password" ValidationGroup="usergroup" CssClass="form-control"></asp:TextBox>
                                <div>

                                    <ajaxToolkit:FilteredTextBoxExtender ID="FilteredTextBoxExtender7" runat="server" TargetControlID="txtRePassword" ValidChars="@#" FilterType="LowercaseLetters,UppercaseLetters,Numbers,Custom" />
                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" ValidationGroup="usergroup" ControlToValidate="txtRePassword" ErrorMessage="*" Display="Dynamic" ForeColor="#FF3300"></asp:RequiredFieldValidator>
                                    <asp:CompareValidator ID="CompareValidator1" runat="server" Display="Dynamic" ValidationGroup="usergroup" ErrorMessage="Password is not matched!" ControlToCompare="txtPassword"
                                        ControlToValidate="txtRePassword"></asp:CompareValidator>

                                </div>
                            </td>

                        </tr>



                        <tr style="text-align: center;">

                            <td colspan="2">
                                <asp:Button ID="btnSave" Text="Save" runat="server" OnClick="btnSave_Click" ValidationGroup="usergroup" class="btn btn-success" />
                                &nbsp;<asp:Button ID="btnCancel" Text="Cancel" runat="server" OnClick="btnCancel_Click" CausesValidation="false" class="btn btn-danger" />
                                <asp:ValidationSummary HeaderText="You must enter a value in the following fields :" DisplayMode="BulletList" EnableClientScript="true" runat="server" ForeColor="#0033CC" ShowMessageBox="True" ShowSummary="False" ValidationGroup="ValGroupinsert" />
                            </td>
                        </tr>

                    </table>

                </div>
                <div class="col-sm-2"></div>
            </div>
        </div>
    </div>
</asp:Content>
<asp:Content ID="Content6" ContentPlaceHolderID="AnalyArea1" runat="server">
</asp:Content>
<asp:Content ID="Content7" ContentPlaceHolderID="AnalyArea2" runat="server">
    <ajaxToolkit:Accordion ID="Accordion2" runat="server">
    </ajaxToolkit:Accordion>
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
