<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="sqldatacode.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:TextBox ID="login_box" runat="server"></asp:TextBox>
        Login ID<br />
        <asp:TextBox ID="pwd_box" runat="server"></asp:TextBox>
        Password<br />
        <asp:Button ID="Login" runat="server" OnClick="Login_Click" Text="Login" />
        <br />
        <asp:Label ID="Label1" runat="server"></asp:Label>
        <br />
        <br />
        <asp:TextBox ID="Box_1" runat="server"></asp:TextBox>
        <asp:Label ID="Label2" runat="server" Text="Login ID"></asp:Label>
    
    </div>
        <asp:GridView ID="GridView1" runat="server">
        </asp:GridView>
        <p>
            <asp:Button ID="serach_button" runat="server" OnClick="search_button_Click" Text="Search" />
        </p>
    </form>
</body>
</html>
