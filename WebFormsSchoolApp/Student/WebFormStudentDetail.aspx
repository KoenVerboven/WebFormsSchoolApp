<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="WebFormStudentDetail.aspx.cs" Inherits="WebFormsSchoolApp.Student.WebFormStudentDetail" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
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
    <a href="WebFormSearchStudent.aspx">Go Back to SearchStudent</a>
</div>
</asp:Content>
