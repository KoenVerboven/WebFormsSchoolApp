<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="WebFormStudentAttendanceRegistration.aspx.cs" Inherits="WebFormsSchoolApp.AttendanceRegistration.WebFormAttendanceRegistration" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <link href="../CustomCss/StyleSheet1.css" rel="stylesheet" />
     <div class="pageTitle">Student Attendance Registration</div>
    <br />
    <p>
     <asp:Label ID="Label1" runat="server" Text="**** Under Construction ****" BackColor="Yellow"></asp:Label>
    </p>
    <br />
    <p>
        <asp:Label ID="Label2" runat="server" Text="Select Class"></asp:Label>
        <asp:DropDownList ID="DropDownListClass" Width="35px" runat="server"></asp:DropDownList>
    </p>
    <p></p>
    <asp:GridView ID="GridView1" runat="server"
         AutoGenerateColumns="false"
         AllowPaging="True"
         PageSize="35"
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
        <HeaderStyle BackColor="#aaaadd" ForeColor="White"></HeaderStyle>
        <FooterStyle BackColor="#aaaadd"></FooterStyle>
  <AlternatingRowStyle BackColor="#eeeeee"></AlternatingRowStyle>

    </asp:GridView>
    <br />
    <br />
    <a href="../default.aspx">Go Back to Mainform</a>
</asp:Content>
