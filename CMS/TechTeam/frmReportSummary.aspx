<%@ Page Title="" Language="C#" MasterPageFile="~/AdminSite.Master" AutoEventWireup="true" CodeBehind="frmReportSummary.aspx.cs" Inherits="SCMakingCenterLine.frmReportSummary" %>

<%@ Register assembly="Microsoft.ReportViewer.WebForms, Version=11.0.0.0, Culture=neutral, PublicKeyToken=89845dcd8080cc91" namespace="Microsoft.Reporting.WebForms" tagprefix="rsweb" %>

<asp:Content ID="Content1" ContentPlaceHolderID="Contenthead" runat="server">

     <style type="text/css">
        body
        {
            font-family: Arial;
            font-size: 10pt;
        }
        .Grid td
        {
            background-color: #A1DCF2;
            color: black;
            font-size: 10pt;
            line-height: 200%;
        }
        .Grid th
        {
            background-color: #3AC0F2;
            color: White;
            font-size: 10pt;
            line-height: 200%;
        }
        .ChildGrid td
        {
            background-color: #eee !important;
            color: black;
            font-size: 10pt;
            line-height: 200%;
        }
        .ChildGrid th
        {
            background-color: #6C6C6C !important;
            color: White;
            font-size: 10pt;
            line-height: 200%;
        }
        .Nested_ChildGrid td
        {
            background-color: #fff !important;
            color: black;
            font-size: 10pt;
            line-height: 200%;
        }
        .Nested_ChildGrid th
        {
            background-color: #2B579A !important;
            color: White;
            font-size: 10pt;
            line-height: 200%;
        }
    </style>
    <script type="text/javascript" src="http://ajax.googleapis.com/ajax/libs/jquery/1.8.3/jquery.min.js"></script>
    <script type="text/javascript">
        $(function () {
            $("[id*=imgOrdersShow]").each(function () {
                if ($(this)[0].src.indexOf("minus") != -1) {
                    $(this).closest("tr").after("<tr><td></td><td colspan = '999'>" + $(this).next().html() + "</td></tr>");
                    $(this).next().remove();
                }
            });
            $("[id*=imgProductsShow]").each(function () {
                if ($(this)[0].src.indexOf("minus") != -1) {
                    $(this).closest("tr").after("<tr><td></td><td colspan = '999'>" + $(this).next().html() + "</td></tr>");
                    $(this).next().remove();
                }
            });
        });
    </script>



    <%-- start Header Menu --%>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentLeftMenuHolder" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceTitleleftcorner" runat="server">
      <%-- start Header Menu --%>
      
	 <div> 
  <table id="Table3" cellspacing="0" cellpadding="0" width="100%" border="0"> 
   <tr> 
   <td style="width: 50%"> 
       <h3>Sanitization Report Summary</h3>
   </td> 
   <td> 
   <table id="Table1" cellspacing="0" cellpadding="0" width="100%" border="0">   
       <tr>    
           <td style="height: 13px">  
               &nbsp; 
           </td> 
           <td style="height: 13px" valign="middle" align="center" width="18%"> 
               <img height="18" alt="Add" hspace="5" src="images/icon_add.gif" width="17" align="middle"  border="0" /> 
               <a class="boldlinks" href="frmReportSummary.aspx">Summary report</a> 
           </td>  
           <td style="height: 13px" width="1" bgBoard="#6f6f6f">  
               <img height="1" alt="" src="images/one_pixel.gif" width="1" />  
           </td>  
           <td style="height: 13px" valign="middle" align="center" width="18%">  
               <img height="18" alt="Edit" hspace="5" src="images/icon_edit.gif" width="17" align="middle" />  
               <a class="boldlinks" href="frmReportDetail.aspx">Detail Report</a>  
           </td>  
           <td style="height: 13px" width="1" bgBoard="#6f6f6f">  
               <img height="1" alt="" src="images/one_pixel.gif" width="1" />  
           </td>  
           
       </tr> 
   </table>  
           </td>  
         </tr>   
           </table>  
           </div>
    
    <%-- End	Header Menu --%>
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="ContentHolderSearch" runat="server">
    <asp:Panel ID="PanelSearch" Visible="true" runat="server">
        <fieldset>
            <legend>Search</legend>
            <div>               
	 <asp:UpdatePanel ID="UpdatePanelSearch" runat="server" UpdateMode="Conditional">
         <ContentTemplate>
             <table width="100%">                
                 <tr>

                      <td style="width: 10%; vertical-align:middle; text-align: right">Report Type:                         
                     </td>
                     <td style="width: 20%;vertical-align:middle; text-align: left">
                         <asp:DropDownList runat="server" Style="width: 80%; height: 25px" ID="ddlReportTypeSearch" ValidationGroup="ValGroupSearch">
                              <asp:ListItem Text="--Select--" Value="-1" Selected="True"></asp:ListItem>                           
                              <asp:ListItem Text="SGP125T" Value="SGP125T"></asp:ListItem>
                              <asp:ListItem Text="SGP4T" Value="SGP4T"></asp:ListItem>                              
                         </asp:DropDownList>
                         <div>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" EnableClientScript="true" ValidationGroup="ValGroupSearch" ControlToValidate="ddlReportTypeSearch" InitialValue="-1" ErrorMessage="Required Field!" Display="Dynamic" ForeColor="#FF3300"></asp:RequiredFieldValidator>
                        </div>
                     </td>







                  


                     <td style="width: 10%; vertical-align:middle; text-align: right">From Date:                                   
                                 </td>
                                 <td style="width: 20%; vertical-align:middle; text-align: left">
                                     <asp:TextBox runat="server"  Style="width: 80%; height: 25px" ID="txtFromDateSearch" ValidationGroup="ValGroupSearch" TextMode="Date"></asp:TextBox>
                                           <div>
                                            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" EnableClientScript="true" ValidationGroup="ValGroupSearch" ControlToValidate="txtFromDateSearch" ErrorMessage="Required Field!" Display="Dynamic" ForeColor="#FF3300"></asp:RequiredFieldValidator>
                                        </div>
                                 </td>
                            
                                 <td style="width: 10%; vertical-align:middle; text-align: right">To Date:                                  
                                 </td>
                                 <td style="width: 20%; vertical-align:middle; text-align: left">
                                     <asp:TextBox runat="server"  Style="width: 80%; height: 25px" ID="txtToDateSearch" ValidationGroup="ValGroupSearch" TextMode="Date"></asp:TextBox>
                                   <div>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" EnableClientScript="true" ValidationGroup="ValGroupSearch" ControlToValidate="txtToDateSearch" ErrorMessage="Required Field!" Display="Dynamic" ForeColor="#FF3300"></asp:RequiredFieldValidator>
                        </div>
                                  
                                 </td>
  


                 </tr>
               
               
                 
                 <tr>
                     <td colspan="8" style="text-align:center">
                         <asp:Button ID="btnSearch" Text="Search" runat="server" OnClick="btnSearch_Click" ValidationGroup="ValGroupSearch" Width="121px" Height="25px" />
                     </td>
                   
                 </tr>
             </table>
         </ContentTemplate>
         <Triggers>
             <asp:AsyncPostBackTrigger ControlID="btnSearch" EventName="Click" />            

         </Triggers>
     </asp:UpdatePanel>
            </div>
        </fieldset>
    </asp:Panel>
