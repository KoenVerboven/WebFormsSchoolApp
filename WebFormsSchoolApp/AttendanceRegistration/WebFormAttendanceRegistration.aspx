<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="WebFormAttendanceRegistration.aspx.cs" Inherits="WebFormsSchoolApp.AttendanceRegistration.WebFormAttendanceRegistration" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <link href="../CustomCss/StyleSheet1.css" rel="stylesheet" />
    <h3>Student Attendance</h3>
    <br />
    <br />
    <asp:GridView ID="GridView1" runat="server"
         AutoGenerateColumns="false"
         AllowPaging="True"
         PageSize="10"
         ShowFooter="true"
         BackColor="White"
         Height="150px"
         Width="90%"
         BorderColor="black"
         BorderWidth="1"
         GridLines="Both"
         CellPadding="3"
         CellSpacing="0"
        >
         <Columns>
             <asp:BoundField DataField="FullName" HeaderText="FullName" SortExpression="FullName" />
             <asp:BoundField DataField="" HeaderText="Present"/>
             <asp:BoundField DataField="" HeaderText="Sick"/>
             <asp:BoundField DataField="" HeaderText="Unlawfully Absent"/>
             <asp:BoundField DataField="" HeaderText="Remarks"/>
         </Columns>
 <HeaderStyle BackColor="#aaaadd"></HeaderStyle>
 <FooterStyle BackColor="#aaaadd"></FooterStyle>
 <AlternatingRowStyle BackColor="#eeeeee"></AlternatingRowStyle>

    </asp:GridView>
    <br />
    <br />
    <a href="../default.aspx">Go Back to Mainform</a>
</asp:Content>
