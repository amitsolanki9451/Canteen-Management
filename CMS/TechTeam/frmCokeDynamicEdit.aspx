<%@ Page Title="" Language="C#" MasterPageFile="~/TechAdmin.Master" AutoEventWireup="true" CodeBehind="frmCokeDynamicEdit.aspx.cs" Inherits="CMS.TechTeam.frmCokeDynamicEdit" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

    <style type="text/css">
        .centerHeaderText th {
            text-align: center !important;
        }

        #formContentEDIT {
            -webkit-border-radius: 10px 10px 10px 10px;
            border-radius: 10px 10px 10px 10px;
            background: #fff;
            padding: 10px;
            width: 60%;
            min-width: 550px;
            position: relative;
            margin: 0 auto;
            -webkit-box-shadow: 0 30px 60px 0 rgba(0,0,0,0.3);
            box-shadow: 0 30px 60px 0 rgba(0,0,0,0.3);
            /*padding-top: 30px;
            padding-bottom: 30px;*/
            /*text-align: center;*/
        }

        #formContentVIEW {
            -webkit-border-radius: 10px 10px 10px 10px;
            border-radius: 10px 10px 10px 10px;
            background: #fff;
            padding: 10px;
            width: 90%;
            min-width: 650px;
            position: relative;
            margin: 0 auto;
            -webkit-box-shadow: 0 30px 60px 0 rgba(0,0,0,0.3);
            box-shadow: 0 30px 60px 0 rgba(0,0,0,0.3);
            text-align: center;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHoldersidebar" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolderMenu" runat="server">
    <ul class="nav navbar-nav mai-top-nav">
        <li class="nav-item"><a href="frmCokeDynamic.aspx" class="nav-link">Add Coke Dynamic</a>
        </li>
        <li class="nav-item"><a href="frmCokeDynamicEdit.aspx" class="nav-link">View Coke Dynamic </a>
        </li>
    </ul>
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="headertitle" runat="server">
    <div class="col-md-12">
        <div>
            <h3><span style="color: #130349; margin-top: 20%">Coke Dynamic View</span></h3>
        </div>
    </div>

</asp:Content>
<asp:Content ID="Content5" ContentPlaceHolderID="ContentPlaceHolderSearch" runat="server">
    <div style="padding: 0px;">
        <div class="row">
            <div class="col-lg-1 col-md-1 col-sm-1">
            </div>
            <div class="col-lg-10 col-md-10 col-sm-10">
                <%-- <div class="rounded_corners" style="width: auto;">--%>

                <asp:UpdatePanel ID="UpdatePanelSearch" runat="server" UpdateMode="Conditional">
                    <ContentTemplate>
                        <table style="width: 100%">
                            <tr style="padding: 5px">

                                <td style="width: 10%; vertical-align: middle; text-align: right; padding: 5px;"><b> Coke Supplier </b></td>
                                <td style="width: 20%; vertical-align: middle; text-align: left; padding: 5px;">
                                    <asp:DropDownList runat="server" Style="width: 100%; height: 30px" ID="ddlCokeSupplierSearch" ValidationGroup="ValGroupSearch"></asp:DropDownList>
                                </td>

                                <td style="width: 10%; vertical-align: middle; text-align: right; padding: 5px;"><b> Coke Type </b></td>
                                <td style="width: 20%; vertical-align: middle; text-align: left; padding: 5px;">
                                    <asp:DropDownList runat="server" Style="width: 100%; height: 30px" ID="ddlCokeTypeSearch" ValidationGroup="ValGroupSearch"></asp:DropDownList>
                                </td>


                                <td style="width: 10%; vertical-align: middle; text-align: right; padding: 5px;"> <b>Analysis Type </b></td>
                                <td style="width: 20%; vertical-align: middle; text-align: left; padding: 5px;">
                                    <asp:DropDownList runat="server" Style="width: 100%; height: 30px" ID="ddlAnalysisTypeSearch" ValidationGroup="ValGroupSearch"></asp:DropDownList>
                                </td>

                                <td style="width: 10%; vertical-align: middle; text-align: right; padding: 5px;">
                                    <asp:Button ID="btnSearch" Text="Search" runat="server" OnClick="btnSearch_Click" ValidationGroup="ValGroupSearch" Width="100px" Height="30px" CssClass="btn btn-info" />
                                </td>
                                <td></td>
                            </tr>

                        </table>
                    </ContentTemplate>
                    <Triggers>
                        <asp:AsyncPostBackTrigger ControlID="btnSearch" EventName="Click" />
                    </Triggers>
                </asp:UpdatePanel>
                <%--</div>--%>
            </div>
            <div class="col-lg-1 col-md-1 col-sm-1">

                <div style="vertical-align: middle; text-align: center;">
                    <asp:UpdateProgress ID="UpdateMessagesProgress" DynamicLayout="true" runat="server" DisplayAfter="0">
                        <ProgressTemplate>
                            Loading. Please wait.<br />
                            <br />
                            <img src="~/loader.gif" runat="server" alt="" />
                        </ProgressTemplate>
                    </asp:UpdateProgress>
                </div>

            </div>
        </div>
    </div>
