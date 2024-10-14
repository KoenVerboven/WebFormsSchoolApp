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
                    <asp:Label ID="LabelUserId" runat="server" Text="UserId :" Width="100px" class="label1"></asp:Label>
                    <asp:TextBox ID="TextBoxId" runat="server" Width="190px"></asp:TextBox>
                </p>
                <p>
                    <asp:Label ID="LabelPassword" runat="server" Text="Password :" Width="100px"></asp:Label>
                    <asp:TextBox ID="TextBoxPassword" runat="server" Width="190px" TextMode="Password"></asp:TextBox>
                </p>
                <p>
                    <asp:Button ID="ButtonLogin" runat="server" Text="Login" Style="height: 35px" Width="90px"
                        class="btn btn-primary btn-md"
                        OnClick="ButtonLogin_Click" />
                </p>
                <p>
                    <asp:Label ID="LabelMessage" runat="server" Text=""></asp:Label>
                </p>
            </div>
        </div>
        <div class="col-md-4"></div>
    </div>
</div>
</asp:Content>
