<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="WebFormSearchTeacher.aspx.cs" Inherits="WebFormsSchoolApp.Teacher.WebFormSearchTeacher" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
      <div class="div-3">
      <h3>Search teacher</h3>
      <br /><br />
          <p>
            <asp:TextBox ID="TextBoxSearch" Width="250px" runat="server"></asp:TextBox>
            <asp:Button ID="ButtonSearch" runat="server" Text="Search" 
                class="btn btn-primary btn-md"
                OnClick="ButtonSearch_Click" />
        </p>
        <br />

      <asp:GridView ID="GridView1" runat="server"
          AutoGenerateColumns="false"
          AllowSorting="True"
          AllowPaging="True"
          PageSize="10"            
          ShowFooter="true"
          BackColor="White" 
          Height="150px"
          Width="90%" 
          BorderColor="black"
          BorderWidth="1"
          GridLines="Both"
          CellPadding="3"
          CellSpacing="0"
          Font-Names="Verdana" 
          OnPageIndexChanging="GridView1_PageIndexChanging" 
          OnSelectedIndexChanged="GridView1_SelectedIndexChanged" 
          >
           <Columns>
               <asp:CommandField ShowSelectButton="True" />
               <asp:BoundField DataField="PersonId" HeaderText="Id" SortExpression="PersonId" />
               <asp:BoundField DataField="FullName" HeaderText="FullName" SortExpression="FullName" />
               <asp:BoundField DataField="HireDate" HeaderText="HireDate" DataFormatString="{0:dd-M-yyyy}" SortExpression="HireDate" />
           </Columns>
           <HeaderStyle BackColor="#aaaadd"></HeaderStyle>
           <FooterStyle BackColor="#aaaadd"></FooterStyle>
           <AlternatingRowStyle backcolor="#eeeeee"></AlternatingRowStyle>
      </asp:GridView>
      <br />
      <br />
      <a href="../default.aspx">Go Back to Mainform</a>
  </div>
</asp:Content>
