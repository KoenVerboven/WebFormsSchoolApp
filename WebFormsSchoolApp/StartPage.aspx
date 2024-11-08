<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="StartPage.aspx.cs" Inherits="WebFormsSchoolApp.StartPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
        <link href="CustomCss/StyleSheet1.css" rel="stylesheet" />  
<div class="container div1" >
       <div class="row">
        <div class="col-md-12">
            <div class="customFrame2" width="100%" >
                  
                    <asp:TextBox ID="TextBoxId" runat="server"   placeholder="Type here your LoginId" Width="230px"></asp:TextBox> &nbsp &nbsp
                   
                    <asp:TextBox ID="TextBoxPassword" runat="server" placeholder="Type here your Password"  Width="230px" TextMode="Password"></asp:TextBox>
                   
                    <asp:Button ID="ButtonLogin" runat="server" Text="LOGIN" Style="height:33px;width:90px; font-size:13px;margin-left:20px;color:yellow" 
                         class="btn btn-primary btn-md" OnClick="ButtonLogin_Click1"/> &nbsp
                    
                     <a href="ForgetPassword.aspx" style="color:black;margin-left:20px">Forget password ?</a>
                    
                    <asp:Label ID="LabelMessage" CssClass="errorLabel" Width="180px" runat="server" Text=""></asp:Label>
           </div>

           <div with="100%" style="margin-top:4px;background-color:white" class="customFrame3">
               <p style="background-color:#FF0063;color:white;padding-left:10px;padding-top:3px;padding-bottom:3px" width="800px" >Info item 1/10/2024</p>
               <div style="float:left;width:30%;">
                  <img src="Images/autumnSmall.jpg" style="max-width: 70%; height: auto;margin-left:3px;border-radius: 8px" />
               </div>
               <div style="margin-right:10px;float:right;width:65%;">
                    <p>Dear students,</p>
                     <p>
                       from Monday <span style="color:red">October 21</span> to <span style="color:red">Monday October 28</span> ,<br />
                       it is autumn leave and there is no school.
                    </p>
                    <p>
                       Enjoy the days off and don't forget to study for
                       the end-of-year exam.
                    </p>
                     <p>director,<br />
                        Jan Peeters
                    </p>
               </div>
           </div>

          <div with="100%" style="margin-top:15px;background-color:white" class="customFrame3">
            <p style="background-color:#35E66F;color:white;padding-left:10px;padding-top:3px;padding-bottom:3px" width="800px" >Info item 1/09/2024</p>
          <div style="margin-right:10px;float:left;width:65%;">
          </div>
              <h3>Welcome to our new website !</h3>
          </div>
       </div>
    </div>
</div>
</asp:Content>
