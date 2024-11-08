<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="WebFormStudentAttendanceRegistration.aspx.cs" Inherits="WebFormsSchoolApp.AttendanceRegistration.WebFormAttendanceRegistration" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <link href="../CustomCss/StyleSheet1.css" rel="stylesheet" />
     <div class="pageTitle">student presence notation</div>
    <br />
    <p>
     <asp:Label ID="LabelMessage" CssClass="errorLabel" Width="400px" runat="server" Text=""></asp:Label> 
    </p>
    <p>
         <asp:Button ID="ButtonSave" class="btn btn-success btn-md" Width="70px" runat="server" Text="Save" OnClick="ButtonSave_Click1"  />
         <asp:Button ID="ButtonCancel" class="btn btn-danger btn-md" Width="70px"  runat="server" Text="Cancel" CausesValidation="False" OnClick="ButtonCancel_Click"  />
    </p>
    <p>
        <asp:Label ID="Label2" runat="server" Text="Select Class"></asp:Label>
        <asp:DropDownList ID="DropDownListClass" style="min-width:350px;margin-bottom:5px;" runat="server"></asp:DropDownList>
    </p>
    <p></p>
    <asp:GridView ID="GridView1" runat="server"
         AutoGenerateColumns="false"
         AllowPaging="True"
         PageSize="35"
         ShowFooter="true"
         BackColor="White"
         Height="150px"
         Width="90%"
         BorderColor="black"
         BorderWidth="1"
         GridLines="Both"
         CellPadding="3"
         CellSpacing="0"
        >
         <Columns>
             <asp:TemplateField>
                <HeaderTemplate>
                      <asp:Label ID="labelStudentId" ToolTip="studentId" runat="server" Text="StudentId"></asp:Label>
                </HeaderTemplate>
                <ItemTemplate>
                    <asp:Label ID="studentId" runat="server" Text='<%# Eval("StudentId") %>'/>
                </ItemTemplate>
            </asp:TemplateField>
             
             <asp:BoundField DataField="StudentFullName" HeaderText="FullName" SortExpression="FullName" />
             <asp:TemplateField>
                 <HeaderTemplate>
                       <asp:Label ID="labelPresent" ToolTip="the student is present" runat="server" Text="Present"></asp:Label>
                 </HeaderTemplate>
                 <ItemTemplate>
                     <asp:CheckBox ID="Presence" runat="server" Checked='<%# Eval("Presence") %>'/>
                 </ItemTemplate>
             </asp:TemplateField>

              <asp:TemplateField>
                 <HeaderTemplate>
                       <asp:Label ID="labelRemarks" ToolTip="absent remarks" runat="server" Text="Remarks"></asp:Label>
                 </HeaderTemplate>
                 <ItemTemplate>
                     <asp:TextBox ID="TextBoxRemarks" runat="server" Width="100%"></asp:TextBox>
                 </ItemTemplate>
             </asp:TemplateField>
            
         </Columns>
        <HeaderStyle BackColor="#aaaadd" ForeColor="White"></HeaderStyle>
        <FooterStyle BackColor="#aaaadd"></FooterStyle>
  <AlternatingRowStyle BackColor="#eeeeee"></AlternatingRowStyle>

    </asp:GridView>
    <br />
    <br />
    <a href="../default.aspx">Go Back to Mainform</a>
</asp:Content>
