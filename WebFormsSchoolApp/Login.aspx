<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="WebFormsSchoolApp.WebFormLogin" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div>
    <h3>Login</h3>
    <br />
    <br />
    <p>
         <asp:Label ID="LabelUserId" runat="server" Text="UserId :" Width="100px" class="label1" ></asp:Label>
         <asp:TextBox ID="TextBoxId" runat="server" Width="190px"></asp:TextBox>
     </p>
     <p>
         <asp:Label ID="LabelPassword" runat="server" Text="Password :" Width="100px"></asp:Label>
         <asp:TextBox ID="TextBoxPassword" runat="server" Width="190px" TextMode="Password"></asp:TextBox> 
     </p>
     <p>
         <asp:Button ID="ButtonLogin" runat="server" Text="Login" style="height: 35px" Width="90px" 
             class="btn btn-primary btn-md" 
             OnClick="ButtonLogin_Click" />
     </p>
     <p>
         <asp:Label ID="LabelMessage" runat="server" Text=""></asp:Label>
     </p>
</div>
</asp:Content>
