<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="WebFormStudentDetail.aspx.cs" Inherits="WebFormsSchoolApp.Student.WebFormStudentDetail" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="div-3">
        <p>
              <asp:Label ID="LabelTitle" runat="server" Text="StudentDetail" Font-Size="16"></asp:Label>
        </p>
        <p>
            <asp:Button ID="ButtonSave" class="btn btn-success btn-md" Width="70px" runat="server" Text="Save" />
            <asp:Button ID="ButtonCancel" class="btn btn-danger btn-md" Width="70px"  runat="server" Text="Cancel" />
        </p>
        <p>
            <asp:Label ID="LabelErrorMessage" runat="server" Text=""></asp:Label> 
        </p>
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
          <asp:Label ID="LabelRegistrationDate" runat="server" Text="RegistrationDate :" Width="170px"></asp:Label>
          <asp:TextBox ID="TextBoxRegistrationDate" runat="server" Width="250px"></asp:TextBox>
        </p>
        <br />
        <a href="WebFormSearchStudent.aspx">Go Back to SearchStudent</a>
</div>
</asp:Content>
