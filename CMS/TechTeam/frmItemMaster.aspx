<%@ Page Title="" Language="C#" MasterPageFile="~/TechAdmin.Master" AutoEventWireup="true" CodeBehind="frmItemMaster.aspx.cs" Inherits="CMS.TechTeam.frmItemMaster" %>

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
                                        <asp:GridView ID="grdItemMaster" runat="server"
                                            AutoGenerateColumns="False"
                                            CssClass="Grid" PagerStyle-CssClass="GridPager" HeaderStyle-CssClass="Gridheader" RowStyle-CssClass="Gridrows" Width="500px" ShowFooter="True"
                                            AllowPaging="True" AllowSorting="True" DataKeyNames="ItemCode" OnRowDataBound="grdItemMaster_RowDataBound"
                                            OnRowEditing="grdItemMaster_RowEditing" OnRowDeleting="grdItemMaster_RowDeleting" OnPageIndexChanging="grdItemMaster_PageIndexChanging"
                                            OnSelectedIndexChanging="grdItemMaster_SelectedIndexChanging" OnRowCancelingEdit="grdItemMaster_RowCancelingEdit" OnRowUpdating="grdItemMaster_RowUpdating"
                                            OnRowCommand="grdItemMaster_RowCommand" CellPadding="4" PageSize="10" BackColor="White" BorderColor="#3366CC" BorderStyle="None" BorderWidth="1px">
                                            <Columns>
                                                <asp:TemplateField HeaderText="Sl.No." ItemStyle-Width="10%">
                                                    <ItemTemplate>
                                                        <asp:Label ID="lblRowNumber" Text='<%# Container.DataItemIndex + 1 %>' runat="server" />
                                                    </ItemTemplate>
                                                    <ItemStyle Width="10%" />
                                                </asp:TemplateField>
                                                <asp:TemplateField HeaderText="Item ID" ItemStyle-Width="40%">
                                                    <ItemTemplate>
                                                        <asp:Label ID="lblItemID" runat="server" Text='<%# Eval("ItemCode")  %>'></asp:Label>
                                                    </ItemTemplate>
                                                    <HeaderStyle HorizontalAlign="Center" VerticalAlign="Middle"></HeaderStyle>
                                                    <ItemStyle HorizontalAlign="Center" VerticalAlign="Middle" Width="30%"></ItemStyle>
                                                </asp:TemplateField>
                                                <asp:TemplateField HeaderText="Canteen Code	" ItemStyle-Width="40%">
                                                    <ItemTemplate>
                                                        <asp:Label ID="lblCanteenCode" runat="server" Text='<%# Eval("CanteenCode")  %>'></asp:Label>
                                                    </ItemTemplate>
                                                    <HeaderStyle HorizontalAlign="Center" VerticalAlign="Middle"></HeaderStyle>
                                                    <ItemStyle HorizontalAlign="Center" VerticalAlign="Middle" Width="30%"></ItemStyle>
                                                </asp:TemplateField>
                                                <asp:TemplateField HeaderText="Canteen Name	" ItemStyle-Width="40%">
                                                   <EditItemTemplate>
                                                        <asp:DropDownList ID="ddlCanteenName" runat="server" MaxLength="2000" Style="width: 100%; height: 30px;" Text='<%#DataBinder.Eval(Container.DataItem, "CanteenCode") %>'></asp:DropDownList>
                                                    </EditItemTemplate>
                                                    <FooterTemplate>
                                                        <asp:DropDownList ID="ddlNewCanteenName" runat="server" MaxLength="2000" Style="width: 100%; height: 30px"></asp:DropDownList>
                                                    </FooterTemplate>
                                                    <ItemTemplate>
                                                        <asp:Label ID="lblCanteenName" runat="server" Text='<%# Eval("CanteenCode")  %>'></asp:Label>
                                                    </ItemTemplate>
                                                    <HeaderStyle HorizontalAlign="Center" VerticalAlign="Middle"></HeaderStyle>
                                                    <ItemStyle HorizontalAlign="Center" VerticalAlign="Middle" Width="20%"></ItemStyle>
                                                </asp:TemplateField>
                                                <asp:TemplateField HeaderText="Category Group Name" ItemStyle-Width="50%">
                                                    <EditItemTemplate>
                                                        <asp:DropDownList ID="ddlCategoryGroupCode" runat="server" MaxLength="2000" Style="width: 100%; height: 30px;" Text='<%#DataBinder.Eval(Container.DataItem, "CategoryGroupCode") %>'></asp:DropDownList>
                                                    </EditItemTemplate>
                                                    <FooterTemplate>
                                                        <asp:DropDownList ID="ddlNewCategoryGroupCode" runat="server" MaxLength="2000" Style="width: 100%; height: 30px"></asp:DropDownList>
                                                    </FooterTemplate>
                                                    <ItemTemplate>
                                                        <asp:Label ID="lblCategoryGroupCode" runat="server" Text='<%# Eval("CategoryGroupCode")  %>'></asp:Label>
                                                    </ItemTemplate>
                                                    <HeaderStyle HorizontalAlign="Center" VerticalAlign="Middle"></HeaderStyle>
                                                    <ItemStyle HorizontalAlign="Center" VerticalAlign="Middle" Width="20%"></ItemStyle>
                                                </asp:TemplateField>
                                                <asp:TemplateField HeaderText="Item Category Name" ItemStyle-Width="50%">
                                                    <EditItemTemplate>
                                                        <asp:DropDownList ID="ddlCategoryItemCode" runat="server" MaxLength="2000" Style="width: 100%; height: 30px;" Text='<%#DataBinder.Eval(Container.DataItem, "ItemCategoryCode") %>'></asp:DropDownList>
                                                    </EditItemTemplate>
                                                    <FooterTemplate>
                                                        <asp:DropDownList ID="ddlNewCategoryItemCode" runat="server" MaxLength="2000" Style="width: 100%; height: 30px"></asp:DropDownList>
                                                    </FooterTemplate>
                                                    <ItemTemplate>
                                                        <asp:Label ID="lblCategoryItemCode" runat="server" Text='<%# Eval("ItemCategoryCode")  %>'></asp:Label>
                                                    </ItemTemplate>
                                                    <HeaderStyle HorizontalAlign="Center" VerticalAlign="Middle"></HeaderStyle>
                                                    <ItemStyle HorizontalAlign="Center" VerticalAlign="Middle" Width="20%"></ItemStyle>
                                                </asp:TemplateField>
                                                <asp:TemplateField HeaderText="Item Name" ItemStyle-Width="50%">
                                                    <EditItemTemplate>
                                                        <asp:TextBox ID="txtItemNameEdit" runat="server" MaxLength="2000" Style="width: 100%; height: 30px;" Text='<%#DataBinder.Eval(Container.DataItem, "ItemName") %>'></asp:TextBox>
                                                    </EditItemTemplate>
                                                    <FooterTemplate>
                                                        <asp:TextBox ID="txtNewItemName" runat="server" MaxLength="2000" Style="width: 100%; height: 30px"></asp:TextBox>
                                                    </FooterTemplate>
                                                    <ItemTemplate>
                                                        <asp:Label ID="lblItemName" runat="server" Text='<%# Eval("ItemName")  %>'></asp:Label>
                                                    </ItemTemplate>
                                                    <HeaderStyle HorizontalAlign="Center" VerticalAlign="Middle"></HeaderStyle>
                                                    <ItemStyle HorizontalAlign="Center" VerticalAlign="Middle" Width="20%"></ItemStyle>
                                                </asp:TemplateField>
                                                <asp:TemplateField HeaderText="Item Name" ItemStyle-Width="50%">
                                                    <EditItemTemplate>
                                                        <asp:TextBox ID="txtItemEmployeeRateEdit" runat="server" MaxLength="2000" Style="width: 100%; height: 30px;" Text='<%#DataBinder.Eval(Container.DataItem, "ItemEmployeeRate") %>'></asp:TextBox>
                                                    </EditItemTemplate>
                                                    <FooterTemplate>
                                                        <asp:TextBox ID="txtNewItemEmployeeRate" runat="server" MaxLength="2000" Style="width: 100%; height: 30px"></asp:TextBox>
                                                    </FooterTemplate>
                                                    <ItemTemplate>
                                                        <asp:Label ID="lblItemEmployeeRate" runat="server" Text='<%# Eval("ItemEmployeeRate")  %>'></asp:Label>
                                                    </ItemTemplate>
                                                    <HeaderStyle HorizontalAlign="Center" VerticalAlign="Middle"></HeaderStyle>
                                                    <ItemStyle HorizontalAlign="Center" VerticalAlign="Middle" Width="20%"></ItemStyle>
                                                </asp:TemplateField>
                                                <asp:TemplateField HeaderText="Status" ItemStyle-Width="50%">
                                                    <EditItemTemplate>
                                                        <asp:CheckBox ID="ChStatusEdit" runat="server" MaxLength="2000" Style="width: 100%; height: 30px;" Text='<%#DataBinder.Eval(Container.DataItem, "ItemActive") %>'></asp:CheckBox>
                                                    </EditItemTemplate>
                                                    <FooterTemplate>
                                                        <asp:CheckBox ID="ChStatusNew" runat="server" MaxLength="2000" Style="width: 100%; height: 30px"></asp:CheckBox>
                                                    </FooterTemplate>
                                                    <ItemTemplate>
                                                        <asp:Label ID="lblChStatus" runat="server" Text='<%# Eval("ItemActive")  %>'></asp:Label>
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
                                        <asp:AsyncPostBackTrigger ControlID="grdItemMaster" />
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
