<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="WebFormExamPoints.aspx.cs" Inherits="WebFormsSchoolApp.Exam.WebFormExamPoints" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <link href="../CustomCss/StyleSheet1.css" rel="stylesheet" />
<br /><br />
     <div class="pageTitle">Examen points</div>
     <br />
     <br />
<p>
    <asp:Label ID="Label1" runat="server" Text="**** Under Construction ****" BackColor="Yellow"></asp:Label>
</p>
    <br />
    <br />
    

  <div class="row">
   <div class="col-md-3">
   <p style="background-color:white">Max Points</p> 
   <p></p>
   <p>mathematics</p>   
   <p>chemistry</p> 
   <p>Electronics practice </p> 
   <p>measurement and control technology</p>  
   </div>

    <div class ="col-md-4" style="width:310px;background-color:yellow">
    <p ><asp:Label ID="Label6" runat="server" Width=300 BackColor="DarkBlue" ForeColor="White" Text="100%"></asp:Label></p>
   <p></p>
   <p><asp:Label ID="Label2" runat="server" Width=210 BackColor="Darkgreen" ForeColor="White" Text="70%"></asp:Label></p>
   <p><asp:Label ID="Label3" runat="server"  Width=147  BackColor="red" ForeColor="White" Text="49%"></asp:Label></p>
   <p><asp:Label ID="Label4" runat="server"  Width=270px  BackColor="Darkgreen" ForeColor="White" Text="90%"></asp:Label></p>
   <p><asp:Label ID="Label5" runat="server"  Width=300px  BackColor="Darkgreen" ForeColor="White"  Text="100%"></asp:Label></p>
    </div>
    </div>                     
    


</asp:Content>
