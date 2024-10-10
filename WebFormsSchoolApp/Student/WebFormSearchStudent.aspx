<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="WebFormSearchStudent.aspx.cs" Inherits="WebFormsSchoolApp.Student.WebFormSearchStudent" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="div-3">
    <h3>Search Student</h3>
    <br /><br />
    <asp:GridView ID="GridView1" runat="server"
        AllowPaging="True"
        PageSize="10"
        ShowFooter="true"
        BackColor="White"
        Height="150px"
        Width="450px"
        BorderColor="black"
        BorderWidth="1"
        GridLines="Both"
        CellPadding="3"
        CellSpacing="0"
        Font-Names="Verdana"
        >
        <Columns>
            <asp:CommandField ShowSelectButton="True" />
        </Columns>
        <HeaderStyle BackColor="#aaaadd"></HeaderStyle>
        <FooterStyle BackColor="#aaaadd"></FooterStyle>
        <AlternatingRowStyle BackColor="#eeeeee"></AlternatingRowStyle>
    </asp:GridView>
    <br />
    <br />
    <a href="../MainForm.aspx">Go Back to Mainform</a>
</div>


</asp:Content>
