<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebApplication5.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        Ex1_Global events of Applications:<asp:Button ID="Button1" runat="server" Text="StopSession" />    
        <br />
        <br />
        <asp:Label ID="Label4" runat="server" Text="Ex2 State Managment:"></asp:Label>  
             <div>
               Click for Viev State: <asp:Button ID="Button2" runat="server"  Text="0" />             
            </div>

            <div>
               Click for Session: <asp:Button ID="Button3" runat="server" Text="0" />
            </div>
         <br />
        <div>
            Ex3<br/>
            ax2 + bx + c = 0 <br />
           <asp:Label ID="Label1" runat="server" Text="A:"> <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox></asp:Label>   <br />
           <asp:Label ID="Label2" runat="server" Text="B:"> <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox></asp:Label>   <br />
           <asp:Label ID="Label3" runat="server" Text="C:"> <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox></asp:Label>   <br />
           <asp:Button ID="Button4" runat="server" Text="Result" />  <br />
           <asp:Label ID="Result" runat="server" Text=""></asp:Label>
        </div> 
    </div>
    </form>
</body>
</html>
