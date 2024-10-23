<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="WebFormSchoolClassOrganistation.aspx.cs" Inherits="WebFormsSchoolApp.SchoolDepartment.WebFormSchoolClassOrganistation" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <p>
        <asp:Button ID="Button1" runat="server" Text="Add Student to Class" OnClick="Button1_Click" />
    </p>
     <p>
     <asp:Button ID="Button2" runat="server" Text="Remove Student from Class" OnClick="Button2_Click"  />
    </p>
     <div class="row">
        <div class="col-md-1">
        </div>
         <div class="col-md-2">
             <asp:Label ID="Label2" runat="server" style="width:200px;background-color:red;color:white" Text="Student" Width="200px"></asp:Label>
             <asp:ListBox ID="ListBox1" style="width:200px" runat="server"></asp:ListBox>
         </div>
         <div class="col-md-2">
             <asp:Label ID="Label4" runat="server" style="width:200px;background-color:red;color:white" Text="Class" Width="200px"></asp:Label>
             <asp:ListBox ID="ListBox2" style="width:200px" runat="server"></asp:ListBox>
         </div>
        <div class="col-md7">
        </div>  
    </div>


</asp:Content>
