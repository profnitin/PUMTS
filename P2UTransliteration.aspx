<%@ Page Language="C#" AutoEventWireup="true" CodeFile="P2UTransliteration.aspx.cs" Inherits="P2UTransliteration" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .style1
        {
            width: 100%;
            border-collapse: collapse;
        }
        .style2
        {
            height: 19px;
            text-align: center;
        }
        .style3
        {
            height: 19px;
            text-align: center;
            font-family: Calibri;
            font-weight: bold;
            color: #003366;
            background-color: #FFFF99;
        }
        .style4
        {
            direction: ltr;
        }
        .style5
        {
            font-size: x-small;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <table cellpadding="0" class="style1">
            <tr>
                <td colspan="4" 
                    style="text-align: center; font-family: Calibri; font-size: x-large; font-weight: 700; color: #800000">
                    Punjabi to Urdu Transliteration Panel</td>
                <td style="text-align: center; font-family: Calibri; font-size: x-large; font-weight: 700; color: #800000">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style2" width="2%">
                    &nbsp;</td>
                <td align="center" class="style3">
                    Punjabi</td>
                <td width="2%">
                    &nbsp;</td>
                <td class="style3">
                    Urdu</td>
                <td class="style2">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style2" width="2%">
                </td>
                <td align="center" class="style2" width="47%">
                    <asp:TextBox ID="txtPunjabi" runat="server" Height="200px" TextMode="MultiLine" 
                        Width="100%"></asp:TextBox>
                </td>
                <td class="style2" width="2%">
                    &nbsp;</td>
                <td class="style2" width="47%">
                    <asp:TextBox ID="txtUrdu" runat="server" Height="200px" TextMode="MultiLine" 
                        Width="100%"></asp:TextBox>
                </td>
                <td class="style2" width="2%">
                    &nbsp;</td>
            </tr>
            <tr>
                <td width="2%">
                    &nbsp;</td>
                <td width="50%">
                    &nbsp;</td>
                <td width="2%">
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td width="2%">
                    &nbsp;</td>
                <td width="50%">
                    <asp:Button ID="btnTransliterate" runat="server" BackColor="Maroon" 
                        BorderStyle="None" Font-Bold="True" ForeColor="White" Text="Transliterate" 
                        onclick="btnTransliterate_Click" />
                </td>
                <td width="2%">
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td width="2%">
                    &nbsp;</td>
                <td width="50%">
                    &nbsp;</td>
                <td width="2%">
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style4" colspan="5" style="text-align: center">
                    <span class="style5"><strong>Development Team :-</strong></span><strong><br 
                        class="style5" />
                    </strong><span class="style5">1. Nitin Bansal, Punjabi University, Patiala</span><br 
                        class="style5" />
                    <span class="style5">2. Ajit Kumar, Associate Professor, Punjabi University, 
                    Patiala</span></td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>
