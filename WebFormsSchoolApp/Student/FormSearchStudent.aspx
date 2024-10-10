<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FormSearchStudent.aspx.cs" Inherits="WebFormsSchoolApp.Student.FormSearchStudent" %>
<link href="../StyleSheet1.css" rel="stylesheet" />
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
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
                OnSelectedIndexChanged="GridView1_SelectedIndexChanged" OnPageIndexChanging="GridView1_PageIndexChanging">
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
    </form>
</body>
</html>
