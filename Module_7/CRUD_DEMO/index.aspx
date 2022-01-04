<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="MySQLConnector.index" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .style1 {
            width: 100%;
        }
        .style2 {
            width: 255px;
        }
        .style3 {
            width: 135px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <div style="font-size:x-large" align="center">Tutor Program Form</div>
            <br />

            <table class="style1">
                <tr>
                    <td class="style2">&nbsp;</td>
                    <td class="style3"> ID </td>
                    <td>
                        <asp:TextBox ID="TextBox1" runat="server" Font-Size="Medium"  Width="268px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="style2">&nbsp;</td>
                    <td class="style3">Name</td>
                    <td>
                        <asp:TextBox ID="TextBox2" runat="server" Font-Size="Medium"  Width="268px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="style2">&nbsp;</td>
                    <td class="style3">Country</td>
                    <td>
                        <asp:TextBox ID="TextBox5" runat="server" Font-Size="Medium"  Width="268px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="style2">&nbsp;</td>
                    <td class="style3">Age</td>
                    <td>
                        <asp:TextBox ID="TextBox3" runat="server" Font-Size="Medium"  Width="268px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="style2">&nbsp;</td>
                    <td class="style3">Language</td>
                    <td>
                        <asp:TextBox ID="TextBox4" runat="server" Font-Size="Medium"  Width="268px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="style2">&nbsp;</td>
                    <td class="style3">&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="style2">&nbsp;</td>
                    <td class="style3">&nbsp;</td>
                    <td>
                        <asp:Button ID="Button1" runat="server" BorderColor="Black" Font-Bold="True"  OnClick="Button1_Click" Text="Insert" Width="78px" />
                    &nbsp;
                        <asp:Button ID="Button2" runat="server" BorderColor="Black" Font-Bold="True" OnClick="Button2_Click" Text="Update" Width="78px" />
                    &nbsp;
                        <asp:Button ID="Button3" runat="server" BorderColor="Black" Font-Bold="True" OnClick="Button3_Click" Text="Delete" Width="78px" />
                    &nbsp;
                        <asp:Button ID="Button4" runat="server" BorderColor="Black" Font-Bold="True" OnClick="Button4_Click" Text="View" Width="78px" />
                    &nbsp;</td>
                </tr>
                <tr>
                    <td class="style2">&nbsp;</td>
                    <td class="style3">&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="style2">&nbsp;</td>
                    <td class="style3">&nbsp;</td>
                    <td>
                        <asp:GridView ID="GridView1" runat="server" Width="683px">
                        </asp:GridView>
                    </td>
                </tr>
            </table>

        </div>
    </form>
</body>
</html>
