<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="StartPage.aspx.cs" Inherits="WebFormsSchoolApp.StartPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
        <link href="CustomCss/StyleSheet1.css" rel="stylesheet" />   
<div class="container div1" >
       <div class="row">
       <%-- <div class="col-md-1"></div>--%>
        <div class="col-md-12">
            <div class="customFrame2" width="100%" >
         <%--   <p>--%>
                   <%-- <asp:Label ID="Label1" runat="server" Text="user :"></asp:Label>--%>
                    <asp:TextBox ID="TextBoxId" runat="server"   placeholder="Type here your LoginId" Width="230px"></asp:TextBox> &nbsp &nbsp
                    <%--<asp:Label ID="Label2" runat="server" Text="Password :"></asp:Label>--%>
                    <asp:TextBox ID="TextBoxPassword" runat="server" placeholder="Type here your Password"  Width="230px" TextMode="Password"></asp:TextBox>
                    <asp:Button ID="ButtonLogin" runat="server" Text="Login" Style="height:27px; font-size:13px" Width="75px"
                         class="btn btn-info btn-md" OnClick="ButtonLogin_Click1"/> &nbsp
                    <a href="ForgetPassword.aspx" style="color:antiquewhite">Forget password ?</a>
                    <asp:Label ID="LabelMessage" CssClass="errorLabel" Width="180px" runat="server" Text=""></asp:Label>
          <%-- </p>--%>
           </div>
           <div with="100%" style="margin-top:4px" class="customFrame3">
               <p style="background-color:#4FB7B2;color:white;padding-left:10px;padding-top:3px;padding-bottom:3px" width="800px" >Info board</p>
               <p>communication from the school to the students</p>
               <p>This is some text.This is some text.This is some text.This is some text.This is some text.</p>
               <p>This is some text.This is some text.This is some text.This is some text.</p>
               <p>This is some text.This is some text.This is some text.This is some text.</p>
               <p>This is some text.This is some text.This is some text.This is some text.</p>
                <p>This is some text.This is some text.This is some text.This is some text.</p>
           </div>

        </div>
        <%--<div class="col-md-1"></div>--%>
        </div>
</div>
</asp:Content>
