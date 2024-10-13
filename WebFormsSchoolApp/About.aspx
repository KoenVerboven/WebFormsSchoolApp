<%@ Page Title="About" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="About.aspx.cs" Inherits="WebFormsSchoolApp.About" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <link href="CustomCss/StyleSheet1.css" rel="stylesheet" />
    <main aria-labelledby="title">
        <h2 id="title"><%: Title %>.</h2>
        <div class="customFrame1">
            <h3><u>Schooladministration</u></h3>
            <h5>Demo program</h5>
            <h6 class="text1">Programmer : Verboven Koen</h6>
            <h6 class="text1">Belgium - Vosselaar</h6>
            <p>Programming language : C#</p>
            <p>Microsoft AspNet WebForms</p>
            <p>Framework="4.7.2"</p>
            <p>Microsoft Visual Studio Community 2022  Version 17.8.4</p>
            <br />
            <br />
            <br />
            <br />
            <br />
            <a href="default.aspx" class="link1">Home</a>
        </div>
    </main>
</asp:Content>
