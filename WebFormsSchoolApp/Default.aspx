<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebFormsSchoolApp._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <link href="CustomCss/StyleSheet1.css" rel="stylesheet" />
     <div class="div1" style="background-color:gray">
     <div class="pageTitle">Home</div>
     <br />
     <div class="row">

     <div class="col-md-4">
          <%--Student start--%>
            <p style ="margin-left:50px"> <asp:LinkButton ID="LinkButtonStudent" CssClass="link2" runat="server" 
                OnClick="LinkButton1_Click"
                Height="80"
                Width="200"
                ForeColor="#FFFFFF"
                BackColor="#2222EE"
                Visible="false"
                >
                <%--   <asp:Image runat="server" ImageUrl="~/img/payslip.png" Height="18" style="float:left;"/>--%>
                <asp:Label ID="LabelStudent" runat="server" Text="Student" style="margin:9px 0px 0px 15px; float:left;"/>
            </asp:LinkButton></p><%--Student end--%><%--Teacher start--%><p style ="margin-left:50px"><asp:LinkButton ID="LinkButtonTeacher" CssClass="link2" runat="server" 
               Height="80"
               Width="200"
               ForeColor="#FFFFFF"
               BackColor="#2222EE" 
               Visible="false"
               OnClick="LinkButtonSearchTeacher_Click"
               >
               <asp:Label ID="LabelTeacher"  runat="server" Text="Teachter" style="margin:9px 0px 0px 15px; float:left;"/>
            </asp:LinkButton></p><%--Teacher end--%><%--SchoolClass start--%><p style ="margin-left:50px"> <asp:LinkButton ID="LinkButtonSchoolClass" CssClass="link2" runat="server"
              Height="80"
              Width="200"
              ForeColor="#FFFFFF"
              BackColor="#2222EE" 
              Visible="false"
                OnClick="LinkButton1_Click1"  
              >
             <%--   <asp:Image runat="server" ImageUrl="~/img/payslip.png" Height="18" style="float:left;"/>--%>
            <asp:Label ID="LabelSchoolClass" runat="server" Text="SchoolClass" style="margin:9px 0px 0px 15px; float:left;"/>
              <asp:Label runat="server" Text="Administration" style="margin:9px 0px 0px 15px; float:left;"/>
            </asp:LinkButton></p><%-- SchoolClass end --%>

         <%--Settings start--%><p style ="margin-left:50px"> <asp:LinkButton ID="LinkButtonSettings" CssClass="link2" runat="server"
              Height="80"
              Width="200"
              ForeColor="#FFFFFF"
              BackColor="#F54F4F" 
              Visible="false"
                OnClick="LinkButtonSettings_Click"
              >
            <asp:Label ID="Label1" runat="server" Text="Settings" style="margin:9px 0px 0px 15px; float:left;"/>
            </asp:LinkButton></p><%-- Settings end --%>

     </div><div class="col-md-4">
         <%--Course start--%><p><asp:LinkButton ID="LinkButtonCourse" CssClass="link2" runat="server"
                Height="80"
                Width="200"
                ForeColor="#FFFFFF"
                BackColor="#2222EE" 
                Visible="false"
                OnClick="LinkButtonSearchCourse_Click">
              <asp:Label ID="LabelCourse" runat="server" Text="Course" style="margin:9px 0px 0px 15px; float:left;"/>
            </asp:LinkButton></p><%--Course end--%><%--User start--%><p><asp:LinkButton ID="LinkButtonUser" CssClass="link2" runat="server"
               Height="80"
               Width="200"
               ForeColor="#FFFFFF"
               BackColor="#2222EE" 
               Visible="false"
                OnClick="LinkButtonSearchUser_Click"
               >
             <asp:Label ID="LabelUser" runat  ="server" Text="User" style="margin:9px 0px 0px 15px; float:left;"/>
             </asp:LinkButton></p><%--User end--%><%--ExamenPoints start--%><p> <asp:LinkButton ID="LinkButtonExamenPoints" CssClass="link2" runat="server"
              Height="80"
              Width="200"
              ForeColor="#FFFFFF"
              BackColor="#2222EE"
              Visible="false"
                 OnClick="LinkButtonExamenPoints_Click" 
              >
             <%--   <asp:Image runat="server" ImageUrl="~/img/payslip.png" Height="18" style="float:left;"/>--%>
            <asp:Label runat="server" Text="ExamenPoints" style="margin:9px 0px 0px 15px; float:left;"/>
            </asp:LinkButton></p><%-- ExamenPoints end --%>


         <%--Examen start--%><p> <asp:LinkButton ID="LinkButtonExamen" CssClass="link2" runat="server"
              Height="80"
              Width="200"
              ForeColor="#FFFFFF"
              BackColor="#2222EE"
              Visible="false"
              OnClick="LinkButtonExamen_Click"
              >
            <asp:Label runat="server" Text="Examen" style="margin:9px 0px 0px 15px; float:left;"/>
            </asp:LinkButton></p><%-- Examen end --%>

           </div><div class="col-md-4">
                      <%--UserRole start--%><p> <asp:LinkButton ID="LinkButtonUserRole" CssClass="link2" runat="server"
                  Height="80"
                  Width="200"
                  ForeColor="#FFFFFF"
                  BackColor="#2222EE" 
                  Visible="false"
                  OnClick="LinkButtonUserRole_Click"  
                  >
              <asp:Label runat="server" Text="UserRole" style="margin:9px 0px 0px 15px; float:left;"/>
              </asp:LinkButton></p><%--UserRole end--%><%--AttendanceRegistration start--%><p> <asp:LinkButton CssClass="link2" ID="LinkButtonAttendanceRegistration" runat="server"
              Height="80"
              Width="200"
              ForeColor="#FFFFFF"
              BackColor="#2222EE"
              Visible="false"
                  OnClick="LinkButtonAttendanceRegistration_Click1" 
              >
            <asp:Label runat="server" Text="Student presence" style="margin:9px 0px 0px 15px; float:left;"/>
            </asp:LinkButton></p><%-- AttendanceRegistration end --%><%--SchoolClass start--%><p> <asp:LinkButton CssClass="link2" ID="LinkButtonClassOrganisation" runat="server"
              Height="80"
              Width="200"
              ForeColor="#FFFFFF"
              BackColor="#2222EE"
              Visible="false"
                OnClick="LinkButtonClassOrganisation_Click"   
              >
             <%--   <asp:Image runat="server" ImageUrl="~/img/payslip.png" Height="18" style="float:left;"/>--%>
            <asp:Label runat="server" Text="SchoolClass" style="margin:9px 0px 0px 15px; float:left;"/>
              <asp:Label runat="server" Text="Organistation" style="margin:9px 0px 0px 15px; float:left;"/>
            </asp:LinkButton></p><%-- SchoolClass end --%></div></div><br />
     
         </div></asp:Content>