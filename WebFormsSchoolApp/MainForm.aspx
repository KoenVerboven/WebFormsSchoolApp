<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="MainForm.aspx.cs" Inherits="WebFormsSchoolApp.MainForm" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
        <div class="div-3">
            <h3>MainForm</h3>
            <br />
            <br />
            <p><a href="Student\WebFormSearchStudent.aspx">Search Student</a></p>
            <p><a href="Teacher\WebFormSearchTeacher.aspx">Search Teacher</a></p>
            <p><a href="Course\WebFormSearchCourse.aspx">Search Course</a> </p>
           
        </div>
</asp:Content>

<a href="Site.Master">Site.Master</a>