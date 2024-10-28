<%@ Page Title="About" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="About.aspx.cs" Inherits="WebFormsSchoolApp.About" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <link href="CustomCss/StyleSheet1.css" rel="stylesheet" />
    <main aria-labelledby="title">
        <div class="pageTitle"><%: Title %></div>
        <br />
        <div class="customFrame1" Height="550px";>
            <h3><u>Schooladministration</u></h3>
            <h5>Demo program</h5>
            <h6 class="text1">Programmer : Verboven Koen</h6>
            <br />
            <p>Technical data :</p>
            <ul>
                <li>Programming language : C#</li>
                <li>Programming language : C#</li>
                <li>Framework="4.7.2"</li>
                <li>Microsoft Visual Studio Community 2022  Version 17.8.4</li>
            </ul>
            <br />
            <p>See also my other program(s) on github :</p>
             <ul>
               <li> <a href="https://github.com/KoenVerboven/WinFormsSchool">WinForms School project</a></li>
            </ul>
            <br />
            <br />
            <p>           
              <asp:Label ID="Labelfooter" runat="server" Text="Label"></asp:Label>
            </p>   
            <div>
                 <a href="default.aspx" >Home</a>
            </div>
        </div>
    </main>
</asp:Content>
