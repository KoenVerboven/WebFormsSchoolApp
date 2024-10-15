<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="WebFormsSchoolApp.WebFormLogin" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <link href="CustomCss/StyleSheet1.css" rel="stylesheet" />   
<div class="container">
    <div style="height: 100px;"></div>
    <div class="row">
        <div class="col-md-4"></div>
        <div class="col-md-4">
            <div class="customFrame1" height="80%" width="500px">
                <h3>Login</h3>
                <br />

                <p>
                    <asp:TextBox ID="TextBoxId" runat="server"  placeholder="Type here your LoginId" Width="230px"></asp:TextBox>
                </p>
                <p>
                    <asp:TextBox ID="TextBoxPassword" runat="server" placeholder="Type here your Password"  Width="230px" TextMode="Password"></asp:TextBox>
                </p>
                <p><a href="ForgetPassword.aspx">Forget password  ?</a></p>
                <p>
                    <asp:Button ID="ButtonLogin" runat="server" Text="Login" Style="height: 35px" Width="230px"
                        class="btn btn-primary btn-md"
                        OnClick="ButtonLogin_Click" />
                </p>
                <p>
                    <asp:Label ID="LabelMessage" CssClass="errorLabel" Width="230px" runat="server" Text=""></asp:Label>
                </p>
            </div>
        </div>
        <div class="col-md-4"></div>
    </div>
</div>
</asp:Content>
