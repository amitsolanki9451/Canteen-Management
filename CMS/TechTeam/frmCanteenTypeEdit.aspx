<%@ Page Title="" Language="C#" MasterPageFile="~/TechAdmin.Master" AutoEventWireup="true" CodeBehind="frmCanteenTypeEdit.aspx.cs" Inherits="CMS.TechTeam.frmCanteenTypeEdit" %>
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
            width: 90%;
            max-width: 500px;
            position: relative;
            margin: 0 auto;
            -webkit-box-shadow: 0 30px 60px 0 rgba(0,0,0,0.3);
            box-shadow: 0 30px 60px 0 rgba(0,0,0,0.3);
            text-align: center;
            /*text-align: center;*/
        }

        #formContentVIEW {
            -webkit-border-radius: 10px 10px 10px 10px;
            border-radius: 10px 10px 10px 10px;
            background: #fff;
            padding: 10px;
            width: 100%;
            max-width: 500px;
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
        <li class="nav-item"><a href="frmCanteenType.aspx" class="nav-link">Add Canteen Name</a>
        </li>
        <li class="nav-item"><a href="frmCanteenTypeEdit.aspx" class="nav-link">View Canteen Name </a>
        </li>        
    </ul>
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="headertitle" runat="server">
     <div class="col-md-12">
        <div>
            <h3><span style="color: #130349; margin-top: 20%">Canteen Name View</span></h3>
        </div>
    </div>  
</asp:Content>
<asp:Content ID="Content5" ContentPlaceHolderID="ContentPlaceHolderSearch" runat="server">
     <div style="padding: 0px;">
        <div class="row">
           <div class="col-lg-2 col-md-2 col-sm-2">
               </div>
            <div class="col-lg-8 col-md-8 col-sm-8">
                <%--<div class="rounded_corners" style="width: auto;">--%>

                    <asp:UpdatePanel ID="UpdatePanelSearch" runat="server" UpdateMode="Conditional">
                        <ContentTemplate>
                                         <table style="width: 100%">
                                           <tr style="padding:5px">
                                                <td style="width: 10%; vertical-align: top; text-align: right;padding:5px;"> Canteen Name </td>                           
                                                  <td style="width: 20%; vertical-align: top; text-align:left;padding:5px;">
                                                    <asp:TextBox runat="server" Style="width: 100%; height: 30px" ID="txtCokeTypeSearch" ValidationGroup="ValGroupSearch"></asp:TextBox>
                                                </td>
                                               <td style="width: 10%; vertical-align: top; text-align: left;padding:5px;">
                                                    <asp:Button ID="btnSearch" Text="Search" runat="server" OnClick="btnSearch_Click" ValidationGroup="ValGroupSearch" Width="131px" Height="31px" CssClass="btn btn-info" />
                                                </td>
                                            </tr>
                                        </table>
                                   </ContentTemplate>
                        <Triggers>
                            
                            <asp:AsyncPostBackTrigger ControlID="btnSearch" EventName="Click" />
                        </Triggers>
                    </asp:UpdatePanel>

                <%--</div>--%>
            </div>
            <div class="col-lg-2 col-md-2 col-sm-2">

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
                                  <span style="color:#b60f0f; font-size:18px; font-weight:bold;">   <asp:Label runat="server" ID="lblMsg"></asp:Label> </span>
                            <asp:GridView ID="grdCokeType" runat="server" AutoGenerateColumns="False" CssClass="Grid" PagerStyle-CssClass="GridPager" HeaderStyle-CssClass="Gridheader" RowStyle-CssClass="Gridrows"
                                DataKeyNames="Id,CokeTypeId" OnRowDataBound="grdCokeType_RowDataBound" OnRowEditing="grdCokeType_RowEditing"
                                ShowFooter="false" OnRowDeleting="grdCokeType_RowDeleting" AllowPaging="True"  pagesize="100"
                                AllowSorting="True" GridLines="None" OnPageIndexChanging="grdCokeType_PageIndexChanging" OnSelectedIndexChanging="grdCokeType_SelectedIndexChanging">
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
                                                    <asp:ImageButton ID="imgDelete" ToolTip="delete" runat="server" AlternateText="delete"
                                                        BorderWidth="0" CausesValidation="false" CommandArgument='<%# Eval("Id")  %>'
                                                        CommandName="Delete" ImageUrl="../Images/delete-img.png" OnClientClick="javascript: return confirm(&quot;Are you sure you want to delete this item?&quot;);" />
                                                </ItemTemplate>
                                                <HeaderStyle HorizontalAlign="Center" />
                                                <ItemStyle VerticalAlign="Middle" Width="5%" />
                                            </asp:TemplateField>
                                    <asp:TemplateField HeaderText="Canteen Name" ItemStyle-Width="40%">
                                        <ItemTemplate>
                                            <asp:Label ID="lblCokeType" runat="server" Text='<%# Eval("CokeType")  %>'></asp:Label>
                                        </ItemTemplate>
                                        <HeaderStyle HorizontalAlign="Center" VerticalAlign="Middle" />
                                        <ItemStyle HorizontalAlign="Center" VerticalAlign="Middle" Width="40%" />
                                    </asp:TemplateField>
                                    <asp:TemplateField HeaderText="Address" ItemStyle-Width="40%">
                                        <ItemTemplate>
                                            <asp:Label ID="lblRemarks" runat="server" Text='<%# Eval("Remarks")  %>'></asp:Label>
                                        </ItemTemplate>
                                        <HeaderStyle HorizontalAlign="Center" VerticalAlign="Middle" />
                                        <ItemStyle HorizontalAlign="Center" VerticalAlign="Middle" Width="40%" />
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
                     <%--   <div class="rounded_corners" style="width: auto">--%>
  

                <asp:Button runat="server" ID="btnModalEditPopUp" Style="display: none" />
                <ajaxToolkit:ModalPopupExtender TargetControlID="btnModalEditPopUp" BackgroundCssClass="modalBackground" PopupControlID="PanelEdit" OkControlID="lnkOkEdit" ID="ModalPopupExtenderEdit" runat="server" />
                <asp:Panel ID="PanelEdit" Visible="true" runat="server" CssClass="ModalWindow"   ForeColor="#333333">


                    <div style="text-align: right">
                        <asp:LinkButton ID="lnkOkEdit" runat="server"/>
                    </div>
                    <div style="text-align: center" id="formContentEDIT">
                        <fieldset>
                           

                            <asp:UpdatePanel ID="UpdatePanelEdit" runat="server" UpdateMode="Conditional">
                                <ContentTemplate>
                                  <span style="color:#b60f0f; font-size:18px; font-weight:bold;">   <asp:Label runat="server" ID="lblMsgEdit"></asp:Label> </span>
                                  
                                        <div style="background-color: #006DF0; color: white; height: 30px; text-align: center; padding: 5px;">Canteen Name Edit</div>
                                        <table class="table table-bordered" style="width: 100%">

                                            <tr>
                                                <td style="vertical-align: top; text-align: right">Canteen Name </td>
                                                <td style="vertical-align: top; text-align: left">
                                                    <asp:TextBox runat="server" Style="height: 30px; width:100%;" ID="txtCokeTypeEdit" ValidationGroup="ValGroupEdit"></asp:TextBox>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td style="vertical-align: top; text-align: right">Address </td>
                                                <td style="vertical-align: top; text-align: left">
                                                    <asp:TextBox runat="server" MaxLength="50" Style="height: 30px; width:100%;" ID="txtRemarksEdit" ValidationGroup="ValGroupEdit" TextMode="MultiLine"></asp:TextBox>
                                                </td>
                                            </tr>

                                            <tr>
                                                <td colspan="2" style="text-align: center; vertical-align: middle">
                                                    <asp:Button ID="btnUpdate" runat="server" CausesValidation="True" Text="Update" ValidationGroup="ValGroupEdit" OnClick="btnUpdate_Click" class="btn btn-success" />
                                                    <asp:Button ID="btnCokeTypeEditCancelPopup" runat="server" Text="Close" OnClick="btnCokeTypeEditCancelPopup_Click" class="btn btn-danger" />
                                                </td>
                                            </tr>
                                        </table>
                                    
                                </ContentTemplate>
                                <Triggers>
                                    <asp:AsyncPostBackTrigger ControlID="btnUpdate" EventName="Click" />
                                    <asp:AsyncPostBackTrigger ControlID="btnCokeTypeEditCancelPopup" EventName="Click" />
                                </Triggers>
                            </asp:UpdatePanel>
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
   <%-- </div>--%>
