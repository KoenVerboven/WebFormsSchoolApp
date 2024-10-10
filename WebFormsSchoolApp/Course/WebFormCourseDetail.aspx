<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="WebFormCourseDetail.aspx.cs" Inherits="WebFormsSchoolApp.Course.WebFormCourseDetail" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="div-3">
    <h3>Course Detail</h3>
    <br />
    <br />
    <p>
        <asp:Label ID="LabelCourseId" runat="server" Text="CourseId :" Width="170px"></asp:Label>
        <asp:Label ID="LabelCourseIdValue" runat="server" Text="" Width="170px"></asp:Label>
    </p>
    <p>
        <asp:Label ID="LabelCourseName" runat="server" Text="CourseName :" Width="170px"></asp:Label>
        <asp:TextBox ID="TextBoxCourseName" runat="server" Width="250px"></asp:TextBox>
    </p>
    <p>
        <asp:Label ID="LabelCourseDescription" runat="server" Text="CourseDescription :" Width="170px"></asp:Label>
        <asp:TextBox ID="TextBoxCourseDescription" runat="server" Width="250px"></asp:TextBox>
    </p>
     <p>
         <asp:Label ID="LabelStartDate" runat="server" Text="StartDate :" Width="170px"></asp:Label>
         <asp:TextBox ID="TextBoxStartDate" runat="server" Width="250px"></asp:TextBox>
     </p>
     <p>
         <asp:Label ID="LabelEndDate" runat="server" Text="EndDate :" Width="170px"></asp:Label>
         <asp:TextBox ID="TextBoxEndDate" runat="server" Width="250px"></asp:TextBox>
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
