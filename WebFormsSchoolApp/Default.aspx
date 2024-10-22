<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebFormsSchoolApp._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <link href="CustomCss/StyleSheet1.css" rel="stylesheet" />
     <div class="div1">
     <div class="pageTitle">Home</div>
     <br />
     <div class="row">

     <div class="col-md-4">
          <%--Student start--%>
            <p> <asp:LinkButton ID="LinkButtonSearchStudent" runat="server" 
                OnClick="LinkButton1_Click"
                Height="80"
                Width="200"
                ForeColor="#FFFFFF"
                BackColor="#779498"
                >
                <%--   <asp:Image runat="server" ImageUrl="~/img/payslip.png" Height="18" style="float:left;"/>--%>
                <asp:Label runat="server" Text="Student" style="margin:9px 0px 0px 15px; float:left;"/>
            </asp:LinkButton></p><%--Student end--%><%--Teacher start--%><p><asp:LinkButton ID="LinkButtonSearchTeacher" runat="server" 
               Height="80"
               Width="200"
               ForeColor="#FFFFFF"
               BackColor="#228822" 
               OnClick="LinkButtonSearchTeacher_Click"
               >
               <asp:Label runat="server" Text="Teachter" style="margin:9px 0px 0px 15px; float:left;"/>
            </asp:LinkButton></p><%--Teacher end--%>
         <%--SchoolClass start--%><p> <asp:LinkButton ID="LinkButton1" runat="server"
              Height="80"
              Width="200"
              ForeColor="#FFFFFF"
              BackColor="#E75573" OnClick="LinkButton1_Click1"  
              >
             <%--   <asp:Image runat="server" ImageUrl="~/img/payslip.png" Height="18" style="float:left;"/>--%>
            <asp:Label runat="server" Text="SchoolClass" style="margin:9px 0px 0px 15px; float:left;"/>
            </asp:LinkButton></p><%-- SchoolClass end --%>
     </div>
     <div class="col-md-4">
         <%--Course start--%><p><asp:LinkButton ID="LinkButtonSearchCourse" runat="server"
                Height="80"
                Width="200"
                ForeColor="#FFFFFF"
                BackColor="#AA2222" 
                OnClick="LinkButtonSearchCourse_Click">
              <asp:Label runat="server" Text="Course" style="margin:9px 0px 0px 15px; float:left;"/>
            </asp:LinkButton></p><%--Course end--%><%--User start--%><p><asp:LinkButton ID="LinkButtonSearchUser" runat="server"
               Height="80"
               Width="200"
               ForeColor="#FFFFFF"
               BackColor="#2222EE" OnClick="LinkButtonSearchUser_Click"
               >
             <asp:Label runat="server" Text="User" style="margin:9px 0px 0px 15px; float:left;"/>
             </asp:LinkButton></p><%--User end--%>
             <%--ExamenPoints start--%><p> <asp:LinkButton ID="LinkButtonExamenPoints" runat="server"
              Height="80"
              Width="200"
              ForeColor="#FFFFFF"
              BackColor="#A46FFF" OnClick="LinkButtonExamenPoints_Click" 
              >
             <%--   <asp:Image runat="server" ImageUrl="~/img/payslip.png" Height="18" style="float:left;"/>--%>
            <asp:Label runat="server" Text="ExamenPoints" style="margin:9px 0px 0px 15px; float:left;"/>
            </asp:LinkButton></p><%-- ExamenPoints end --%>
         </div>
         <div class="col-md-4">
                      <%--UserRole start--%><p> <asp:LinkButton ID="LinkButtonUserRole" runat="server"
                  Height="80"
                  Width="200"
                  ForeColor="#FFFFFF"
                  BackColor="#2288FE" OnClick="LinkButtonUserRole_Click"  
                  >
              <asp:Label runat="server" Text="UserRole" style="margin:9px 0px 0px 15px; float:left;"/>
              </asp:LinkButton></p><%--UserRole end--%><%--AttendanceRegistration start--%><p> <asp:LinkButton ID="LinkButtonAttendanceRegistration" runat="server"
              Height="80"
              Width="200"
              ForeColor="#FFFFFF"
              BackColor="#228888" OnClick="LinkButtonAttendanceRegistration_Click1" 
              >
            <asp:Label runat="server" Text="Attendance" style="margin:9px 0px 0px 15px; float:left;"/>
            </asp:LinkButton></p><%-- AttendanceRegistration end --%>
     </div>

     </div>
     <br />
     
         </div></asp:Content>