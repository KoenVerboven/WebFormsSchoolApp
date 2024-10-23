<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="StartPage.aspx.cs" Inherits="WebFormsSchoolApp.StartPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
        <link href="CustomCss/StyleSheet1.css" rel="stylesheet" />   
<div class="container div1" >
       <div class="row">
        <div class="col-md-12">
            <div class="customFrame2" width="100%" >
                  
                    <asp:TextBox ID="TextBoxId" runat="server"   placeholder="Type here your LoginId" Width="230px"></asp:TextBox> &nbsp &nbsp
                   
                    <asp:TextBox ID="TextBoxPassword" runat="server" placeholder="Type here your Password"  Width="230px" TextMode="Password"></asp:TextBox>
                    <asp:Button ID="ButtonLogin" runat="server" Text="Login" Style="height:27px; font-size:13px" Width="75px"
                         class="btn btn-info btn-md" OnClick="ButtonLogin_Click1"/> &nbsp
                    <a href="ForgetPassword.aspx" style="color:antiquewhite">Forget password ?</a>
                    <asp:Label ID="LabelMessage" CssClass="errorLabel" Width="180px" runat="server" Text=""></asp:Label>
           </div>
           <div with="100%" style="margin-top:4px" class="customFrame3">
               <p style="background-color:#4FB7B2;color:white;padding-left:10px;padding-top:3px;padding-bottom:3px" width="800px" >Info board</p>
               <div style="margin-left:20px">
                    <p>Dear students,</p>
                     <p>
                       from Monday October 21 to Monday October 28,<br />
                       it is autumn leave and there is no school.
                    </p>
                    <p>
                       Enjoy the days off and don't forget to study for it
                       the end-of-year exam.
                    </p>
                     <p>director,<br />
                        Jan Peeters
                    </p>
               </div>
           </div>

        </div>
       
        </div>
</div>
</asp:Content>
