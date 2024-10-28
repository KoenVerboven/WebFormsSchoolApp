<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="WebFormSchoolClassDetail.aspx.cs" Inherits="WebFormsSchoolApp.SchoolDepartment.WebFormSchoolClassDetail" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    
        <link href="../CustomCss/StyleSheet1.css" rel="stylesheet" />
    <div class="div-3">

    <p class="pageTitle">
       <asp:Label ID="LabelTitle" runat="server" Text="SchoolClassDetail" Font-Size="20"></asp:Label>
    </p> 
    <p>
         <asp:Button ID="ButtonSave" class="btn btn-success btn-md" Width="70px" runat="server" Text="Save" OnClick="ButtonSave_Click"  />
         <asp:Button ID="ButtonCancel" class="btn btn-danger btn-md" Width="70px"  runat="server" Text="Cancel" CausesValidation="false" OnClick="ButtonCancel_Click" />
    </p>  
    <p>
        <asp:Label ID="LabelErrorMessage"  ForeColor="Red"  runat="server" Text=""></asp:Label> 
    </p>
    <p>
         <asp:ValidationSummary ID="ValidationSummary1" CssClass="customValidationSummary" runat="server" />
    <p>
        <asp:Label ID="LabelSchoolClassId" runat="server" Text="Id :" Width="170px"></asp:Label>
        <asp:Label ID="LabelSchoolClassIdValue" runat="server" Text="" Width="170px"></asp:Label>
    </p>
    <p>
        <asp:Label ID="LabelClassCode" runat="server" Text="ClassCode :" Width="170px"></asp:Label>
        <asp:TextBox ID="TextBoxClassCode" Width="250" runat="server"></asp:TextBox>
    </p>
    <p>
         <asp:Label ID="LabelDescription" runat="server" Text="Description :" Width="170px"></asp:Label>
         <asp:TextBox ID="TextBox1" Width="300px" runat="server"></asp:TextBox>
    </p>
    <p>
          <asp:Label ID="LabelDegree" runat="server" Text="Degree :" Width="170px"></asp:Label>
          <asp:TextBox ID="TextBoxDegree" Width="250" runat="server"></asp:TextBox>
    </p>
    <p>
      <asp:Label ID="LabelGrade" runat="server" Text="Grade :" Width="170px"></asp:Label>
      <asp:TextBox ID="TextBoxGrade" Width="250" runat="server"></asp:TextBox>
    </p>
   
    <br />
         <asp:HiddenField ID="HiddenFieldAction" Value="" runat="server" />
    <a href="WebFormSchoolClass.aspx">Go Back to SchoolClass</a>
</div>


</asp:Content>
