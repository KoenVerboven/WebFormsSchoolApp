<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="WebFormTeacherDetail.aspx.cs" Inherits="WebFormsSchoolApp.Teacher.WebFormTeacherDetail" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
     <div class="div-3">
     <h3>Teacher Detail</h3>
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
