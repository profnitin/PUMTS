<%@ Page Language="C#" AutoEventWireup="true" CodeFile="P2UTransliteration.aspx.cs" Inherits="P2UTransliteration" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .style5
        {
            font-size: x-small;
        }
        #Original
        {
            font-family: Arial;
            font-weight: 700;
            font-size: small;
        }
        .style7
        {
            width: 100%;
            border-collapse: collapse;
        }
        .style11
        {
            height: 19px;
        }
        .style12
        {
            height: 19px;
            font-family: Calibri;
            color: #000066;
            text-align: center;
        }
        .style13
        {
            height: 19px;
            font-size: large;
        }
        .style14
        {
            background-color: #FFFFCC;
        }
        .style15
        {
            font-weight: bold;
            font-size: small;
            font-family: Calibri;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <table cellpadding="0" class="style7">
        <tr>
            <td width="15%">
                &nbsp;</td>
            <td colspan="3">
                    <img alt="P2UTransliteration" src="Images/1.png" /></td>
            <td width="15%">
                &nbsp;</td>
        </tr>
        <tr>
            <td width="15%" class="style11">
                </td>
            <td width="34%" class="style12" style="background-color:#3399FF">
                <strong style="font-size: large; color: #FFFFFF">PUNJABI</strong></td>
            <td width="2%" class="style11">
                </td>
            <td width="34%" class="style13" 
                style="background-color:#3399FF; font-weight: 700; text-align: center; font-family: Calibri; color: #FFFFFF;">
                URDU</td>
            <td width="15%" class="style11">
                </td>
        </tr>
        <tr>
            <td width="15%">
                &nbsp;</td>
            <td width="34%">
                    <asp:TextBox ID="txtPunjabi" runat="server" Height="200px" TextMode="MultiLine" 
                        Width="99%"></asp:TextBox>
                </td>
            <td width="2%">
                &nbsp;</td>
            <td width="34%">
                    <asp:TextBox ID="txtUrdu" runat="server" Height="200px" TextMode="MultiLine" 
                        Width="99%" Enabled="False"></asp:TextBox>
                </td>
            <td width="15%">
                &nbsp;</td>
        </tr>
        <tr>
            <td width="15%">
                &nbsp;</td>
            <td width="34%">
                &nbsp;</td>
            <td width="2%">
                &nbsp;</td>
            <td width="34%">
                &nbsp;</td>
            <td width="15%">
                &nbsp;</td>
        </tr>
        <tr>
            <td width="15%">
                &nbsp;</td>
            <td width="34%">
                    <asp:Button ID="btnTransliterate" runat="server" BackColor="#0066FF" 
                        BorderStyle="None" Font-Bold="True" ForeColor="White" Text="Transliterate" 
                        onclick="btnTransliterate_Click" />
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Button ID="btnTransliterate0" runat="server" BackColor="#0066FF" 
                        BorderStyle="None" Font-Bold="True" ForeColor="White" Text="Clear Text" 
                        onclick="btnTransliterate0_Click" />
                </td>
            <td width="2%">
                &nbsp;</td>
            <td width="34%" class="style14" 
                style="font-weight: 700; font-family: Calibri; font-size: medium">
                Pujabi News Website:</td>
            <td width="15%">
                &nbsp;</td>
        </tr>
        <tr>
            <td colspan="5" style="font-size: xx-small">
                &nbsp;</td>
        </tr>
        <tr>
            <td width="15%">
                &nbsp;</td>
            <td width="34%">
                    <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Names="Arial" 
                        Font-Size="Small" style="color: #800000" Text="Upload Punjabi Text File:"></asp:Label>
&nbsp;<asp:FileUpload ID="FileUpload1" runat="server" />
                </td>
            <td width="2%">
                &nbsp;</td>
            <td width="34%" class="style15">
                <a href="https://www.bbc.com/punjabi">https://www.bbc.com/punjabi</a> </td>
            <td width="15%">
                &nbsp;</td>
        </tr>
        <tr>
            <td width="15%">
                &nbsp;</td>
            <td width="34%">
                &nbsp;</td>
            <td width="2%">
                &nbsp;</td>
            <td width="34%" class="style15">
                <a href="https://punjabinewsonline.com/">https://punjabinewsonline.com/</a> </td>
            <td width="15%">
                &nbsp;</td>
        </tr>
        <tr>
            <td width="15%">
                &nbsp;</td>
            <td width="34%">
                    <asp:Label ID="Label2" runat="server" Font-Bold="True" Font-Names="Arial" 
                        Font-Size="Small" style="color: #FF0000" Text="Download Urdu Text File:" 
                        Visible="False"></asp:Label>
&nbsp;&nbsp;<a id="Original" runat="server" href="\HR\asstt\Converter.txt" target="_blank" 
                        visible="False">Download</a></td>
            <td width="2%">
                &nbsp;</td>
            <td width="34%" class="style15">
                <a href="https://punjab.news18.com/">https://punjab.news18.com/</a></td>
            <td width="15%">
                &nbsp;</td>
        </tr>
        <tr>
            <td width="15%">
                &nbsp;</td>
            <td width="34%">
                &nbsp;</td>
            <td width="2%">
                &nbsp;</td>
            <td width="34%">
                &nbsp;</td>
            <td width="15%">
                &nbsp;</td>
        </tr>
        <tr>
            <td colspan="5" style="text-align: center">
                    <span class="style5"><strong>Development Team :-</strong></span><strong><br 
                        class="style5" />
                    </strong><span class="style5">1. Nitin Bansal, Punjabi University, Patiala</span><br 
                        class="style5" />
                    <span class="style5">2. Ajit Kumar, Associate Professor, Multai Mal Modi College, 
                    Patiala</span></td>
        </tr>
    </table>
    </form>
</body>
</html>
