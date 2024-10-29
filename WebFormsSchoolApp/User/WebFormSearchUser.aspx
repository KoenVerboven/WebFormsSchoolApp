<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="WebFormSearchUser.aspx.cs" Inherits="WebFormsSchoolApp.User.WebFormSearchUser" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <link href="../CustomCss/StyleSheet1.css" rel="stylesheet" />
<div class="div1">
    <div class="pageTitle">User</div>
    <br />
    <p>
        <asp:TextBox ID="TextBoxSearch" Width="250px" runat="server"  placeholder="Search on Name"></asp:TextBox>
        <asp:Button ID="ButtonSearch" runat="server" Text="Search" 
            class="btn btn-primary btn-md" OnClick="ButtonSearch_Click"
            />
        &nbsp
        &nbsp
        &nbsp
        &nbsp
        <asp:Button ID="ButtonNew" runat="server" Text="+" 
            class="btn btn-secondary btn-md" OnClick="ButtonNew_Click" 
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
        Width="100%"
        BorderColor="black"
        BorderWidth="1"
        GridLines="Both"
        CellPadding="3"
        CellSpacing="0"
        Font-Names="Verdana" 
        OnPageIndexChanging="GridView1_PageIndexChanging" OnSelectedIndexChanged="GridView1_SelectedIndexChanged" OnSorting="GridView1_Sorting" 
        >
        <Columns>
            <asp:CommandField 
                 ButtonType="Button"
                 ShowSelectButton="True"
          
                />
            <asp:BoundField DataField="UserId" HeaderText="Id" SortExpression="UserId" />
            <asp:BoundField DataField="UserName" HeaderText="UserName" SortExpression="UserName" />
                
            <asp:TemplateField HeaderText = "" ItemStyle-HorizontalAlign ="Center" >
               <ItemTemplate>
                   <asp:Button ID="cmdUpdate" runat="server" Text="Update"
                       CssClass="btn btn-primary btn-md" OnClick="cmdUpdate_Click" />
               </ItemTemplate>
            </asp:TemplateField>

            <asp:TemplateField HeaderText="" ItemStyle-HorizontalAlign="Center">
                <ItemTemplate>
                    <asp:Button ID="cmdDelete" runat="server" Text="Delete"
                        CssClass="btn btn-danger btn-md" OnClick="cmdDelete_Click" />
                </ItemTemplate>
            </asp:TemplateField>
     
        </Columns>
        <AlternatingRowStyle BackColor="#9DE7FB"></AlternatingRowStyle>
    </asp:GridView>
<br />
     <asp:HiddenField ID="HiddenFieldSortDirection" runat="server" />
<br />
    
    <a href="../default.aspx">Go Back to Mainform</a>
</div>
</asp:Content>