</asp:Content>
<asp:Content ID="Content6" ContentPlaceHolderID="AnalyArea1" runat="server">
    <div style="padding: 0px;">
        <div class="row">
            <div class="col-lg-12 col-md-12 col-sm-12 col-xs-12">
                <div runat="server" id="AlarmInfo" data-type="anchor">
                    <div style="text-align: center" runat="server">
                        <%--<div class="rounded_corners" style="width: auto">--%>
                        <asp:UpdatePanel ID="UpdatePanelGrid" runat="server" UpdateMode="Conditional">
                            <ContentTemplate>
                                <asp:Label runat="server" ID="lblMsg"></asp:Label>

                                <asp:GridView ID="grdCokeDynamicEdit" runat="server" AutoGenerateColumns="False" CssClass="Grid" PagerStyle-CssClass="GridPager" HeaderStyle-CssClass="Gridheader" RowStyle-CssClass="Gridrows"
                                    DataKeyNames="Id,CokeDynamicId" OnRowDataBound="grdCokeDynamicEdit_RowDataBound" OnRowEditing="grdCokeDynamicEdit_RowEditing"
                                    ShowFooter="false" OnRowDeleting="grdCokeDynamicEdit_RowDeleting" AllowPaging="True" PageSize="100"
                                    AllowSorting="true" GridLines="None" OnPageIndexChanging="grdCokeDynamicEdit_PageIndexChanging" OnSelectedIndexChanging="grdCokeDynamicEdit_SelectedIndexChanging">
                                    <Columns>
                                        <asp:TemplateField HeaderText="Sl.No." ItemStyle-Width="5%">
                                            <ItemTemplate>
                                                <asp:Label ID="lblRowNumber" Text='<%# Container.DataItemIndex + 1 %>' runat="server" />
                                            </ItemTemplate>
                                            <ItemStyle Width="5%" />
                                        </asp:TemplateField>
                                        <asp:TemplateField HeaderText="View" ItemStyle-Width="5%">
                                            <ItemTemplate>
                                                <asp:ImageButton ID="lnlIdView" ToolTip="Select" runat="server" AlternateText="Select"
                                                    BorderWidth="0" CausesValidation="false" CommandArgument='<%# Eval("Id")  %>'
                                                    CommandName="Select" ImageUrl="../Images/select.png" />
                                            </ItemTemplate>
                                            <HeaderStyle HorizontalAlign="Center" />
                                            <ItemStyle VerticalAlign="Middle" Width="5%" />
                                        </asp:TemplateField>

                                        <asp:TemplateField HeaderText="Edit" ItemStyle-Width="5%">
                                            <ItemTemplate>

                                                <asp:ImageButton ID="lnlIdEdit" ToolTip="Edit" runat="server" AlternateText="Edit"
                                                    BorderWidth="0" CausesValidation="false" CommandArgument='<%# Eval("Id")  %>'
                                                    CommandName="Edit" ImageUrl="../Images/edit-icon.png" />
                                            </ItemTemplate>
                                            <HeaderStyle HorizontalAlign="Center" />
                                            <ItemStyle VerticalAlign="Middle" Width="5%" />
                                        </asp:TemplateField>

                                        <asp:TemplateField HeaderText="Delete" ItemStyle-Width="5%">
                                            <ItemTemplate>
                                                <asp:ImageButton ID="imgDelete" ToolTip="delete" runat="server" AlternateText="Delete"
                                                    BorderWidth="0" CausesValidation="false" CommandArgument='<%# Eval("Id")  %>'
                                                    CommandName="Delete" ImageUrl="../Images/delete-img.png" OnClientClick="javascript: return confirm(&quot;Are you sure you want to delete this item?&quot;);" />
                                            </ItemTemplate>
                                            <HeaderStyle HorizontalAlign="Center" />
                                            <ItemStyle VerticalAlign="Middle" Width="5%" />
                                        </asp:TemplateField>
                                        <asp:TemplateField ItemStyle-VerticalAlign="Middle" ItemStyle-HorizontalAlign="Center" HeaderStyle-VerticalAlign="Middle" HeaderStyle-HorizontalAlign="Center" HeaderText="Parameter" ItemStyle-Width="10%">
                                            <ItemTemplate>
                                                <asp:Label ID="lblFieldSize" runat="server" Text='<%# Eval("FieldSize")  %>'></asp:Label>
                                            </ItemTemplate>
                                            <HeaderStyle HorizontalAlign="Center" VerticalAlign="Middle" />
                                            <ItemStyle HorizontalAlign="Center" VerticalAlign="Middle" Width="10%" />
                                        </asp:TemplateField>

                                        <asp:TemplateField ItemStyle-VerticalAlign="Middle" ItemStyle-HorizontalAlign="Center" HeaderStyle-VerticalAlign="Middle" HeaderStyle-HorizontalAlign="Center" HeaderText="UoM" ItemStyle-Width="10%">
                                            <ItemTemplate>
                                                <asp:Label ID="lblFieldUnit" runat="server" Text='<%# Eval("FieldUnit")  %>'></asp:Label>
                                            </ItemTemplate>
                                            <HeaderStyle HorizontalAlign="Center" VerticalAlign="Middle" />
                                            <ItemStyle HorizontalAlign="Center" VerticalAlign="Middle" Width="10%" />
                                        </asp:TemplateField>

                                        <asp:TemplateField ItemStyle-VerticalAlign="Middle" ItemStyle-HorizontalAlign="Center" HeaderStyle-VerticalAlign="Middle" HeaderStyle-HorizontalAlign="Center" HeaderText="Specification" ItemStyle-Width="10%">
                                            <ItemTemplate>
                                                <asp:Label ID="lblFieldSpec" runat="server" Text='<%# Eval("FieldSpec")  %>'></asp:Label>
                                            </ItemTemplate>
                                            <HeaderStyle HorizontalAlign="Center" VerticalAlign="Middle" />
                                            <ItemStyle HorizontalAlign="Center" VerticalAlign="Middle" Width="10%" />
                                        </asp:TemplateField>

                                        <asp:TemplateField ItemStyle-VerticalAlign="Middle" ItemStyle-HorizontalAlign="Center" HeaderStyle-VerticalAlign="Middle" HeaderStyle-HorizontalAlign="Center" HeaderText="Min Value" ItemStyle-Width="10%">
                                            <ItemTemplate>
                                                <asp:Label ID="lblMinValue" runat="server" Text='<%# Eval("MinValue")  %>'></asp:Label>
                                            </ItemTemplate>
                                            <HeaderStyle HorizontalAlign="Center" VerticalAlign="Middle" />
                                            <ItemStyle HorizontalAlign="Center" VerticalAlign="Middle" Width="10%" />
                                        </asp:TemplateField>
                                        <asp:TemplateField ItemStyle-VerticalAlign="Middle" ItemStyle-HorizontalAlign="Center" HeaderStyle-VerticalAlign="Middle" HeaderStyle-HorizontalAlign="Center" HeaderText="Max value" ItemStyle-Width="10%">

                                            <ItemTemplate>
                                                <asp:Label ID="lblMaxValue" runat="server" Text='<%# Eval("Maxvalue")  %>'></asp:Label>
                                            </ItemTemplate>
                                            <HeaderStyle HorizontalAlign="Center" VerticalAlign="Middle" />
                                            <ItemStyle HorizontalAlign="Center" VerticalAlign="Middle" Width="10%" />
                                        </asp:TemplateField>

                                    </Columns>


                                </asp:GridView>
                            </ContentTemplate>
                        </asp:UpdatePanel>
                        <%--</div>--%>
                    </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
