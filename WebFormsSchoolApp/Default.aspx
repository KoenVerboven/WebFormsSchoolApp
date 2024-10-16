<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebFormsSchoolApp._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <link href="CustomCss/StyleSheet1.css" rel="stylesheet" />
     <div>
     <div class="pageTitle">Home</div>
     <br />
     <br />
     <p>
          <asp:LinkButton ID="LinkButtonSearchStudent" runat="server" 
             OnClick="LinkButton1_Click"
             Height="40"
             Width="200"
             ForeColor="#FFFFFF"
             BackColor="#222288"
             >
             <%--   <asp:Image runat="server" ImageUrl="~/img/payslip.png" Height="18" style="float:left;"/>--%>
             <asp:Label runat="server" Text="Student" style="margin:9px 0px 0px 15px; float:left;"/>
         </asp:LinkButton></p><p>
         <asp:LinkButton ID="LinkButtonSearchTeacher" runat="server" 
            Height="40"
            Width="200"
            ForeColor="#FFFFFF"
            BackColor="#228822" 
            OnClick="LinkButtonSearchTeacher_Click"
            >
            <%--   <asp:Image runat="server" ImageUrl="~/img/payslip.png" Height="18" style="float:left;"/>--%>
            <asp:Label runat="server" Text="Teachter" style="margin:9px 0px 0px 15px; float:left;"/>
         </asp:LinkButton></p><p>
         <asp:LinkButton ID="LinkButtonSearchCourse" runat="server"
             Height="40"
             Width="200"
             ForeColor="#FFFFFF"
             BackColor="#AA2222" 
             OnClick="LinkButtonSearchCourse_Click">
           <%--   <asp:Image runat="server" ImageUrl="~/img/payslip.png" Height="18" style="float:left;"/>--%>
           <asp:Label runat="server" Text="Course" style="margin:9px 0px 0px 15px; float:left;"/>
         </asp:LinkButton></p><p>
         <asp:LinkButton ID="LinkButtonSearchUser" runat="server"
            Height="40"
            Width="200"
            ForeColor="#FFFFFF"
            BackColor="#2222EE" OnClick="LinkButtonSearchUser_Click"
            >
           <%--   <asp:Image runat="server" ImageUrl="~/img/payslip.png" Height="18" style="float:left;"/>--%>
          <asp:Label runat="server" Text="User" style="margin:9px 0px 0px 15px; float:left;"/>
          </asp:LinkButton></p><p> <asp:LinkButton ID="LinkButtonUserRole" runat="server"
              Height="40"
              Width="200"
              ForeColor="#FFFFFF"
              BackColor="#2288FE" OnClick="LinkButtonUserRole_Click"  
              >
          <%--   <asp:Image runat="server" ImageUrl="~/img/payslip.png" Height="18" style="float:left;"/>--%>
          <asp:Label runat="server" Text="UserRole" style="margin:9px 0px 0px 15px; float:left;"/>
          </asp:LinkButton></p><p> <asp:LinkButton ID="LinkButtonAttendanceRegistration" runat="server"
          Height="40"
          Width="200"
          ForeColor="#FFFFFF"
          BackColor="#228888" OnClick="LinkButtonAttendanceRegistration_Click1" 
          >
         <%--   <asp:Image runat="server" ImageUrl="~/img/payslip.png" Height="18" style="float:left;"/>--%>
        <asp:Label runat="server" Text="Attendance" style="margin:9px 0px 0px 15px; float:left;"/>
        </asp:LinkButton></p></div></asp:Content>