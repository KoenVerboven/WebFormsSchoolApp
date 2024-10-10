<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="WebFormsSchoolApp.Login" %>
<link href="StyleSheet1.css" rel="stylesheet" />
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
  
<head runat="server">
    <title>SchoolApp Login</title>
</head>

<body>
    <form id="form1" runat="server">
        <div class="div-2"></div>
        <div class="div-1">
            <h3>Schooladministration Login</h3>
            <br />
            <br />
            <p>
                 <asp:Label ID="LabelUserId" runat="server" Text="UserId :" Width="100px" class="label1" ></asp:Label>
                 <asp:TextBox ID="TextBoxId" runat="server" Width="190px"></asp:TextBox>
             </p>
             <p>
                 <asp:Label ID="LabelPassword" runat="server" Text="Password :" Width="100px"></asp:Label>
                 <asp:TextBox ID="TextBoxPassword" runat="server" Width="190px"></asp:TextBox> 
             </p>
             <p>
                 <asp:Button ID="ButtonLogin" runat="server" Text="Login" OnClick="Button1_Click" style="height: 29px" Width="90px" />
             </p>
             <p>
                 <asp:Label ID="LabelMessage" runat="server" Text=""></asp:Label>
             </p>
        </div>
        <div class="div-2"></div>
    </form>
</body>
</html>