</asp:Content>
<asp:Content ID="Content5" ContentPlaceHolderID="ContentHolderGrid" runat="server">
    <asp:Panel ID="PanelMain" Visible="true" runat="server">
        <fieldset>
            <legend>FMT12</legend>
            <div style="border: thin dotted #C0C0C0; overflow: scroll; width: 100%;">
                <asp:UpdatePanel ID="UpdatePanelGrid" runat="server" UpdateMode="Conditional">
                    <ContentTemplate>
                        <asp:Label runat="server" ID="lblMsg"></asp:Label>
                        <asp:GridView ID="grdSanitizationReport" runat="server" AutoGenerateColumns="False"
                            DataKeyNames="Id,SanitizationResultId,Area,SanitizationStartDate,SanitizationEndDate" OnRowDataBound="grdSanitizationReport_RowDataBound" 
                            ShowFooter="True"  AllowPaging="True"
                            AllowSorting="True" GridLines="None" OnPageIndexChanging="grdSanitizationReport_PageIndexChanging"  CellPadding="4" ForeColor="#333333" PageSize="50" Font-Size="9pt" OnSelectedIndexChanging="grdSanitizationReport_SelectedIndexChanging">
                            <Columns>         
                                  <asp:TemplateField  HeaderText="Sl.No." ItemStyle-Width="5%">
                                    <ItemTemplate>
                                        <asp:Label ID="lblRowNumber" Text='<%# Container.DataItemIndex + 1 %>' runat="server" />
                                    </ItemTemplate>
                                     <HeaderStyle HorizontalAlign="Center" VerticalAlign="Middle" />
                                     <ItemStyle HorizontalAlign="Center" VerticalAlign="Middle" Width="5%" />
                                </asp:TemplateField>
                                <asp:TemplateField  HeaderText="Report" ItemStyle-Width="5%">
                                    <ItemTemplate>
                                        <asp:LinkButton Text="Print" runat="server" ID="lnlIdView" CausesValidation="false"
                                            CommandName="Select" CommandArgument='<%# Eval("Id")  %>'></asp:LinkButton>
                                    </ItemTemplate>
                                    <HeaderStyle HorizontalAlign="Center" />
                                    <ItemStyle VerticalAlign="Middle" Width="5%" />
                                </asp:TemplateField>                                              
                              
                                 <asp:BoundField DataField="Area" HeaderText="Area" ItemStyle-Width="10%" />
                                

                                     <asp:TemplateField  HeaderText="Sanitization StartTime" ItemStyle-Width="10%">
                                    <ItemTemplate>
                                        <asp:Label ID="lblSanitizationStartDate" runat="server" Text='<%# Eval("SanitizationStartDate")  %>'></asp:Label>
                                    </ItemTemplate>
                                    <ItemStyle Width="10%" />
                                </asp:TemplateField>
                                <asp:TemplateField  HeaderText="Sanitization EndTime" ItemStyle-Width="10%">
                                    <ItemTemplate>
                                        <asp:Label ID="lblSanitizationEndDate" runat="server" Text='<%# Eval("SanitizationEndDate")  %>'></asp:Label>
                                    </ItemTemplate>
                                    <ItemStyle Width="10%" />
                                </asp:TemplateField>



                                 <asp:TemplateField  HeaderText="Temp. StartTime" ItemStyle-Width="10%">
                                    <ItemTemplate>
                                        <asp:Label ID="lblStartDate" runat="server" Text='<%# Eval("StartDate")  %>'></asp:Label>
                                    </ItemTemplate>
                                    <ItemStyle Width="10%" />
                                </asp:TemplateField>
                                <asp:TemplateField  HeaderText="Temp EndTime" ItemStyle-Width="10%">
                                    <ItemTemplate>
                                        <asp:Label ID="lblEndDate" runat="server" Text='<%# Eval("EndDate")  %>'></asp:Label>
                                    </ItemTemplate>
                                    <ItemStyle Width="10%" />
                                </asp:TemplateField>


                                 <asp:BoundField DataField="BeforeBulk" HeaderText="BeforeBulk" ItemStyle-Width="5%" />
                                 <asp:BoundField DataField="BeforeBatchId" HeaderText="BeforeBatchId" ItemStyle-Width="5%" />

                                 <asp:BoundField DataField="AfterBulk" HeaderText="AfterBulk" ItemStyle-Width="5%" />
                                 <asp:BoundField DataField="AfterBatchId" HeaderText="AfterBatchId" ItemStyle-Width="5%" />


                                 <asp:TemplateField  HeaderText="HoldTime (Minute)" ItemStyle-Width="5%">
                                    <ItemTemplate>
                                        <asp:Label ID="lblHoldTimeInMinute" runat="server" Text='<%# Eval("HoldTimeInMinute")  %>'></asp:Label>
                                    </ItemTemplate>
                                    <HeaderStyle HorizontalAlign="Center" VerticalAlign="Middle" />
                                    <ItemStyle HorizontalAlign="Center" VerticalAlign="Middle" Width="5%" />
                                </asp:TemplateField>

                                  <asp:TemplateField  HeaderText="Pass/Fail" ItemStyle-Width="5%">
                                    <ItemTemplate>
                                        <asp:Label ID="lblTagStatus" runat="server" Text=""></asp:Label>
                                    </ItemTemplate>
                                    <HeaderStyle HorizontalAlign="Center" VerticalAlign="Middle" />
                                    <ItemStyle HorizontalAlign="Center" VerticalAlign="Middle" Width="5%" />
                                </asp:TemplateField>

                                 <asp:TemplateField  HeaderText="Status"   ItemStyle-Width="5%">
                                    <ItemTemplate>
                                        <asp:Label ID="lblIsConfirm" runat="server" Text='<%# Eval("IsConfirm")  %>'></asp:Label>
                                    </ItemTemplate>
                                    <HeaderStyle HorizontalAlign="Center" VerticalAlign="Middle" />
                                    <ItemStyle HorizontalAlign="Center" VerticalAlign="Middle" Width="5%" /> 
                                </asp:TemplateField>




