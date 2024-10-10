<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FormStudentDetail.aspx.cs" Inherits="WebFormsSchoolApp.Student.FormStudentDetail" %>
<link href="../StyleSheet1.css" rel="stylesheet" />
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div class="div-3">
            <h3>Student detail</h3>
            <br />
            <br />
            <p>
                <asp:Label ID="LabelStudentId" runat="server" Text="StudentId :" Width="170px"></asp:Label>
                <asp:Label ID="LabelStudentIdValue" runat="server" Text="" Width="170px"></asp:Label>
            </p>
            <p>
               <asp:Label ID="LabelLastName" runat="server" Text="LastName :" Width="170px"></asp:Label>
               <asp:TextBox ID="TextBoxLastName" runat="server" Width="250px"></asp:TextBox>
            </p>
            <p>
              <asp:Label ID="LabelFirstName" runat="server" Text="FirstName :" Width="170px"></asp:Label>
              <asp:TextBox ID="TextBoxFirstName" runat="server" Width="250px"></asp:TextBox>
            </p>
            <p>
              <asp:Label ID="LabelRegistrationDate" runat="server" Text="RegistrationDate :" Width="170px"></asp:Label>
              <asp:TextBox ID="TextBoxRegistrationDate" runat="server" Width="250px"></asp:TextBox>
            </p>
            <br />
            <a href="FormSearchStudent.aspx">Go Back to SearchStudent</a>
        </div>
    </form>
</body>
</html>
