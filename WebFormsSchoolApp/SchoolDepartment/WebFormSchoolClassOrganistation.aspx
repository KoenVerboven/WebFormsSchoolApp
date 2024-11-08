<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="WebFormSchoolClassOrganistation.aspx.cs" Inherits="WebFormsSchoolApp.SchoolDepartment.WebFormSchoolClassOrganistation" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <link href="../CustomCss/StyleSheet1.css" rel="stylesheet" />
     <p class="pageTitle">
        <asp:Label ID="LabelTitle" runat="server" Text="Add or remove Students from a Class" Font-Size="20"></asp:Label>
     </p> 
    <p>
        <asp:Label ID="LabelMessage" CssClass="errorLabel" Width="400px" runat="server" Text=""></asp:Label> 
    </p>
     <div class="row">
        <div class="col-md-1">
        </div>
         <div class="col-md-4">
             <br />
             <asp:Label ID="Label2" runat="server" style="width:350px;background-color:red;color:white;padding-left:7px" Text="Student" Width="200px"></asp:Label>
             <asp:ListBox ID="ListBoxStudent" style="min-width:350px;min-Height:400px"  runat="server"></asp:ListBox>
         </div>
         <div class="col-md-1">
             <br /><br /><br /><br /><br /><br />
             <asp:Button ID="ButtonAddStudentToClass" class="btn btn-dark btn-md" runat="server" Text="-->" OnClick="ButtonAddStudentToClass_Click" />
             <br /><br />
             <asp:Button ID="ButtonRemoveStudentFromClass" class="btn btn-dark btn-md" runat="server" Text="<--" OnClick="ButtonRemoveStudentFromClass_Click"  />
         </div>
         <div class="col-md-4">
             <asp:DropDownList ID="DropDownListClass" style="min-width:350px;margin-bottom:5px;" runat="server"></asp:DropDownList>
             <asp:Label ID="Label4" runat="server" style="width:350px;background-color:red;color:white;padding-left:7px" Text="Class" Width="200px"></asp:Label>
             <asp:ListBox ID="ListBoxSchoolClass"  style="min-width:350px;min-Height:400px" runat="server"></asp:ListBox>
         </div>
        <div class="col-md2">
        </div>  
          <a href="../default.aspx">Go Back to Mainform</a>
    </div>


</asp:Content>
