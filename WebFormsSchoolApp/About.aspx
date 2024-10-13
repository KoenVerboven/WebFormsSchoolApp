<%@ Page Title="About" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="About.aspx.cs" Inherits="WebFormsSchoolApp.About" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <link href="CustomCss/StyleSheet1.css" rel="stylesheet" />
    <main aria-labelledby="title">
        <h2 id="title"><%: Title %>.</h2>
        <div class="customFrame1">
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
            <a href="default.aspx" class="link1">Home</a>
            <br />
            <p>           
              <asp:Label ID="Labelfooter" runat="server" Text="Label"></asp:Label>
            </p>   
        </div>
    </main>
</asp:Content>
