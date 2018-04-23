using System;
using System.Collections;
using System.Data;
using System.Drawing.Printing;
using DevExpress.XtraReports.UI;
// ...

namespace WindowsApplication1 {
    public partial class XtraReport1 : XtraReport {
        public XtraReport1() {
            InitializeComponent();
        }

        private void xrLabel4_PreviewDoubleClick(object sender, PreviewMouseEventArgs e) {
            Form2 frm = new Form2();
            XRLabel label = e.Brick.BrickOwner as XRLabel;
            string fieldName = label.DataBindings["Text"].DataMember.Substring(label.DataBindings["Text"].DataMember.LastIndexOf('.') + 1);
            frm.str = ((DataRowView)e.Brick.Value)[fieldName].ToString();
            frm.ShowDialog();
            ((DataRowView)e.Brick.Value)[fieldName] = frm.str;
            this.CreateDocument(false);
        }

        private void xrLabel4_BeforePrint(object sender, PrintEventArgs e) {
            ((XRLabel)sender).Tag = this.DetailReport.GetCurrentRow();
        }
    }
}