</asp:Content>
<asp:Content ID="Content8" ContentPlaceHolderID="AnalyArea3" runat="server">
     <div style="padding: 0px;">
        <div class="row">
            <div class="col-lg-12 col-md-12 col-sm-12 col-xs-12">
                <div runat="server" id="Div2" data-type="anchor">
                    <div style="text-align: center" runat="server">
                   <%--     <div class="rounded_corners" style="width: auto">--%>
                <asp:Button runat="server" ID="btnModalPopUp" Style="display: none" />
                <ajaxToolkit:ModalPopupExtender TargetControlID="btnModalPopUp" BackgroundCssClass="modalBackground" PopupControlID="PanelViewForm" OkControlID="lnkOkView" ID="ModalPopupExtenderView" runat="server"></ajaxToolkit:ModalPopupExtender>
                <asp:Panel ID="PanelViewForm" Visible="true" runat="server" CssClass="ModalWindow" ForeColor="#333333">

                    <div style="text-align: right">
                        <asp:LinkButton ID="lnkOkView" runat="server"  />
                    </div>
                    <div style="text-align: center" id="formContentVIEW">
                        <fieldset>
                            <div>
                                <asp:UpdatePanel ID="UpdatePanelView" runat="server" UpdateMode="Conditional">
                                    <ContentTemplate>
                                        <div style="background-color: #006DF0; color: white; height: 30px; text-align: center; padding: 5px;">Canteen Name View</div>
                                        <table class="table table-bordered" style="width: 100%">
                                            <tr>
                                                <td style="width: 30%; vertical-align: top; text-align: right">Canteen Name </td>
                                                <td style="width: 70%; vertical-align: top; text-align: left">
                                                    <asp:Label runat="server" Style="width: 100%; height: 30px" ID="lblCokeType" ValidationGroup="ValGroupView"></asp:Label>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td style="width: 30%; vertical-align: top; text-align: right">Address </td>
                                                <td style="width: 70%; vertical-align: top; text-align: left">
                                                    <asp:Label runat="server" Style="width: 100%; height: 30px" ID="lblRemarks" ValidationGroup="ValGroupView"></asp:Label>
                                                </td>
                                            </tr>
                                        </table>
                                         <div style="vertical-align: middle; width:500px;">
                                     <asp:Button ID="btnCokeTypeViewCancelPopup" runat="server" CssClass="btn btn-danger" ForeColor="White" OnClick="btnCokeTypeViewCancelPopup_Click" Text="Close" />
                                </div>
                                    </ContentTemplate>
                                    <Triggers>
                                        <asp:AsyncPostBackTrigger ControlID="btnCokeTypeViewCancelPopup" EventName="Click" />
                                    </Triggers>
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
   <%-- </div>--%>
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