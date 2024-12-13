//------------------------------------------------------------------
// <copyright company="Microsoft">
//     Copyright (c) Microsoft.  All rights reserved.
// </copyright>
//------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Drawing.Printing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Microsoft.Reporting.WebForms;

public partial class _Default : System.Web.UI.Page 
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            // Reset the ReportViewer
            ReportViewer1.Reset();
            LocalReport report = ReportViewer1.LocalReport;

            // Set the path to the RDLC file
            report.ReportPath = Server.MapPath("~/report1.rdlc");

            // Define A4 page dimensions and margins
            const double a4Width = 8.27;  // A4 width in inches
            const double a4Height = 11.69; // A4 height in inches
            const double margin = 0.5;   // Margin in inches

            // Dimensions for the TextBox
            double textBoxWidth = 7.0;  // Width of the TextBox in inches
            double textBoxHeight = 1.0; // Height of the TextBox in inches

            // Calculate positions for centering the TextBox
            double textBoxLeft = (a4Width - textBoxWidth) / 2; // Horizontal center
            double textBoxTop = (a4Height - textBoxHeight) / 2; // Vertical center

            // Pass these positions as parameters to the RDLC
            ReportParameter[] parameters = new ReportParameter[]
            {
            new ReportParameter("TextBoxLeft", textBoxLeft.ToString("F2")), // Left position
            new ReportParameter("TextBoxTop", textBoxTop.ToString("F2"))    // Top position
            };

            // Add the parameters to the report
            report.SetParameters(parameters);

            // Refresh the ReportViewer
            ReportViewer1.LocalReport.Refresh();
        }
    }
}
