<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="WebFormSearchCourse.aspx.cs" Inherits="WebFormsSchoolApp.Course.WebFormSearchCourse" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="div-3" >
    <h3>Search Course</h3>
     <br /><br />
    <asp:GridView ID="GridView1" runat="server"
        AllowPaging="True"
        PageSize="10"
        ShowFooter="true"
        BackColor="White"
        Height="150px"
        Width="150px"
        BorderColor="black"
        BorderWidth="1"
        GridLines="Both"
        CellPadding="3"
        CellSpacing="0"
        Font-Names="Verdana" OnPageIndexChanging="GridView1_PageIndexChanging" OnSelectedIndexChanged="GridView1_SelectedIndexChanged"
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
