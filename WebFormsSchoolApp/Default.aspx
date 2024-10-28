<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebFormsSchoolApp._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <link href="CustomCss/StyleSheet1.css" rel="stylesheet" />
     <div class="div1">
     <div class="pageTitle">Home</div>
     <br />
     <div class="row">

     <div class="col-md-4">
          <%--Student start--%>
            <p> <asp:LinkButton ID="LinkButtonStudent" runat="server" 
                OnClick="LinkButton1_Click"
                Height="80"
                Width="200"
                ForeColor="#FFFFFF"
                BackColor="#779498"
                Visible="false"
                >
                <%--   <asp:Image runat="server" ImageUrl="~/img/payslip.png" Height="18" style="float:left;"/>--%>
                <asp:Label ID="LabelStudent" runat="server" Text="Student" style="margin:9px 0px 0px 15px; float:left;"/>
            </asp:LinkButton></p><%--Student end--%><%--Teacher start--%><p><asp:LinkButton ID="LinkButtonTeacher" runat="server" 
               Height="80"
               Width="200"
               ForeColor="#FFFFFF"
               BackColor="#228822" 
               Visible="false"
               OnClick="LinkButtonSearchTeacher_Click"
               >
               <asp:Label ID="LabelTeacher"  runat="server" Text="Teachter" style="margin:9px 0px 0px 15px; float:left;"/>
            </asp:LinkButton></p><%--Teacher end--%><%--SchoolClass start--%><p> <asp:LinkButton ID="LinkButtonSchoolClass" runat="server"
              Height="80"
              Width="200"
              ForeColor="#FFFFFF"
              BackColor="#E75573" 
              Visible="false"
                OnClick="LinkButton1_Click1"  
              >
             <%--   <asp:Image runat="server" ImageUrl="~/img/payslip.png" Height="18" style="float:left;"/>--%>
            <asp:Label ID="LabelSchoolClass" runat="server" Text="SchoolClass" style="margin:9px 0px 0px 15px; float:left;"/>
              <asp:Label runat="server" Text="Administration" style="margin:9px 0px 0px 15px; float:left;"/>
            </asp:LinkButton></p><%-- SchoolClass end --%></div><div class="col-md-4">
         <%--Course start--%><p><asp:LinkButton ID="LinkButtonCourse" runat="server"
                Height="80"
                Width="200"
                ForeColor="#FFFFFF"
                BackColor="#AA2222" 
                Visible="false"
                OnClick="LinkButtonSearchCourse_Click">
              <asp:Label ID="LabelCourse" runat="server" Text="Course" style="margin:9px 0px 0px 15px; float:left;"/>
            </asp:LinkButton></p><%--Course end--%><%--User start--%><p><asp:LinkButton ID="LinkButtonUser" runat="server"
               Height="80"
               Width="200"
               ForeColor="#FFFFFF"
               BackColor="#2222EE" 
               Visible="false"
                OnClick="LinkButtonSearchUser_Click"
               >
             <asp:Label ID="LabelUser" runat  ="server" Text="User" style="margin:9px 0px 0px 15px; float:left;"/>
             </asp:LinkButton></p><%--User end--%><%--ExamenPoints start--%><p> <asp:LinkButton ID="LinkButtonExamenPoints" runat="server"
              Height="80"
              Width="200"
              ForeColor="#FFFFFF"
              BackColor="#A46FFF"
              Visible="false"
                 OnClick="LinkButtonExamenPoints_Click" 
              >
             <%--   <asp:Image runat="server" ImageUrl="~/img/payslip.png" Height="18" style="float:left;"/>--%>
            <asp:Label runat="server" Text="ExamenPoints" style="margin:9px 0px 0px 15px; float:left;"/>
            </asp:LinkButton></p><%-- ExamenPoints end --%></div><div class="col-md-4">
                      <%--UserRole start--%><p> <asp:LinkButton ID="LinkButtonUserRole" runat="server"
                  Height="80"
                  Width="200"
                  ForeColor="#FFFFFF"
                  BackColor="#2288FE" 
                  Visible="false"
                  OnClick="LinkButtonUserRole_Click"  
                  >
              <asp:Label runat="server" Text="UserRole" style="margin:9px 0px 0px 15px; float:left;"/>
              </asp:LinkButton></p><%--UserRole end--%><%--AttendanceRegistration start--%><p> <asp:LinkButton ID="LinkButtonAttendanceRegistration" runat="server"
              Height="80"
              Width="200"
              ForeColor="#FFFFFF"
              BackColor="#228888"
              Visible="false"
                  OnClick="LinkButtonAttendanceRegistration_Click1" 
              >
            <asp:Label runat="server" Text="Attendance" style="margin:9px 0px 0px 15px; float:left;"/>
            </asp:LinkButton></p><%-- AttendanceRegistration end --%><%--SchoolClass start--%><p> <asp:LinkButton ID="LinkButtonClassOrganisation" runat="server"
              Height="80"
              Width="200"
              ForeColor="#FFFFFF"
              BackColor="#425359"
              Visible="false"
                OnClick="LinkButtonClassOrganisation_Click"   
              >
             <%--   <asp:Image runat="server" ImageUrl="~/img/payslip.png" Height="18" style="float:left;"/>--%>
            <asp:Label runat="server" Text="SchoolClass" style="margin:9px 0px 0px 15px; float:left;"/>
              <asp:Label runat="server" Text="Organistation" style="margin:9px 0px 0px 15px; float:left;"/>
            </asp:LinkButton></p><%-- SchoolClass end --%></div></div><br />
     
         </div></asp:Content>