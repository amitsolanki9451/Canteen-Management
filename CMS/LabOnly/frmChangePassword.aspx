<%@ Page Title="" Language="C#" MasterPageFile="~/LabAdmin.Master" AutoEventWireup="true" CodeBehind="frmChangePassword.aspx.cs" Inherits="CMS.LabOnly.frmChangePassword" %>
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
    border:1px solid #ccc;
    padding:10px;
    width: 300px;
    height: 30px;
    line-height:30px;
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
    font-weight:bold;
    font-size:14px;
}

}
</style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHoldersidebar" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolderMenu" runat="server">
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="headertitle" runat="server">
     <div class="col-md-10">

        <div>
            <h3><span style="color: #130349; margin-left: 25%;">  Change Password</span></h3>
        </div>
    </div>
</asp:Content>
<asp:Content ID="Content5" ContentPlaceHolderID="ContentPlaceHolderSearch" runat="server">
</asp:Content>
<asp:Content ID="Content6" ContentPlaceHolderID="AnalyArea1" runat="server">
    <asp:UpdateProgress ID="prgLoadingStatus" runat="server" DynamicLayout="true">
    <ProgressTemplate>
        <div id="overlay">
            <div id="modalprogress">
                <div id="theprogress">
                    <asp:Image ID="imgWaitIcon" runat="server" ImageAlign="AbsMiddle" ImageUrl="~/Images/pageloader.gif" Height="78px" Width="124px" />
                    Please wait...
                </div>
            </div>
        </div>
    </ProgressTemplate>
           </asp:UpdateProgress>
    <div>
                 <asp:UpdatePanel ID="UpdatePanelAdd" runat="server" UpdateMode="Conditional">   
        <ContentTemplate> 
   <%--  <asp:Label runat="server" ID="lblMsg"></asp:Label>--%>
   <%-- <table style="width:50%">--%>
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
                        <td style="width: 50%; vertical-align: middle; text-align: right">User Name:</td>
                        <td style="width: 50%; vertical-align: middle; text-align: left">
                            <asp:TextBox runat="server" MaxLength="50" Style="width: 70%;"  CssClass="form-control"  ID="txtUserName" TextMode="Email" ReadOnly="true"></asp:TextBox>
                        <div> 
           <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtUserName" ErrorMessage="Required Field!" Display="Dynamic" ForeColor="#FF3300"></asp:RequiredFieldValidator>
           <ajaxToolkit:FilteredTextBoxExtender ID="FilteredTextBoxExtender3" runat="server" TargetControlID="txtUserName"  ValidChars="@._" FilterType="LowercaseLetters,UppercaseLetters,Numbers,Custom" />
       </div>
                        
                        </td>
                    </tr>
          <tr>
                        <td style="width: 50%; vertical-align: middle; text-align: right">Old password:</td>
                        <td style="width: 50%; vertical-align: middle; text-align: left">
                            <asp:TextBox runat="server" MaxLength="50" Style="width: 70%;"  CssClass="form-control" ID="txtOldPassword" TextMode="Password"></asp:TextBox>
                        
                        <div> 
           <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtOldPassword" ErrorMessage="*" Display="Dynamic" ForeColor="#FF3300"></asp:RequiredFieldValidator>
           <ajaxToolkit:FilteredTextBoxExtender ID="FilteredTextBoxExtender1" runat="server" TargetControlID="txtOldPassword"  ValidChars="@#" FilterType="LowercaseLetters,UppercaseLetters,Numbers,Custom" />
       </div>
                        </td>
                    </tr>
          <tr>
                        <td style="width: 50%; vertical-align: middle; text-align: right">New password:</td>
                        <td style="width: 50%; vertical-align: middle; text-align: left">
                            <asp:TextBox runat="server" MaxLength="50" Style="width: 70%;"  CssClass="form-control" ID="txtNewPassword" TextMode="Password"></asp:TextBox>
                        
                        <div> 
           <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="txtNewPassword" ErrorMessage="*" Display="Dynamic" ForeColor="#FF3300"></asp:RequiredFieldValidator>
           <ajaxToolkit:FilteredTextBoxExtender ID="FilteredTextBoxExtender2" runat="server" TargetControlID="txtNewPassword"  ValidChars="@#" FilterType="LowercaseLetters,UppercaseLetters,Numbers,Custom" />
       </div>
                        </td>
                    </tr>
        <tr>
            
            <td colspan="2" style="vertical-align:middle; text-align:center">  
                 <asp:Button ID="btnChangePassword" runat="server" Text="Change Password" OnClick="btnChangePassword_Click" class="btn btn-success" />        </td>
        </tr>

    </table>
 </div>
                <div class="col-sm-2"></div>
            </div>
        </div>
    </div>
             </ContentTemplate>
        <Triggers>
            <asp:AsyncPostBackTrigger ControlID="btnChangePassword" EventName="Click" />                   
            
        </Triggers>
    </asp:UpdatePanel>
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
