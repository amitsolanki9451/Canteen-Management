<%@ Page Title="" Language="C#" MasterPageFile="~/TechAdmin.Master" AutoEventWireup="true" CodeBehind="frmCokeDynamicResult.aspx.cs" Inherits="CMS.TechTeam.frmCokeDynamicResult" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHoldersidebar" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolderMenu" runat="server">
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="headertitle" runat="server">
        <asp:Label runat="server" ID="lblMsg"></asp:Label>
    <table style="width: 100%">
        <tr>
            <td style="width: 20%; vertical-align: top; text-align: right" class="auto-style4">Coke Type:</td>
            <td style="width: 30%; vertical-align: top; text-align: left">
                &nbsp;<asp:DropDownList runat="server" ID="ddlCokeType" AutoPostBack="True"  Height="31px" Width="201px"></asp:DropDownList>
                <div>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="ddlCokeType"  InitialValue="-1"
                    ErrorMessage="Please Select!" Display="Dynamic" ForeColor="#FF3300"></asp:RequiredFieldValidator>
                    </div>
            </td>
            <td style="width: 20%;vertical-align: top; text-align: right" class="auto-style5">Supplier Name:</td>
            <td style="width: 30%; vertical-align: top; text-align: left">
                <asp:DropDownList runat="server" ID="ddlCokeSupplierName" Height="31px" Width="284px">
                    <asp:ListItem Text="-- Select --" Value="-1" Selected="True"></asp:ListItem>
                </asp:DropDownList>
                <div>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="ddlCokeSupplierName"  InitialValue="-1"
                    ErrorMessage="Please Select!" Display="Dynamic" ForeColor="#FF3300"></asp:RequiredFieldValidator>
                    </div>
            </td>
              <td style="width: 20%;vertical-align: top; text-align: right" class="auto-style5">Analysis Type:</td>
            <td style="width: 30%; vertical-align: top; text-align: left">
                <asp:DropDownList runat="server" ID="ddlAnalysisType" Height="31px" Width="284px">
                    <asp:ListItem Text="-- Select --" Value="-1" Selected="True"></asp:ListItem>
                </asp:DropDownList>
                <div>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="ddlAnalysisType"  InitialValue="-1"
                    ErrorMessage="Please Select!" Display="Dynamic" ForeColor="#FF3300"></asp:RequiredFieldValidator>
                    </div>
            </td>
           
        </tr>
        <tr>
                        <td  colspan="4"style ="width :100%">
                            <table style="width:100%">
                                 <tr>
                        <td style="width:100%">
                       
                        <div style="border: thin dotted #C0C0C0; overflow: scroll; width: 100%;">
                    <asp:GridView ID="grdCokeDynamicResult" runat="server" AutoGenerateColumns="False" Width="100%"
                        DataKeyNames="Id,CokeDynamicResultId" OnRowDataBound="grdCokeDynamicResult_RowDataBound" OnRowEditing="grdCokeDynamicResult_RowEditing"
                        ShowFooter="True" AllowPaging="True"
                        AllowSorting="True" GridLines="None" OnPageIndexChanging="grdCokeDynamicResult_PageIndexChanging" CellPadding="4" ForeColor="#333333" PageSize="50">
                        <Columns>
                            <asp:TemplateField  HeaderText="Sl.No." ItemStyle-Width="5%">
                                <ItemTemplate>
                                    <asp:Label ID="lblRowNumber" Text='<%# Container.DataItemIndex + 1 %>' runat="server" />
                                </ItemTemplate>
                                  <HeaderStyle HorizontalAlign="Center" VerticalAlign="Middle"></HeaderStyle>
                                <ItemStyle HorizontalAlign="Center" VerticalAlign="Middle" Width="5%"></ItemStyle>
                            </asp:TemplateField>

                             <asp:TemplateField  HeaderText="Result Id" ItemStyle-Width="45%" Visible="false">
                                <ItemTemplate>
                                    <asp:Label ID="lblCokeDynamicId" runat="server"  Width="90%" Text='<%# Eval("CokeDynamicId")  %>'></asp:Label>
                                </ItemTemplate>
                                <HeaderStyle HorizontalAlign="Center" VerticalAlign="Middle"></HeaderStyle>
                                <ItemStyle HorizontalAlign="Center" VerticalAlign="Middle" Width="45%"></ItemStyle>
                            </asp:TemplateField>

                            <asp:TemplateField  HeaderText="Result" ItemStyle-Width="45%">
                                <ItemTemplate>
                                    <asp:Label ID="lblCokeDynamic" runat="server"  Width="90%" Text='<%# Eval("CokeDynamic")  %>'></asp:Label>
                                </ItemTemplate>
                                <HeaderStyle HorizontalAlign="Center" VerticalAlign="Middle"></HeaderStyle>
                                <ItemStyle HorizontalAlign="Center" VerticalAlign="Middle" Width="45%"></ItemStyle>
                            </asp:TemplateField>

                           

                          

                            <asp:TemplateField  HeaderText="Field Size" ItemStyle-Width="10%">
                                <ItemTemplate>
                                    <asp:label ID="lblFieldSize" runat= "server" Height="25px" Width="90%" Text='<%# Eval("FieldSize")  %>'></asp:label>
                                </ItemTemplate>
                                <HeaderStyle HorizontalAlign="Center" VerticalAlign="Middle"></HeaderStyle>
                                <ItemStyle HorizontalAlign="Center" VerticalAlign="Middle" Width="10%"></ItemStyle>
                            </asp:TemplateField>

                           <asp:TemplateField  HeaderText="Field Unit" ItemStyle-Width="10%">
                                <ItemTemplate>
                                    <asp:label ID="lblFieldUnit" runat= "server" Height="25px" Width="90%" Text='<%# Eval("FieldUnit")  %>'></asp:label>
                                </ItemTemplate>
                                <HeaderStyle HorizontalAlign="Center" VerticalAlign="Middle"></HeaderStyle>
                                <ItemStyle HorizontalAlign="Center" VerticalAlign="Middle" Width="10%"></ItemStyle>
                            </asp:TemplateField>

                                <asp:TemplateField  HeaderText="Field Specification" ItemStyle-Width="10%">
                                <ItemTemplate>
                                    <asp:label ID="lblFieldSpec" runat= "server" Height="25px" Width="90%" Text='<%# Eval("FieldSpec")  %>'></asp:label>
                                </ItemTemplate>
                                <HeaderStyle HorizontalAlign="Center" VerticalAlign="Middle"></HeaderStyle>
                                <ItemStyle HorizontalAlign="Center" VerticalAlign="Middle" Width="10%"></ItemStyle>
                            </asp:TemplateField>

                              <asp:TemplateField  HeaderText="Min Value" ItemStyle-Width="10%">
                                <ItemTemplate>
                                    <asp:label ID="lblMinValue" runat= "server" Height="25px" Width="90%" Text='<%# Eval("MinValue")  %>'></asp:label>
                                </ItemTemplate>
                                <HeaderStyle HorizontalAlign="Center" VerticalAlign="Middle"></HeaderStyle>
                                <ItemStyle HorizontalAlign="Center" VerticalAlign="Middle" Width="10%"></ItemStyle>
                            </asp:TemplateField>

                                <asp:TemplateField  HeaderText="Max Value" ItemStyle-Width="10%">
                                <ItemTemplate>
                                    <asp:label ID="lblMaxValue" runat= "server" Height="25px" Width="90%" Text='<%# Eval("MaxValue")  %>'></asp:label>
                                </ItemTemplate>
                                <HeaderStyle HorizontalAlign="Center" VerticalAlign="Middle"></HeaderStyle>
                                <ItemStyle HorizontalAlign="Center" VerticalAlign="Middle" Width="10%"></ItemStyle>
                            </asp:TemplateField>

                           <%-- Text='<%# Eval("CokeDynamicResult")--%>

                            <asp:TemplateField  HeaderText="Result" ItemStyle-Width="10%">            
                                <ItemTemplate>
                                    <asp:TextBox ID="txtCokeDynamicResult" runat="server" Height="25px" Width="90%"></asp:TextBox>
                                </ItemTemplate>
                                <HeaderStyle HorizontalAlign="Center" VerticalAlign="Middle"></HeaderStyle>
                                <ItemStyle HorizontalAlign="Center" VerticalAlign="Middle" Width="10%"></ItemStyle>
                            </asp:TemplateField>
                        </Columns>
                        <AlternatingRowStyle BackColor="White" />
                        <EditRowStyle BackColor="#2461BF" />
                        <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                        <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                        <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
                        <RowStyle BackColor="#EFF3FB" />
                        <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
                        <SortedAscendingCellStyle BackColor="#F5F7FB" />
                        <SortedAscendingHeaderStyle BackColor="#6D95E1" />
                        <SortedDescendingCellStyle BackColor="#E9EBEF" />
                        <SortedDescendingHeaderStyle BackColor="#4870BE" />
                    </asp:GridView>
                </div>
                            
                        </td>
                    </tr>
                                 </table>
                              </td>   
                    </tr>
          <tr>
            <td class="auto-style2"></td>
            <td class="auto-style1">&nbsp;</td>
            <td class="auto-style1">&nbsp;</td>
            <td class="auto-style3">&nbsp;</td>
            <td class="auto-style4">
                <asp:Literal ID="l1" runat="server"></asp:Literal></td>
            <td class="auto-style5"></td>
        </tr>
        <tr>
            <td colspan="2">
                <table style="width: 100%">
                    <tr>
                         <td style="text-align: right; padding-right: 20px">
                             <asp:Button ID="btnSave" Text="Save" runat="server" OnClick="btnSave_Click" Width="121px" Height="25px" />
                        </td>
                        <td style="text-align: left; padding-left: 20px;">
                            <asp:Button ID="btnCancel" Text="Cancel" runat="server" OnClick="btnCancel_Click" Width="121px" Height="25px" />
                        </td>
                    </tr>
                </table>
            </td>
        </tr>
         
             
    </table>
</asp:Content>
<asp:Content ID="Content5" ContentPlaceHolderID="ContentPlaceHolderSearch" runat="server">
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