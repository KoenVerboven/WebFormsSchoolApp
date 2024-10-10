<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MainForm.aspx.cs" Inherits="WebFormsSchoolApp.MainForm" %>
<link href="StyleSheet1.css" rel="stylesheet" />
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>SchoolApp MainForm</title>
</head>
<body>
    <form id="form1" runat="server">
        <div class="div-3">
            <h3>MainForm</h3>
            <br />
            <p><asp:Label ID="LabelUser" runat="server" Text="LabelUser" Width="150"></asp:Label></p>
            <br />
            <p><a href="Student\FormSearchStudent.aspx">Search Student</a></p>
            <p><a href="Teacher\FormSearchTeacher.aspx">Search Teacher</a></p>
            <p><a href="Course\FormSearchCourse.aspx">Search Course</a> </p>
        </div>
    </form>
</body>
</html>