<%--                                <asp:BoundField DataField="HoldTimeInMinute" HeaderText="HoldTime (Minute)" ItemStyle-Width="7%" />
                                                               

                                 <asp:TemplateField  HeaderText="Status" ItemStyle-Width="8%">
                                    <ItemTemplate>
                                        <asp:Label ID="lblTagStatus" runat="server" Text=""></asp:Label>
                                    </ItemTemplate>
                                    <HeaderStyle HorizontalAlign="Center" VerticalAlign="Middle" />
                                    <ItemStyle HorizontalAlign="Center" VerticalAlign="Middle" Width="8%" />
                                </asp:TemplateField>--%>
                                
                               
                                   <asp:BoundField DataField="DoneBy" HeaderText="DoneBy" ItemStyle-Width="7%" />
                                   <asp:BoundField DataField="Remarks" HeaderText="Remarks"/>                               
                                                         
                            </Columns>
                            <AlternatingRowStyle BackColor="White" />
                            <EditRowStyle BackColor="#2461BF" />
                            <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                            <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" Height="30px" Font-Size="10pt" HorizontalAlign="Center" VerticalAlign="Middle" />
                            <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
                            <RowStyle BackColor="#EFF3FB" Height="20px" HorizontalAlign="Center" VerticalAlign="Middle" />
                            <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
                            <SortedAscendingCellStyle BackColor="#F5F7FB" />
                            <SortedAscendingHeaderStyle BackColor="#6D95E1" />
                            <SortedDescendingCellStyle BackColor="#E9EBEF" />
                            <SortedDescendingHeaderStyle BackColor="#4870BE" />
                        </asp:GridView>
                    </ContentTemplate>
                    <%--  <Triggers>           
              <asp:PostBackTrigger ControlID="grdSanitizationReport"/>

         </Triggers>--%>
                </asp:UpdatePanel>
            </div>
        </fieldset>
    </asp:Panel>
</asp:Content>
<asp:Content ID="Content6" ContentPlaceHolderID="ContentHolderMain" runat="server">
    
    
<rsweb:ReportViewer ID="rptViewer" runat="server" Width="98%" ProcessingMode="Local" Visible="true" Font-Names="Verdana" Font-Size="9pt" WaitMessageFont-Names="Verdana" WaitMessageFont-Size="14pt">
   <%-- <LocalReport ReportPath="rptSummarywithChart.rdlc"></LocalReport>--%> 
</rsweb:ReportViewer>
    
</asp:Content>
<asp:Content ID="Content7" ContentPlaceHolderID="ContentPlaceHolderMerge" runat="server">
     
</asp:Content>
<asp:Content ID="Content8" ContentPlaceHolderID="ContentPlaceHolderSplit" runat="server">
    
    
   


</asp:Content>





