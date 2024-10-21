<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="WebFormUserDetail.aspx.cs" Inherits="WebFormsSchoolApp.User.WebFormUserDetail" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <link href="../CustomCss/StyleSheet1.css" rel="stylesheet" /> 
    <div class="div1">
    
<p class="pageTitle">
      <asp:Label ID="LabelTitle" runat="server" Text="UserDetail" Font-Size="20"></asp:Label>
</p>
<p>
    <asp:Button ID="ButtonSave" class="btn btn-success btn-md" Width="70px" runat="server" Text="Save" OnClick="ButtonSave_Click"  />
    <asp:Button ID="ButtonCancel" class="btn btn-danger btn-md" Width="70px"  runat="server" Text="Cancel" CausesValidation="False" OnClick="ButtonCancel_Click"  />
</p>
<p>
    <asp:Label ID="LabelErrorMessage" ForeColor="Red" runat="server" Text=""></asp:Label> 
</p>
<p>
    <asp:ValidationSummary ID="ValidationSummary1" CssClass="customValidationSummary" runat="server" />
<p>
    <asp:Label ID="LabelUserId" runat="server" Text="UserId :" Width="170px"></asp:Label>
    <asp:Label ID="LabelUserIdValue" runat="server" Text="" Width="170px"></asp:Label>
</p>
<p>
   <asp:Label ID="LabelUserName" runat="server" Text="UserName (*) :" Width="170px"></asp:Label>
   <asp:TextBox ID="TextBoxUserName" runat="server" Width="250px"  placeholder="UserName"></asp:TextBox>
   <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server"  Display="None"
         ErrorMessage="UserName is required"
         ControlToValidate="TextBoxUserName">
   </asp:RequiredFieldValidator>
       <asp:RegularExpressionValidator Display = "None" 
      ControlToValidate = "TextBoxUserName" 
      ID="RegularExpressionValidator4" 
      ValidationExpression = "^[\s\S]{0,30}$" 
      runat="server" 
      ErrorMessage="UserName : maximum 30 characters allowed.">
   </asp:RegularExpressionValidator>
</p>
<p>
   <asp:Label ID="LabelActiveFrom" runat="server" Text="ActiveFrom  (*) :" Width="170px"></asp:Label>
   <asp:TextBox ID="TextBoxActiveFrom" runat="server" Width="250px" placeholder="ActiveFrom dd/mm/yyyy"></asp:TextBox>
   <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server"  Display="None"
         ErrorMessage="ActiveFrom is required"
         ControlToValidate="TextBoxActiveFrom">
   </asp:RequiredFieldValidator>
</p>
        <p>
   <asp:Label ID="LabelBlocked" runat="server" Text="Blocked :" Width="170px"></asp:Label>
            <asp:CheckBox ID="CheckBoxBlocked" runat="server" />
</p>
   <asp:HiddenField ID="HiddenFieldAction" Value="" runat="server" />
   <a href="WebFormSearchUser.aspx">Go Back to SearchUser</a>
    </div>
</asp:Content>
