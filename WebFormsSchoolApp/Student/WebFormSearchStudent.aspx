<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="WebFormSearchStudent.aspx.cs" Inherits="WebFormsSchoolApp.Student.WebFormSearchStudent" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="div-3">
    <h3>Search Student</h3>
    <br /><br />
    <p>
        <asp:TextBox ID="TextBoxSearch" Width="250px" runat="server"></asp:TextBox>
        <asp:Button ID="ButtonSearch" runat="server" Text="Search" 
            class="btn btn-primary btn-md"
            OnClick="ButtonSearch_Click"
            />
        &nbsp
        &nbsp
        &nbsp
        &nbsp
        <asp:Button ID="ButtonNew" runat="server" Text="+" 
            class="btn btn-secondary btn-md" OnClick="ButtonNew_Click1" 
            />
         &nbsp
         &nbsp
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
        OnSelectedIndexChanged="GridView1_SelectedIndexChanged" OnSorting="GridView1_Sorting" OnRowDeleting="GridView1_RowDeleting" OnRowEditing="GridView1_RowEditing"
        >
        <Columns>
            <asp:CommandField 
                 ButtonType="Link"
                 ShowSelectButton="True" 
                />
            <asp:BoundField DataField="PersonId" HeaderText="Id" SortExpression="PersonId" />
            <asp:BoundField DataField="FullName" HeaderText="FullName" SortExpression="FullName" />
            <asp:BoundField DataField="DateOfBirth" HeaderText="DateOfBirth" 
                DataFormatString="{0:dd-M-yyyy}"  
                SortExpression="DateOfBirth" />
             <asp:CommandField 
                 ButtonType="Link"
                 ShowEditButton="True"
                 ShowDeleteButton="True"
                 />
        </Columns>
        <HeaderStyle BackColor="#aaaadd"></HeaderStyle>
        <FooterStyle BackColor="#aaaadd"></FooterStyle>
        <AlternatingRowStyle BackColor="#eeeeee"></AlternatingRowStyle>
    </asp:GridView>
    <br />
    <br />
    <a href="../default.aspx">Go Back to Mainform</a>
</div>


</asp:Content>
