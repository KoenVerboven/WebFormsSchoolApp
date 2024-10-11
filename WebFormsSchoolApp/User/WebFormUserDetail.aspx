<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="WebFormUserDetail.aspx.cs" Inherits="WebFormsSchoolApp.User.WebFormUserDetail" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="div-3">
    <h3>User detail</h3>
    <br />
    <br />
    <p>
        <asp:Label ID="LabelUserId" runat="server" Text="UserId :" Width="170px"></asp:Label>
        <asp:Label ID="LabelUserIdValue" runat="server" Text="" Width="170px"></asp:Label>
    </p>
    </div>
</asp:Content>