<asp:Content ID="Content7" ContentPlaceHolderID="AnalyArea2" runat="server">
    <div style="padding: 0px;">
        <div class="row">
            <div class="col-lg-12 col-md-12 col-sm-12 col-xs-12">
                <div runat="server" id="Div1" data-type="anchor">
                    <div style="text-align: center" runat="server">
                        <%--  <div class="rounded_corners" style="width: auto">--%>

                        <asp:Button runat="server" ID="btnModalEditPopUp" Style="display: none" />
                        <ajaxToolkit:ModalPopupExtender TargetControlID="btnModalEditPopUp" BackgroundCssClass="modalBackground" PopupControlID="PanelEdit" OkControlID="lnkOkEdit" ID="ModalPopupExtenderEdit" runat="server" />
                        <asp:Panel ID="PanelEdit" Visible="true" runat="server" CssClass="ModalWindow" ForeColor="#333333">


                            <div style="text-align: right">
                                <asp:LinkButton ID="lnkOkEdit" runat="server" />
                            </div>
                            <div style="text-align: center" id="formContentEDIT">
                                <fieldset>

                                    <div>
                                        <asp:UpdatePanel ID="UpdatePanelEdit" runat="server" UpdateMode="Conditional">
                                            <ContentTemplate>
                                                <asp:Label runat="server" ID="lblMsgEdit"></asp:Label>
                                                <div style="background-color: #006DF0; color: white; height: 30px; text-align: center; padding: 5px;">Coke Dynamic Edit</div>
                                                <table class="table table-bordered" style="width: 100%">
                                                    <tr>
                                                        <td style="width: 40%; vertical-align: top; text-align: right">
                                                            <asp:Label runat="server" ID="lblGlobalEditCokeSupplier" Text="Coke Supplier" ValidationGroup="ValGroupEdit"></asp:Label>
                                                            &nbsp;</td>
                                                        <td style="width: 60%; vertical-align: top; text-align: left;">
                                                            <asp:DropDownList runat="server" MaxLength="100" Style="width: 90%; height: 30px" ID="ddlCokeSupplierEdit" ValidationGroup="ValGroupEdit" AutoPostBack="True"></asp:DropDownList>
                                                            <div>
                                                                <asp:RequiredFieldValidator ID="RequiredFieldValidator9" runat="server" EnableClientScript="true" ValidationGroup="ValGroupEdit" ControlToValidate="ddlCokeSupplierEdit" InitialValue="-1" ErrorMessage="*" Display="Dynamic" ForeColor="#FF3300"></asp:RequiredFieldValidator>

                                                            </div>
                                                        </td>
                                                    </tr>
                                                    <tr>
                                                        <td style="width: 40%; vertical-align: top; text-align: right">
                                                            <asp:Label runat="server" ID="lblGlobalEditCokeType" Text="Coke Type" ValidationGroup="ValGroupEdit"></asp:Label>
                                                        </td>
                                                        <td style="width: 60%; vertical-align: top; text-align: left;">
                                                            <asp:DropDownList runat="server" MaxLength="100" Style="width: 90%; height: 30px" ID="ddlCokeTypeEdit" ValidationGroup="ValGroupEdit" AutoPostBack="True"></asp:DropDownList>
                                                            <div>
                                                                <asp:RequiredFieldValidator ID="RequiredFieldValidator10" runat="server" EnableClientScript="true" ValidationGroup="ValGroupEdit" ControlToValidate="ddlCokeTypeEdit" InitialValue="-1" ErrorMessage="*" Display="Dynamic" ForeColor="#FF3300"></asp:RequiredFieldValidator>

                                                            </div>
                                                        </td>
                                                    </tr>



                                                    <tr>
                                                        <td style="width: 40%; vertical-align: top; text-align: right">
                                                            <asp:Label runat="server" ID="lblGlobalEditAnalysisType" Text="Analysis Type " ValidationGroup="ValGroupEdit"></asp:Label>
                                                        </td>
                                                        <td style="width: 60%; vertical-align: top; text-align: left;">
                                                            <asp:DropDownList runat="server" MaxLength="100" Style="width: 90%; height: 30px" ID="ddlAnalysisTypeEdit" ValidationGroup="ValGroupEdit" AutoPostBack="True"></asp:DropDownList>
                                                            <div>
                                                                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" EnableClientScript="true" ValidationGroup="ValGroupEdit" ControlToValidate="ddlAnalysisTypeEdit" InitialValue="-1" ErrorMessage="*" Display="Dynamic" ForeColor="#FF3300"></asp:RequiredFieldValidator>

                                                            </div>
                                                        </td>
                                                    </tr>
                                                    <tr>
                                                        <td style="width: 40%; vertical-align: top; text-align: right">
                                                            <asp:Label runat="server" ID="lblGlobalEditFieldSize" Text="Parameter" ValidationGroup="ValGroupEdit"></asp:Label>
                                                            &nbsp;</td>
                                                        <td style="width: 60%; vertical-align: top; text-align: left;">
                                                            <asp:TextBox runat="server" MaxLength="100" Style="width: 90%; height: 30px" ID="txtFieldSizeEdit" ValidationGroup="ValGroupEdit" placeholder="Enter Field Name"></asp:TextBox>
                                                        </td>
                                                    </tr>
                                                    <tr>
                                                        <td style="width: 40%; vertical-align: top; text-align: right">
                                                            <asp:Label runat="server" ID="lblGlobalEditFieldUnit" Text="UoM" ValidationGroup="ValGroupEdit"></asp:Label>
                                                            &nbsp;</td>
                                                        <td style="width: 60%; vertical-align: top; text-align: left;">
                                                            <asp:TextBox runat="server" MaxLength="100" Style="width: 90%; height: 30px" ID="txtFieldUnitEdit" ValidationGroup="ValGroupEdit" placeholder="Enter Field Unit"></asp:TextBox>
                                                        </td>
                                                    </tr>
                                                    <tr>
                                                        <td style="width: 40%; vertical-align: top; text-align: right">
                                                            <asp:Label runat="server" ID="lblGlobalEditFieldSpec" Text="Specification " ValidationGroup="ValGroupEdit"></asp:Label>
                                                        </td>
                                                        <td style="width: 60%; vertical-align: top; text-align: left;">
                                                            <asp:TextBox runat="server" MaxLength="100" Style="width: 90%; height: 30px" ID="txtFieldSpecEdit" ValidationGroup="ValGroupEdit" placeholder="Enter Field Specification"></asp:TextBox>
                                                        </td>
                                                    </tr>
                                                    <tr>
                                                        <td style="width: 40%; vertical-align: top; text-align: right">
                                                            <asp:Label runat="server" ID="lblGlobalEditMinVaue" Text="Min Value " ValidationGroup="ValGroupEdit"></asp:Label>
                                                        </td>
                                                        <td style="width: 60%; vertical-align: top; text-align: left;">
                                                            <asp:TextBox runat="server" MaxLength="100" Style="width: 90%; height: 30px" ID="txtMinValueEdit" ValidationGroup="ValGroupEdit" placeholder="Enter Min Value"></asp:TextBox>
                                                        </td>
                                                    </tr>
                                                    <tr>
                                                        <td style="width: 40%; vertical-align: top; text-align: right">
                                                            <asp:Label runat="server" ID="lblGlobalEditMaxvalue" Text="Max Value " ValidationGroup="ValGroupEdit"></asp:Label>
                                                        </td>
                                                        <td style="width: 60%; vertical-align: top; text-align: left;">
                                                            <asp:TextBox runat="server" MaxLength="100" Style="width: 90%; height: 30px" ID="txtMaxValueEdit" ValidationGroup="ValGroupEdit" placeholder="Enter Max Value"></asp:TextBox>
                                                        </td>
                                                    </tr>

                                                    <tr>
                                                        <td colspan="2">
                                                            <asp:Button ID="btnUpdate" runat="server" CausesValidation="True" Text="Update" ValidationGroup="ValGroupEdit" OnClick="btnUpdate_Click" CssClass="btn btn-success" />
                                                            <asp:Button ID="btnCokeDynamicEditCancelPopup" runat="server" Text="Close" OnClick="btnCokeDynamicEditCancelPopup_Click" class="btn btn-danger" />
                                                        </td>
                                                    </tr>
                                                </table>
                                                </div>
                                            </ContentTemplate>
                                            <Triggers>
                                                <asp:AsyncPostBackTrigger ControlID="btnUpdate" EventName="Click" />
                                            </Triggers>
                                        </asp:UpdatePanel>
                                    </div>
                                    <div class="container" style="vertical-align: middle;">
                                    </div>
                                </fieldset>
                            </div>
                            <br />
                        </asp:Panel>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <%--  </div>--%>
