<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="WebFormSearchCourse.aspx.cs" Inherits="WebFormsSchoolApp.Course.WebFormSearchCourse" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <link href="../CustomCss/StyleSheet1.css" rel="stylesheet" />
    <div class="div1" >
    <div class="pageTitle">Course</div>
    <p>
         <asp:Label ID="LabelMessage" CssClass="errorLabel" Width="400px" runat="server" Text=""></asp:Label> 
    </p>
    <p>
        <asp:TextBox ID="TextBoxSearch" Width="250px" Height="36px" placeholder="Search on coursename" runat="server"></asp:TextBox>
        <asp:Button ID="ButtonSearch" runat="server" Text="Search" Height="36"
            class="btn btn-primary btn-md"
            OnClick="ButtonSearch_Click" 
            />
         &nbsp
         &nbsp
         &nbsp
         <asp:Button ID="ButtonNew" runat="server" Text="+"  Height="36"
             class="btn btn-secondary btn-md"  OnClick="ButtonNew_Click"  
             />
          &nbsp
          &nbsp
    </p>
    <p>
         <asp:DropDownList ID="DropDownListFilterActive" Height="36px" Width="250px" runat="server"></asp:DropDownList>
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
        OnPageIndexChanging="GridView1_PageIndexChanging" 
        OnSelectedIndexChanged="GridView1_SelectedIndexChanged" OnSorting="GridView1_Sorting1" 
        >
        <Columns>
            <asp:CommandField 
                ButtonType="Link"
                ShowSelectButton="True"
                />
            <asp:BoundField DataField="CourseId" HeaderText="Id" SortExpression="CourseId" ItemStyle-Width="10%"  ItemStyle-Wrap="False"/>
            <asp:BoundField DataField="CourseName" HeaderText="CourseName" SortExpression="CourseName" ItemStyle-Width="40%"  ItemStyle-Wrap="False" />
            <asp:BoundField DataField="StartDate" HeaderText="StartDate" DataFormatString="{0:dd-M-yyyy}"  SortExpression="CourseStartDate" ItemStyle-Width="15%"  ItemStyle-Wrap="False" />
            <asp:BoundField DataField="EndDate" HeaderText="EndDate" DataFormatString="{0:dd-M-yyyy}"  SortExpression="CourseEndDate" ItemStyle-Width="15%"  ItemStyle-Wrap="False" />
            <asp:BoundField DataField="CourseIsActive" HeaderText="Active" ItemStyle-Width="10%"  ItemStyle-Wrap="False" />
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
