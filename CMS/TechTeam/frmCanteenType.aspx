<%@ Page Title="" Language="C#" MasterPageFile="~/TechAdmin.Master" AutoEventWireup="true" CodeBehind="frmCanteenType.aspx.cs" Inherits="CMS.TechTeam.frmCanteenType" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
     
    
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHoldersidebar" runat="server">
    
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolderMenu" runat="server">

    
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="headertitle" runat="server">
   
</asp:Content>
<asp:Content ID="Content5" ContentPlaceHolderID="ContentPlaceHolderSearch" runat="server">
    <div class="row">
        <div class="col-lg-12">
            <div class="card">
                <div class="card-header card-header-primary">
                    <h4 class="card-title ">Canteen Master</h4>
                </div>
                <div class="card-body">
                    <div style="padding: 0px;">
                        <div class="row">
                            <div class="col-lg-12 col-md-12 col-sm-12">
                                <span style="text-align: center; vertical-align: middle; color: #990000; font-size: medium; font-weight: bold;">
        <asp:Label runat="server" ID="lblMsg"></asp:Label></span>
    <asp:UpdatePanel ID="UpdatePanel1" runat="server" UpdateMode="Conditional" ChildrenAsTriggers="false">
        <ContentTemplate>
            <asp:GridView ID="grdCanteenMaster" runat="server"
                AutoGenerateColumns="False"
                CssClass="Grid" PagerStyle-CssClass="GridPager" HeaderStyle-CssClass="Gridheader" RowStyle-CssClass="Gridrows" Width="500px" ShowFooter="True"
                AllowPaging="True" AllowSorting="True" DataKeyNames="Id,CokeTypeId" OnRowDataBound="grdCanteenMaster_RowDataBound"
                OnRowEditing="grdCanteenMaster_RowEditing" OnRowDeleting="grdCanteenMaster_RowDeleting" OnPageIndexChanging="grdCanteenMaster_PageIndexChanging"
                OnSelectedIndexChanging="grdCanteenMaster_SelectedIndexChanging" OnRowCancelingEdit="grdCanteenMaster_RowCancelingEdit" OnRowUpdating="grdCanteenMaster_RowUpdating"
                OnRowCommand="grdCanteenMaster_RowCommand" CellPadding="4" PageSize="10" BackColor="White" BorderColor="#3366CC" BorderStyle="None" BorderWidth="1px">
                <Columns>
                    <asp:TemplateField HeaderText="Sl.No." ItemStyle-Width="10%">
                        <ItemTemplate>
                            <asp:Label ID="lblRowNumber" Text='<%# Container.DataItemIndex + 1 %>' runat="server" />
                        </ItemTemplate>
                        <ItemStyle Width="10%" />
                    </asp:TemplateField>

                    <asp:TemplateField HeaderText="Canteen Name" ItemStyle-Width="40%">
                        <EditItemTemplate>
                            <asp:TextBox ID="txtCanteenTypeNameEdit" runat="server" MaxLength="2000" Style="width: 100%; height: 30px;" Text='<%#DataBinder.Eval(Container.DataItem, "CokeType") %>'></asp:TextBox>
                        </EditItemTemplate>
                        <FooterTemplate>
                            <asp:TextBox ID="txtNewCanteenTypeName" runat="server" MaxLength="2000" Style="width: 100%; height: 30px"></asp:TextBox>
                        </FooterTemplate>
                        <ItemTemplate>
                            <asp:Label ID="lblCanteenTypeName" runat="server" Text='<%# Eval("CokeType")  %>'></asp:Label>
                        </ItemTemplate>
                        <HeaderStyle HorizontalAlign="Center" VerticalAlign="Middle"></HeaderStyle>
                        <ItemStyle HorizontalAlign="Center" VerticalAlign="Middle" Width="30%"></ItemStyle>
                    </asp:TemplateField>



                    <asp:TemplateField HeaderText="Address" ItemStyle-Width="50%">
                        <EditItemTemplate>
                            <asp:CheckBox ID="txtRemarksEdit" runat="server" Style="width: 100%; height: 30px;"></asp:CheckBox>
                        </EditItemTemplate>
                        <FooterTemplate>
                            <asp:CheckBox ID="txtNewRemarks" runat="server" Style="width: 100%; height: 30px"></asp:CheckBox>
                        </FooterTemplate>
                        <ItemTemplate>
                            <asp:Label ID="lblRemarks" runat="server" Text='<%# Eval("Remarks")  %>'></asp:Label>
                        </ItemTemplate>
                        <HeaderStyle HorizontalAlign="Center" VerticalAlign="Middle"></HeaderStyle>
                        <ItemStyle HorizontalAlign="Center" VerticalAlign="Middle" Width="20%"></ItemStyle>
                    </asp:TemplateField>

                    <asp:TemplateField ItemStyle-VerticalAlign="Middle" ItemStyle-HorizontalAlign="Center" HeaderStyle-VerticalAlign="Middle" HeaderStyle-HorizontalAlign="Center" HeaderText="Action" ItemStyle-Width="10%">
                        <ItemTemplate>
                            <asp:ImageButton ID="imgbtnEdit" runat="server" CommandName="Edit" ImageUrl="../Images/select.png" />
                            <asp:ImageButton ID="imgbtnDelete" runat="server" CommandName="Delete" ImageUrl="../Images/delete-img.png" />
                        </ItemTemplate>
                        <EditItemTemplate>
                            <asp:ImageButton ID="imgbtnUpdate" runat="server" CommandName="Update" ImageUrl="../Images/edit-icon1.png" />
                            <asp:ImageButton ID="imgbtnCancel" runat="server" CommandName="Cancel" ImageUrl="../Images/cancel.png" />
                        </EditItemTemplate>
                        <FooterTemplate>
                            <asp:LinkButton ID="lbtnAdd" runat="server" CommandName="ADD" Text="Add" Width="80px"></asp:LinkButton>
                        </FooterTemplate>
                    </asp:TemplateField>
                </Columns>
            </asp:GridView>
        </ContentTemplate>
        <Triggers>
            <asp:AsyncPostBackTrigger ControlID="grdCanteenMaster" />
        </Triggers>
    </asp:UpdatePanel>
                            </div>
                        </div>
                    </div>
                </div>
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