</asp:Content>
<asp:Content ID="Content8" ContentPlaceHolderID="AnalyArea3" runat="server">
    <div style="padding: 0px;">
        <div class="row">
            <div class="col-lg-12 col-md-12 col-sm-12 col-xs-12">
                <div runat="server" id="Div2" data-type="anchor">
                    <div style="text-align: center" runat="server">
                        <%--   <div class="rounded_corners" style="width: auto">--%>
                        <asp:Button runat="server" ID="btnModalPopUp" Style="display: none" />
                        <ajaxToolkit:ModalPopupExtender TargetControlID="btnModalPopUp" BackgroundCssClass="modalBackground" PopupControlID="PanelViewForm" OkControlID="lnkOkView" ID="ModalPopupExtenderView" runat="server"></ajaxToolkit:ModalPopupExtender>
                        <asp:Panel ID="PanelViewForm" Visible="true" runat="server" CssClass="ModalWindow" ForeColor="#333333">


                            <div style="text-align: right">
                                <asp:LinkButton ID="lnkOkView" runat="server" />
                            </div>
                            <div style="text-align: center" id="formContentVIEW">
                                <fieldset>

                                    <div>
                                        <asp:UpdatePanel ID="UpdatePanelView" runat="server" UpdateMode="Conditional">
                                            <ContentTemplate>
                                                <div style="background-color: #006DF0; color: white; height: 30px; text-align: center; padding: 5px;">Coke Dynamic View</div>
                                                <table class="table table-bordered" style="width: 100%">
                                                    <tr>
                                                        <td style="width: 50%; vertical-align: top; text-align: right">
                                                            <asp:Label runat="server" ID="lblGlobalCokeType" Text="Coke Type " ValidationGroup="ValGroupView"></asp:Label>
                                                        </td>
                                                        <td style="width: 50%; vertical-align: top; text-align: left">
                                                            <asp:Label runat="server" Style="width: 60%; height: 25px" ID="lblCokeType" ValidationGroup="ValGroupView"></asp:Label>
                                                        </td>
                                                    </tr>
                                                    <tr>

                                                        <td style="width: 50%; vertical-align: top; text-align: right">
                                                            <asp:Label runat="server" ID="lblGlobalCokeSupplier" Text="Coke Supplier " ValidationGroup="ValGroupView"></asp:Label>
                                                        </td>
                                                        <td style="width: 50%; vertical-align: top; text-align: left">
                                                            <asp:Label runat="server" Style="width: 60%; height: 25px" ID="lblCokeSupplier" ValidationGroup="ValGroupView"></asp:Label>
                                                        </td>
                                                    </tr>

                                                    <tr>
                                                        <td style="width: 50%; vertical-align: top; text-align: right">
                                                            <asp:Label runat="server" ID="lblGlobalAnalysisType" Text="Analysis Type " ValidationGroup="ValGroupView"></asp:Label>
                                                        </td>
                                                        <td style="width: 50%; vertical-align: top; text-align: left">
                                                            <asp:Label runat="server" Style="width: 60%; height: 25px" ID="lblAnalysisType" ValidationGroup="ValGroupView"></asp:Label>
                                                        </td>
                                                    </tr>

                                                    <tr>
                                                        <td style="width: 50%; vertical-align: top; text-align: right">
                                                            <asp:Label runat="server" ID="lblGlobalFieldSize" Text="Parameter" ValidationGroup="ValGroupView"></asp:Label>
                                                        </td>
                                                        <td style="width: 50%; vertical-align: top; text-align: left">
                                                            <asp:Label runat="server" Style="width: 60%; height: 25px" ID="lblFieldSize" ValidationGroup="ValGroupView"></asp:Label>
                                                        </td>
                                                    </tr>

                                                    <tr>
                                                        <td style="width: 50%; vertical-align: top; text-align: right">
                                                            <asp:Label runat="server" ID="lblGlobalFieldUnit" Text="UoM " ValidationGroup="ValGroupView"></asp:Label>
                                                        </td>
                                                        <td style="width: 50%; vertical-align: top; text-align: left">
                                                            <asp:Label runat="server" Style="width: 60%; height: 25px" ID="lblFieldUnit" ValidationGroup="ValGroupView"></asp:Label>
                                                        </td>
                                                    </tr>

                                                    <tr>
                                                        <td style="width: 50%; vertical-align: top; text-align: right">
                                                            <asp:Label runat="server" ID="lblGlobalFieldSpec" Text="Specification " ValidationGroup="ValGroupView"></asp:Label>
                                                        </td>
                                                        <td style="width: 50%; vertical-align: top; text-align: left">
                                                            <asp:Label runat="server" Style="width: 60%; height: 25px" ID="lblFieldSpec" ValidationGroup="ValGroupView"></asp:Label>
                                                        </td>
                                                    </tr>

                                                    <tr>
                                                        <td style="width: 50%; vertical-align: top; text-align: right">
                                                            <asp:Label runat="server" ID="lblGlobalMinValue" Text="Min Value " ValidationGroup="ValGroupView"></asp:Label></td>
                                                        <td style="width: 50%; vertical-align: top; text-align: left">
                                                            <asp:Label runat="server" Style="width: 60%; height: 25px" ID="lblMinValue" ValidationGroup="ValGroupView"></asp:Label>
                                                        </td>
                                                    </tr>

                                                    <tr>
                                                        <td style="width: 50%; vertical-align: top; text-align: right">
                                                            <asp:Label ID="lblGlobalMaxValue" runat="server" Text="Max Value " ValidationGroup="ValGroupView"></asp:Label>
                                                        </td>
                                                        <td style="width: 50%; vertical-align: top; text-align: left">
                                                            <asp:Label ID="lblMaxValue" runat="server" Style="width: 60%; height: 25px" ValidationGroup="ValGroupView"></asp:Label>
                                                        </td>
                                                    </tr>
                                                </table>
                                                <div style="vertical-align: middle; width: 100%;">
                                                    <asp:Button ID="btnCokeDynamicViewCancelPopup" runat="server" CssClass="btn btn-danger" ForeColor="White" OnClick="btnCokeDynamicViewCancelPopup_Click" Text="Close" />
                                                </div>
                                            </ContentTemplate>
                                        </asp:UpdatePanel>
                                    </div>
                                </fieldset>
                            </div>
                        </asp:Panel>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <%--    </div>--%>
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















