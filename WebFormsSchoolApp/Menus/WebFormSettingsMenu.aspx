﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="WebFormSettingsMenu.aspx.cs" Inherits="WebFormsSchoolApp.Menus.WebFormSettingsMenu" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <link href="../CustomCss/StyleSheet1.css" rel="stylesheet" />
  <div class="div1" style="background-color:gray">
  <div class="pageTitle">Settings</div>
  <br />
  <div class="row" >

  <div class="col-md-4" style="min-height:74vh;">
      <br />
       <%--change password start--%>
         <p style ="margin-left:50px"> <asp:LinkButton ID="LinkButtonChangePassword" CssClass="link2" runat="server" 
             OnClick="LinkButtonChangePassword_Click"
             Height="80"
             Width="200"
             ForeColor="#FFFFFF"
             BackColor="#F54F4F"
             Visible="false"
             >
             <asp:Label ID="LabelChangePassword" runat="server" Text="Change Password" style="margin:9px 0px 0px 15px; float:left;"/>
         </asp:LinkButton></p><%-- end--%><%-- start--%><p  style ="margin-left:50px">
             <asp:LinkButton ID="LinkButtonAdvancedSettings" CssClass="link2" runat="server"
                 Height="80"
                 Width="200"
                 ForeColor="#FFFFFF"
                 BackColor="#F54F4F"
                 Visible="false">
                 <asp:Label ID="LabelAdvancedSettings" runat="server" Text="Advanced settings" Style="margin: 9px 0px 0px 15px; float: left;" />
             </asp:LinkButton></p><%-- end--%><%-- start--%><p> <asp:LinkButton ID="LinkButton5" CssClass="link2" runat="server"
           Height="80"
           Width="200"
           ForeColor="#FFFFFF"
           BackColor="#A8ABAA" 
           Visible="false"
             
           >
         <asp:Label ID="Label5" runat="server" Text="" style="margin:9px 0px 0px 15px; float:left;"/>
           <asp:Label runat="server" Text="" style="margin:9px 0px 0px 15px; float:left;"/>
         </asp:LinkButton></p><%--  end --%><%-- start--%><p> <asp:LinkButton ID="LinkButton4" CssClass="link2" runat="server"
           Height="80"
           Width="200"
           ForeColor="#FFFFFF"
           BackColor="#2B2A83" 
           Visible="false"
           
           >
         <asp:Label ID="Label4" runat="server" Text="" style="margin:9px 0px 0px 15px; float:left;"/>
         </asp:LinkButton></p><%--  end --%></div></div><br />
      <div style="margin-left:50px">
          <asp:LinkButton ID="LinkButton1" runat="server" style="background-color:white;text-align:center" Width="150px" 
              OnClick="LinkButton1_Click">Back to mainmenu</asp:LinkButton>
      </div>
      
      <br />
      </div>
</asp:Content>