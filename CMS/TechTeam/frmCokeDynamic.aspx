<%@ Page Title="" Language="C#" MasterPageFile="~/TechAdmin.Master" AutoEventWireup="true" CodeBehind="frmCokeDynamic.aspx.cs" Inherits="CMS.TechTeam.frmCokeDynamic" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .centerHeaderText th {
            text-align: center !important;
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
    <%--<div class="col-md-10">

        <div>
            <h3><span style="color: #130349; margin-left: 25%;"> Coke Dynamic</span></h3>
        </div>
    </div>--%>
   <div>
        <asp:UpdatePanel ID="UpdatePanelCokeDynamicDisplay" runat="server" UpdateMode="Conditional">
            <ContentTemplate>
                <table style="width: 100%">
                    <tr>
                        <td>
                            <div>
                              <h3><span style="color: #130349;"> Coke Dynamic</span></h3>
                                <asp:Label runat="server" ID="lblCokeDynamicDisplay"></asp:Label>
                            </div>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Label runat="server" ID="lblMsg"></asp:Label>
                        </td>
                    </tr>
                </table>

            </ContentTemplate>

        </asp:UpdatePanel>

    </div> 

    
</asp:Content>
<asp:Content ID="Content5" ContentPlaceHolderID="ContentPlaceHolderSearch" runat="server">
    <asp:label id="lblgreater" runat="server"  Text="≥"></asp:label>
     <asp:label id="Label1" runat="server"  Text="≤"></asp:label>
   <table width="100%" cellpadding="3" cellspacing="0" border="0">

        <tr>
            <td>
                <table width="100%" cellpadding="3" cellspacing="0" border="0">
                    <tr>
                        <td style="width: 10%; height: 25px; vertical-align: top; text-align: center">
                            <div class="headings">Coke Supplier</div>
                        </td>
                        <td style="width: 10%; height: 25px; vertical-align: top; text-align: center">
                            <div class="headings">Coke Type</div>
                        </td>

                        <td style="width: 10%; height: 25px; vertical-align: top; text-align: center">
                            <div class="headings">Coke Analysis Type</div>
                        </td>
                        <td style="width: 10%; height: 25px; vertical-align: top; text-align: center">
                            <div class="headings">Parameter</div>
                        </td>
                        <td style="width: 10%; height: 25px; vertical-align: top; text-align: center">
                            <div class="headings">UoM</div>
                        </td>
                        <td style="width: 10%; height: 25px; vertical-align: top; text-align: center">
                            <div class="headings"> Specification</div>
                        </td>
                        <td style="width: 10%; height: 25px; vertical-align: top; text-align: center">
                            <div class="headings">Min Value</div>
                        </td>
                        <td style="width: 10%; height: 25px; vertical-align: top; text-align: center">
                            <div class="headings">Max Value</div>
                        </td>


                    </tr>


                    <tr>
                        <td style="width: 10%; height: 25px; vertical-align: top; text-align: center">
                            <asp:DropDownList runat="server" Style="width: 95%; height: 30px" ID="ddlCokeSupplier"></asp:DropDownList>
                            <div>
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator9" runat="server" EnableClientScript="true" ValidationGroup="ValGroupinsert" ControlToValidate="ddlCokeSupplier" InitialValue="-1" ErrorMessage="*" Display="Dynamic" ForeColor="#FF3300"></asp:RequiredFieldValidator>

                            </div>
                        </td>
                        <td style="width: 10%; height: 25px; vertical-align: top; text-align: center">
                            <asp:DropDownList runat="server" Style="width: 95%; height: 30px" ID="ddlCokeType"></asp:DropDownList>
                            <div>
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator10" runat="server" EnableClientScript="true" ValidationGroup="ValGroupinsert" ControlToValidate="ddlCokeType" InitialValue="-1" ErrorMessage="*" Display="Dynamic" ForeColor="#FF3300"></asp:RequiredFieldValidator>

                            </div>
                        </td>



                        <td style="width: 10%; height: 25px; vertical-align: top; text-align: center">
                            <asp:DropDownList runat="server" Style="width: 95%; height: 30px" ID="ddlAnalysisType"></asp:DropDownList>
                            <div>
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" EnableClientScript="true" ValidationGroup="ValGroupinsert" ControlToValidate="ddlAnalysisType" InitialValue="-1" ErrorMessage="*" Display="Dynamic" ForeColor="#FF3300"></asp:RequiredFieldValidator>

                            </div>
                        </td>



                        <td style="width: 10%; height: 25px; vertical-align: top; text-align: center">
                            <asp:TextBox runat="server" CssClass="form-control" MaxLength="50" Style="width: 95%; height: 30px" ID="txtFieldSize" placeholder="Enter Field Name"></asp:TextBox>
                            <div>
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" EnableClientScript="true" ValidationGroup="ValGroupinsert" ControlToValidate="txtFieldSize" ErrorMessage="*" Display="Dynamic" ForeColor="#FF3300"></asp:RequiredFieldValidator>
                            </div>
                        </td>

                        <td style="width: 10%; height: 25px; vertical-align: top; text-align: center">
                            <asp:TextBox runat="server" CssClass="form-control" MaxLength="50" Style="width: 95%; height: 30px" ID="txtFieldUnit" placeholder="Unit like % ppm etc"></asp:TextBox>
                            <div>
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" EnableClientScript="true" ValidationGroup="ValGroupinsert" ControlToValidate="txtFieldUnit" ErrorMessage="*" Display="Dynamic" ForeColor="#FF3300"></asp:RequiredFieldValidator>
                            </div>
                        </td>



                        <td style="width: 10%; height: 25px; vertical-align: top; text-align: center">
                            <asp:TextBox runat="server" CssClass="form-control" MaxLength="50" Style="width: 95%; height: 30px" ID="txtFieldSpec" placeholder="value like > Or <"></asp:TextBox>
                            <div>
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" EnableClientScript="true" ValidationGroup="ValGroupinsert" ControlToValidate="txtFieldSpec" ErrorMessage="*" Display="Dynamic" ForeColor="#FF3300"></asp:RequiredFieldValidator>
                            </div>
                        </td>

                        <td style="width: 10%; height: 25px; vertical-align: top; text-align: center">
                            <asp:TextBox runat="server" CssClass="form-control" MaxLength="50" Style="width: 95%; height: 30px" ID="txtMinValue" placeholder="Enter Min Value"></asp:TextBox>
                            <div>
                                <ajaxToolkit:FilteredTextBoxExtender ID="FilteredTextBoxExtender5" runat="server" TargetControlID="txtMinValue" ValidChars="." FilterType="Numbers,Custom" />
                           </div>  
                        </td>

                        <td style="width: 10%; height: 25px; vertical-align: top; text-align: center">
                            <asp:TextBox runat="server" CssClass="form-control" MaxLength="50" Style="width: 95%; height: 30px" ID="txtMaxValue" placeholder="Enter Max Value"></asp:TextBox>
                             <div>
                                <ajaxToolkit:FilteredTextBoxExtender ID="FilteredTextBoxExtender1" runat="server" TargetControlID="txtMaxValue" ValidChars="." FilterType="Numbers,Custom" />
                           </div>  

                        </td>



                    </tr>


                </table>
            </td>

        </tr>
        <tr>
            <td><span>
                <hr />
            </span></td>
        </tr>
        <tr>
            <td style="text-align: center; padding-right: 20px">
                <asp:Button ID="btnAdd" Text="Add" runat="server" OnClick="btnAdd_Click" ValidationGroup="ValGroupinsert" CssClass="btn btn-info" />
                 <asp:Button ID="btnNewAdd" Text="New" runat="server" CausesValidation="false" OnClick="btnNewAdd_Click" CssClass="btn btn-info" Visible="False" />
            </td>
            
        </tr>

    </table> 
</asp:Content>
<asp:Content ID="Content6" ContentPlaceHolderID="AnalyArea1" runat="server">
    <div style="padding: 10px;">
        <asp:Panel ID="PanelMain" Visible="true" runat="server">
            <fieldset>
                <div class="g_div">
                    <asp:Label runat="server" ID="lblMsgEdit"></asp:Label>
                    <asp:UpdatePanel ID="UpdatePanelGrid" runat="server" UpdateMode="Conditional">
                        <ContentTemplate>
                            <asp:GridView ID="grdCokeDynamic" runat="server" AutoGenerateColumns="False"  CssClass="Grid" PagerStyle-CssClass="GridPager" HeaderStyle-CssClass="Gridheader" RowStyle-CssClass="Gridrows"
                                DataKeyNames="Id" OnRowDataBound="grdCokeDynamic_RowDataBound"
                                ShowFooter="false" OnRowDeleting="grdCokeDynamic_RowDeleting"  OnPageIndexChanging="grdCokeDynamic_PageIndexChanging" AllowPaging="True" 
                                AllowSorting="True" GridLines="None"  PageSize="100">
                                <Columns>
                                    <asp:TemplateField HeaderText="Sl.No." ItemStyle-Width="5%">
                                        <ItemTemplate>
                                            <asp:Label ID="lblRowNumber" Text='<%# Container.DataItemIndex + 1 %>' runat="server" />
                                        </ItemTemplate>
                                        <HeaderStyle HorizontalAlign="Center" VerticalAlign="Middle" />
                                        <ItemStyle HorizontalAlign="Center" VerticalAlign="Middle" Width="5%" />
                                    </asp:TemplateField>
                                    <asp:TemplateField HeaderText="Coke Type ID" Visible="false" ItemStyle-Width="10%">
                                        <ItemTemplate>
                                            <asp:Label ID="lblCokeTypeID" runat="server" Text='<%# Eval("CokeTypeID")  %>'></asp:Label>
                                        </ItemTemplate>
                                        <HeaderStyle HorizontalAlign="Center" VerticalAlign="Middle" />
                                        <ItemStyle HorizontalAlign="Center" VerticalAlign="Middle" Width="10%" />
                                    </asp:TemplateField>
                                    <asp:TemplateField HeaderText="Coke Type" ItemStyle-Width="10%">
                                        <ItemTemplate>
                                            <asp:Label ID="lblCokeType" runat="server" Text='<%# Eval("CokeType")  %>'></asp:Label>
                                        </ItemTemplate>
                                        <HeaderStyle HorizontalAlign="Center" VerticalAlign="Middle" />
                                        <ItemStyle HorizontalAlign="Center" VerticalAlign="Middle" Width="10%" />
                                    </asp:TemplateField>

                                    <asp:TemplateField HeaderText="SupplierID" Visible="false" ItemStyle-Width="10%">
                                        <ItemTemplate>
                                            <asp:Label ID="lblCokeSupplierID" runat="server" Text='<%# Eval("CokeSupplierID")  %>'></asp:Label>
                                        </ItemTemplate>
                                        <HeaderStyle HorizontalAlign="Center" VerticalAlign="Middle" />
                                        <ItemStyle HorizontalAlign="Center" VerticalAlign="Middle" Width="10%" />
                                    </asp:TemplateField>

                                    <asp:TemplateField HeaderText="Supplier" ItemStyle-Width="10%">
                                        <ItemTemplate>
                                            <asp:Label ID="lblCokeSupplier" runat="server" Text='<%# Eval("CokeSupplier")  %>'></asp:Label>
                                        </ItemTemplate>
                                        <HeaderStyle HorizontalAlign="Center" VerticalAlign="Middle" />
                                        <ItemStyle HorizontalAlign="Center" VerticalAlign="Middle" Width="10%" />
                                    </asp:TemplateField>
                                    <asp:TemplateField HeaderText="Analysis Type ID" Visible="false" ItemStyle-Width="10%">
                                        <ItemTemplate>
                                            <asp:Label ID="lblAnalysisTypeID" runat="server" Text='<%# Eval("AnalysisTypeID")  %>'></asp:Label>
                                        </ItemTemplate>
                                        <HeaderStyle HorizontalAlign="Center" VerticalAlign="Middle" />
                                        <ItemStyle HorizontalAlign="Center" VerticalAlign="Middle" Width="10%" />
                                    </asp:TemplateField>
                                    <asp:TemplateField HeaderText="Analysis Type" ItemStyle-Width="10%">
                                        <ItemTemplate>
                                            <asp:Label ID="lblAnalysisType" runat="server" Text='<%# Eval("AnalysisType")  %>'></asp:Label>
                                        </ItemTemplate>
                                        <HeaderStyle HorizontalAlign="Center" VerticalAlign="Middle" />
                                        <ItemStyle HorizontalAlign="Center" VerticalAlign="Middle" Width="10%" />
                                    </asp:TemplateField>
                                    <asp:TemplateField HeaderText="Parameter" ItemStyle-Width="10%">
                                        <ItemTemplate>
                                            <asp:Label ID="lblFieldSize" runat="server" Text='<%# Eval("FieldSize")  %>'></asp:Label>
                                        </ItemTemplate>
                                        <HeaderStyle HorizontalAlign="Center" VerticalAlign="Middle" />
                                        <ItemStyle HorizontalAlign="Center" VerticalAlign="Middle" Width="10%" />
                                    </asp:TemplateField>
                                    <asp:TemplateField HeaderText="UoM" ItemStyle-Width="10%">
                                        <ItemTemplate>
                                            <asp:Label ID="lblFieldUnit" runat="server" Text='<%# Eval("FieldUnit")  %>'></asp:Label>
                                        </ItemTemplate>
                                        <HeaderStyle HorizontalAlign="Center" VerticalAlign="Middle" />
                                        <ItemStyle HorizontalAlign="Center" VerticalAlign="Middle" Width="10%" />
                                    </asp:TemplateField>
                                    <asp:TemplateField HeaderText="Specification" ItemStyle-Width="5%">
                                        <ItemTemplate>
                                            <asp:Label ID="lblFieldSpec" runat="server" Text='<%# Eval("FieldSpec")  %>'></asp:Label>
                                        </ItemTemplate>
                                        <HeaderStyle HorizontalAlign="Center" VerticalAlign="Middle" />
                                        <ItemStyle HorizontalAlign="Center" VerticalAlign="Middle" Width="5%" />
                                    </asp:TemplateField>
                                    <asp:TemplateField HeaderText="Min Value" ItemStyle-Width="10%">
                                        <ItemTemplate>
                                            <asp:Label ID="lblMinValue" runat="server" Text='<%# Eval("MinValue")  %>'></asp:Label>
                                        </ItemTemplate>
                                        <HeaderStyle HorizontalAlign="Center" VerticalAlign="Middle" />
                                        <ItemStyle HorizontalAlign="Center" VerticalAlign="Middle" Width="10%" />
                                    </asp:TemplateField>
                                    <asp:TemplateField HeaderText="Max Value" ItemStyle-Width="10%">
                                        <ItemTemplate>
                                            <asp:Label ID="lblMaxValue" runat="server" Text='<%# Eval("MaxValue")  %>'></asp:Label>
                                        </ItemTemplate>
                                        <HeaderStyle HorizontalAlign="Center" VerticalAlign="Middle" />
                                        <ItemStyle HorizontalAlign="Center" VerticalAlign="Middle" Width="10%" />
                                    </asp:TemplateField>

                                </Columns>
                                
                            </asp:GridView>

                        </ContentTemplate>
                    </asp:UpdatePanel>
                </div>
                <br />
                <asp:UpdatePanel ID="UpdatePanelSave" runat="server" UpdateMode="Conditional">
                    <ContentTemplate>
                        <table style="width: 100%; vertical-align: middle;">

                            <tr>
                                <td style="text-align: right; padding-right: 20px">
                                    <asp:Button ID="btnSubmit" runat="server" Text="Save Record" CssClass="btn btn-info" OnClick="btnSubmit_Click" />
                                        <%--OnClientClick="javascript: return confirm(&quot;Record Save Sucessfully?&quot;);"/>--%>
                                </td>
                            </tr>
                        </table>
                    </ContentTemplate>
                </asp:UpdatePanel>


            </fieldset>


        </asp:Panel>



    </div>
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