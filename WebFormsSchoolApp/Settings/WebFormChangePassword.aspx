<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="WebFormChangePassword.aspx.cs" Inherits="WebFormsSchoolApp.Settings.WebFormChangePassword" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <link href="../CustomCss/StyleSheet1.css" rel="stylesheet" />
   <div class="div1">
      <div class="pageTitle">Change Password</div>
       <br />
        <p>
          <asp:Label ID="LabelMessage" Width="400px" runat="server" Text=""></asp:Label> 
          <asp:ValidationSummary ID="ValidationSummary1" CssClass="customValidationSummary" runat="server" />
      </p>  
       <section class=“list-with-heading”>
          <h5>Password requirements</h5>
          <ul>
             <li>It's a good idea to use a strong password that you don't use elsewhere.</li>
             <li> Password is minimum 8 characters long and contains no username, proper name or company name.</li>
             <li>Contains uppercase, lowercase letters, numbers and symbols.</li>
             <li>Is significantly different from previous passwords.</li>
          </ul>
        </section>
       <br />
       <p>
           <asp:Label ID="LabelCurrent" runat="server" Text="Current password (*)" Width="200px"></asp:Label>
           <asp:TextBox ID="TextBoxCurrent" runat="server" Width="300"></asp:TextBox>
           <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" Display="None"
                  ErrorMessage="Current password is mandatory"
                  ControlToValidate="TextBoxCurrent">
           </asp:RequiredFieldValidator>
       </p>
       <p>
        <asp:Label ID="LabelNew" runat="server" Text="New password (*)" Width="200px"></asp:Label>
        <asp:TextBox ID="TextBoxNew" runat="server" Width="300"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" Display="None"
            ErrorMessage="New password is mandatory"
            ControlToValidate="TextBoxNew">
        </asp:RequiredFieldValidator>
        <asp:RegularExpressionValidator Display = "None" 
             ControlToValidate = "TextBoxNew" 
             ID="RegularExpressionValidator1" 
             ValidationExpression = "^[\s\S]{8,25}$" 
             runat="server" 
             ErrorMessage="New password must be min 8 and max 25 characters.">
         </asp:RegularExpressionValidator>
      </p>
      <p>
       <asp:Label ID="LabelRetypeNew" runat="server" Text="Retype new password (*)" Width="200px"></asp:Label>
       <asp:TextBox ID="TextBoxConfirmPassword" runat="server" Width="300"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" Display="None"
            ErrorMessage="Retype new password is mandatory"
            ControlToValidate="TextBoxConfirmPassword">
        </asp:RequiredFieldValidator>
        <asp:CompareValidator runat="server" ControlToCompare="TextBoxNew" ControlToValidate="TextBoxConfirmPassword"
                ErrorMessage="Passwords do not match." ForeColor="Red" Display="None">
        </asp:CompareValidator>
      </p>
      <p>
          <asp:Button class="btn btn-primary"   ID="ButtonSaveChanges" runat="server" Text="Save Changes" OnClick="ButtonSaveChanges_Click" />
          <asp:Button ID="ButtonCancel" class="btn btn-danger btn-md" Width="70px"  runat="server" Text="Cancel" CausesValidation="false" OnClick="ButtonCancel_Click" />
      </p>

    </div>
</asp:Content>
