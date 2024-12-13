<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<%@ Register Assembly="Microsoft.ReportViewer.WebForms, Version=15.0.0.0, Culture=neutral, PublicKeyToken=89845dcd8080cc91" Namespace="Microsoft.Reporting.WebForms" TagPrefix="rsweb" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style>
        html, body, form {
            height: 100%;
            margin: 0;
            padding: 0;
        }

        #form1 {
            height: 100%;
        }

        #ReportViewer1 {
            width: 100%;
            height: 100%;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div style="height: 100%;">
            <asp:ScriptManager ID="ScriptManager1" runat="server">
            </asp:ScriptManager>
            <rsweb:ReportViewer ID="ReportViewer1" runat="server"
                Font-Names="Verdana" Font-Size="8pt"
                Width="793.7px" Height="1122.52px">
                <LocalReport ReportPath="report1.rdlc">
                </LocalReport>
            </rsweb:ReportViewer>
        </div>
    </form>
</body>
</html>
