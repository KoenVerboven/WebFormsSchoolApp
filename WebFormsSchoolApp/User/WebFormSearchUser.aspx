<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="WebFormSearchUser.aspx.cs" Inherits="WebFormsSchoolApp.User.WebFormSearchUser" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h3>Search User</h3>
    <br /><br />
    <p>
        <asp:TextBox ID="TextBoxSearch" Width="250px" runat="server"></asp:TextBox>
        <asp:Button ID="ButtonSearch" runat="server" Text="Search" 
            class="btn btn-primary btn-md"
            />
    </p>
    <br />
</asp:Content>
