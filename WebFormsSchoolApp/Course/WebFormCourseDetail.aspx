<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="WebFormCourseDetail.aspx.cs" Inherits="WebFormsSchoolApp.Course.WebFormCourseDetail" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="div-3">

    <p>
       <asp:Label ID="LabelTitle" runat="server" Text="CourseDetail" Font-Size="16"></asp:Label>
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
        <asp:Label ID="LabelCourseId" runat="server" Text="CourseId :" Width="170px"></asp:Label>
        <asp:Label ID="LabelCourseIdValue" runat="server" Text="" Width="170px"></asp:Label>
    </p>
    <p>
        <asp:Label ID="LabelCourseName" runat="server" Text="CourseName :" Width="170px"></asp:Label>
        <asp:TextBox ID="TextBoxCourseName" runat="server" Width="250px"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" Style="color:red"
              ErrorMessage="RequiredFieldValidator"
              ControlToValidate="TextBoxCourseName">
              CourseName is mandatory </asp:RequiredFieldValidator>
    </p>
    <p>
        <asp:Label ID="LabelCourseDescription" runat="server" Text="CourseDescription :" Width="170px"></asp:Label>
        <asp:TextBox ID="TextBoxCourseDescription" runat="server" Width="250px"></asp:TextBox>
    </p>
     <p>
         <asp:Label ID="LabelStartDate" runat="server" Text="StartDate :" Width="170px"></asp:Label>
         <asp:TextBox ID="TextBoxStartDate" runat="server" Width="250px" placeholder="dd/mm/yyyy"></asp:TextBox>
     </p>
     <p>
         <asp:Label ID="LabelEndDate" runat="server" Text="EndDate :" Width="170px"></asp:Label>
         <asp:TextBox ID="TextBoxEndDate" runat="server" Width="250px" placeholder="dd/mm/yyyy"></asp:TextBox>
     </p>
    <p>
        <asp:Label ID="LabelActive" runat="server" Text="Active :" Width="170px"></asp:Label>
        <asp:CheckBox ID="CheckBoxActive" runat="server" />
    </p>
    <p>
        <asp:Label ID="LabelCoursePrice" runat="server" Text="Price :" Width="170px"></asp:Label>
        <asp:TextBox ID="TextBoxCoursePrice" runat="server" Width="250px"></asp:TextBox>
    </p>
    <br />
    <a href="WebFormSearchCourse.aspx">Go Back to SearchCourse</a>
</div>
</asp:Content>
