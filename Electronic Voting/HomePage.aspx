<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="HomePage.aspx.cs" Inherits="Electronic_Voting.HomePage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    
<link rel="stylesheet" href="StyleSheet1.css">
</head>
<body style=" background-image:url(evoting.jpg); background-size:cover; background-align:center ">
    
&nbsp;<form id="form1" runat="server">
      
     
      
       <div class="topnav">
  <a  href="#logout">LogOut</a>
           <a href="admin login.aspx">Admin</a>
  <a href="VoterSignIn.aspx">Sign In</a>
  
  <a class="active" href="#home">Home</a>
           <asp:ImageMap ID="ImageMap1" runat="server" Height="46px" ImageUrl="~/evoting1.jpg" OnClick="ImageMap1_Click" Width="64px">
           </asp:ImageMap>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
           <asp:Label ID="Label1" runat="server" Font-Size="XX-Large" ForeColor="White" Text="E-VOTING"></asp:Label>
</div>
           <hr />
        <hr />
    
        <p>
            &nbsp;</p>
           <asp:LinkButton type="button" class="btn btn-primary" ID="LinkButton1" runat="server" Font-Size="XX-Large" ForeColor="White" OnClick="LinkButton1_Click">Admin</asp:LinkButton>
    
           <p>
               &nbsp;</p>
           <p>
           <asp:LinkButton type="button" class="btn btn-primary" ID="LinkButton2" runat="server" Font-Size="XX-Large" ForeColor="White" OnClick="LinkButton2_Click" Font-Underline="True">Voter</asp:LinkButton>
        </p>
           <br />
           <br />
           <asp:LinkButton ID="LinkButton3" runat="server" Font-Bold="False" Font-Size="XX-Large" Font-Underline="True" ForeColor="White">Elections</asp:LinkButton>
           <br />
           <br />
       </form>
</body>
</html>
