<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="WebFormSchoolClass.aspx.cs" Inherits="WebFormsSchoolApp.SchoolDepartment.WebFormSchoolClass" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <link href="../CustomCss/StyleSheet1.css" rel="stylesheet" />
     <br />
     <br />
<p>
    <asp:Label ID="Label1" runat="server" visible="true" Text="**** Under Construction ****" BackColor="Yellow"></asp:Label>
</p>    
    <p>ClassName :</p>
    <p>ClassCode :</p>
    <p>ClassDescription :</p>
    <asp:Button ID="Button1" runat="server" Text="Add new class" />
</asp:Content>
