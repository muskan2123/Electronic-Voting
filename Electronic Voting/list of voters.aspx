﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="list of voters.aspx.cs" Inherits="Electronic_Voting.list_of_voters" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div align ="center">
            <asp:Label ID="Label1" runat="server" Font-Size="XX-Large" ForeColor="#3366FF" Text="Voters list"></asp:Label>
            <br />
            <br />
            <br />
            <asp:GridView ID="GridView1" runat="server" OnSelectedIndexChanged="GridView1_SelectedIndexChanged" Width="107px" AutoGenerateDeleteButton="True" AutoGenerateEditButton="True" Height="154px" OnRowCancelingEdit="GridView1_RowCancelingEdit" OnRowDeleting="GridView1_RowDeleting" OnRowEditing="GridView1_RowEditing" OnRowUpdating="GridView1_RowUpdating">
            </asp:GridView>
        </div>
    </form>
</body>
</html>
