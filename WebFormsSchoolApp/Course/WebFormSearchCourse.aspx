﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="WebFormSearchCourse.aspx.cs" Inherits="WebFormsSchoolApp.Course.WebFormSearchCourse" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="div-3" >
    <h3>Search Course</h3>
    <br /><br />
    <p>
        <asp:TextBox ID="TextBoxSearch" Width="250px" runat="server"></asp:TextBox>
        <asp:Button ID="ButtonSearch" runat="server" Text="Search" OnClick="ButtonSearch_Click" />
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
            <asp:BoundField DataField="CourseId" HeaderText="Id" SortExpression="CourseId" />
            <asp:BoundField DataField="CourseName" HeaderText="CourseName" SortExpression="CourseName" />
            <asp:BoundField DataField="StartDate" HeaderText="StartDate" DataFormatString="{0:dd-M-yyyy}"  SortExpression="StartDate" />
            <asp:BoundField DataField="EndDate" HeaderText="EndDate" DataFormatString="{0:dd-M-yyyy}"  SortExpression="EndDate" />
            <asp:BoundField DataField="CourseType" HeaderText="CourseType" SortExpression="CourseType" />
            <asp:BoundField DataField="CourseIsActive" HeaderText="CourseIsActive" SortExpression="CourseIsActive" />
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