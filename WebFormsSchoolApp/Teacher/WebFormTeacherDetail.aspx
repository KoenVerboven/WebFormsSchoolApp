<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="WebFormTeacherDetail.aspx.cs" Inherits="WebFormsSchoolApp.Teacher.WebFormTeacherDetail" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
     <div class="div-3">
     <asp:Label ID="LabelTitle" runat="server" Text="TeacherDetail" Font-Size="16"></asp:Label>
     <br />
     <br />
     <p>
         <asp:Label ID="LabelTeacherId" runat="server" Text="TeacherId :" Width="170px"></asp:Label>
         <asp:Label ID="LabelTeacherIdValue" runat="server" Text="" Width="170px"></asp:Label>
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
           <asp:Label ID="LabelMiddleName" runat="server" Text="MiddleName :" Width="170px"></asp:Label>
           <asp:TextBox ID="TextBoxMiddleName" runat="server" Width="250px"></asp:TextBox>
     </p>
     <p>
         <asp:Label ID="LabelStreetAndNumber" runat="server" Text="StreetAndNumber :" Width="170px"></asp:Label>
         <asp:TextBox ID="TextBoxStreetAndNumber" runat="server" Width="250px"></asp:TextBox>
     </p>
     <p>
          <asp:Label ID="LabelZipCode" runat="server" Text="ZipCode :" Width="170px"></asp:Label>
          <asp:TextBox ID="TextBoxZipCode" runat="server" Width="250px"></asp:TextBox>
     </p>
     <p>
           <asp:Label ID="LabelPhoneNumber" runat="server" Text="PhoneNumber :" Width="170px"></asp:Label>
           <asp:TextBox ID="TextBoxPhoneNumber" runat="server" Width="250px"></asp:TextBox>
     </p>
     <p>
           <asp:Label ID="LabelEmailAddress" runat="server" Text="EmailAddress :" Width="170px"></asp:Label>
           <asp:TextBox ID="TextBoxEmailAddress" runat="server" Width="250px"></asp:TextBox>
     </p>
     <p>
          <asp:Label ID="LabelDateOfBirth" runat="server" Text="DateOfBirth :" Width="170px"></asp:Label>
          <asp:TextBox ID="TextBoxDateOfBirth" runat="server" Width="250px"></asp:TextBox>
     </p>
     <p>
        <asp:Label ID="LabelHireDate" runat="server" Text="HireDate :" Width="170px"></asp:Label>
        <asp:TextBox ID="TextBoxHireDate" runat="server" Width="250px"></asp:TextBox>
     </p>
     <p>
       <asp:Label ID="LabelLeaveDate" runat="server" Text="LeaveDate :" Width="170px"></asp:Label>
       <asp:TextBox ID="TextBoxLeaveDate" runat="server" Width="250px"></asp:TextBox>
     </p>
     <br />
     <a href="WebFormSearchTeacher.aspx">Go Back to SearchTeacher</a>
 </div>
</asp:Content>
