<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="WebFormUserDetail.aspx.cs" Inherits="WebFormsSchoolApp.User.WebFormUserDetail" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="div-3">
    
<p>
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
    <asp:ValidationSummary ID="ValidationSummary1" runat="server"
        style="color:red" />
<p>
    <asp:Label ID="LabelUserId" runat="server" Text="UserId :" Width="170px"></asp:Label>
    <asp:Label ID="LabelUserIdValue" runat="server" Text="" Width="170px"></asp:Label>
</p>
<p>
   <asp:Label ID="LabelUserName" runat="server" Text="UserName :" Width="170px"></asp:Label>
   <asp:TextBox ID="TextBoxUserName" runat="server" Width="250px"></asp:TextBox>
   <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" Style="color:red"
         ErrorMessage="RequiredFieldValidator"
         ControlToValidate="TextBoxUserName">
         UserName is mandatory </asp:RequiredFieldValidator>
</p>
<p>
   <asp:Label ID="LabelActiveFrom" runat="server" Text="ActiveFrom :" Width="170px"></asp:Label>
   <asp:TextBox ID="TextBoxActiveFrom" runat="server" Width="250px"></asp:TextBox>
   <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" Style="color:red"
         ErrorMessage="RequiredFieldValidator"
         ControlToValidate="TextBoxActiveFrom">
         ActiveFrom is mandatory </asp:RequiredFieldValidator>
</p>
        <p>
   <asp:Label ID="LabelBlocked" runat="server" Text="Blocked :" Width="170px"></asp:Label>
            <asp:CheckBox ID="CheckBoxBlocked" runat="server" />
</p>
   <asp:HiddenField ID="HiddenFieldAction" Value="" runat="server" />
   <a href="WebFormSearchUser.aspx">Go Back to SearchUser</a>
    </div>
</asp:Content>
