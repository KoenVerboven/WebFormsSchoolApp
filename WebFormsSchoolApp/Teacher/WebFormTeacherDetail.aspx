<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="WebFormTeacherDetail.aspx.cs" Inherits="WebFormsSchoolApp.Teacher.WebFormTeacherDetail" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <link href="../CustomCss/StyleSheet1.css" rel="stylesheet" />
    <div class="div-3">
     <p>
          <asp:Label ID="LabelTitle" runat="server" Text="TeacherDetail" Font-Size="20"></asp:Label>
     </p>
     <p>
         <asp:Button ID="ButtonSave" class="btn btn-success btn-md" Width="70px" runat="server" Text="Save" OnClick="ButtonSave_Click" />
         <asp:Button ID="ButtonCancel" class="btn btn-danger btn-md" Width="70px"  runat="server" Text="Cancel" CausesValidation="false" OnClick="ButtonCancel_Click" />
     </p>
     <p>
         <asp:Label ID="LabelErrorMessage"  ForeColor="Red"  runat="server" Text=""></asp:Label> 
     </p>
     <p>
          <asp:ValidationSummary ID="ValidationSummary1" runat="server"
              style="color:red" />
     </p>
     <p>
         <asp:Label ID="LabelTeacherId" runat="server" Text="TeacherId :" Width="170px"></asp:Label>
         <asp:Label ID="LabelTeacherIdValue" runat="server" Text="" Width="170px"></asp:Label>
     </p>
     <p>
        <asp:Label ID="LabelLastName" runat="server" Text="LastName :" Width="170px"></asp:Label>
        <asp:TextBox ID="TextBoxLastName" runat="server" Width="250px"></asp:TextBox>
         <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" Style="color:red"
              ErrorMessage="RequiredFieldValidator"
              ControlToValidate="TextBoxLastName">
              Lastname is mandatory </asp:RequiredFieldValidator>
     </p>
     <p>
       <asp:Label ID="LabelFirstName" runat="server" Text="FirstName :" Width="170px"></asp:Label>
         <asp:TextBox ID="TextBoxFirstName" runat="server" Width="250px"></asp:TextBox>
         <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" Style="color:red"
             ErrorMessage="RequiredFieldValidator"
             ControlToValidate="TextBoxFirstName">
             Firstname is mandatory </asp:RequiredFieldValidator>
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
           <asp:TextBox ID="TextBoxPhoneNumber" runat="server" Width="250px" placeholder="e.x. 036.444.789"></asp:TextBox>
     </p>
     <p>
           <asp:Label ID="LabelEmailAddress" runat="server" Text="EmailAddress :" Width="170px"></asp:Label>
           <asp:TextBox ID="TextBoxEmailAddress" runat="server" Width="250px"  placeholder="dd/mm/yyyy"></asp:TextBox>
     </p>
     <p>
          <asp:Label ID="LabelDateOfBirth" runat="server" Text="DateOfBirth :" Width="170px"></asp:Label>
          <asp:TextBox ID="TextBoxDateOfBirth" runat="server" Width="250px"  placeholder="dd/mm/yyyy"></asp:TextBox>
          <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" Style="color:red"
               ErrorMessage="RequiredFieldValidator"
               ControlToValidate="TextBoxDateOfBirth">
               DateofBirth is mandatory </asp:RequiredFieldValidator>
     </p>
     <p>
        <asp:Label ID="LabelHireDate" runat="server" Text="HireDate :" Width="170px"></asp:Label>
        <asp:TextBox ID="TextBoxHireDate" runat="server" Width="250px" placeholder="dd/mm/yyyy"></asp:TextBox>
     </p>
     <p>
       <asp:Label ID="LabelLeaveDate" runat="server" Text="LeaveDate :" Width="170px"></asp:Label>
       <asp:TextBox ID="TextBoxLeaveDate" runat="server" Width="250px"  placeholder="dd/mm/yyyy"></asp:TextBox>
     </p>
     <br />
     <asp:HiddenField ID="HiddenFieldAction" Value="" runat="server" />
     <a href="WebFormSearchTeacher.aspx">Go Back to SearchTeacher</a>
 </div>
</asp:Content>
