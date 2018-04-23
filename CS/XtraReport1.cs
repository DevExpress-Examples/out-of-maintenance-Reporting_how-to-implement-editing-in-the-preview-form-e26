using System;
using System.Collections;
using DevExpress.XtraReports.UI;
using System.Drawing.Printing;
// ...

namespace WindowsApplication1 {
    public partial class XtraReport1 : XtraReport {
        ArrayList values = new ArrayList();
        int i;
        public XtraReport1() {
            InitializeComponent();
            i = 0;
        }

        private void xrLabel4_PreviewDoubleClick(object sender, PreviewMouseEventArgs e) {
            Form2 frm = new Form2();
            frm.str = e.Brick.Text;
            frm.ShowDialog();
            string s = frm.str;
            i = 0;
            values.Add(new IDInfo(Convert.ToInt32(e.Brick.Value), s));
            this.CreateDocument();
        }

        private void xrLabel4_BeforePrint(object sender, PrintEventArgs e) {
            ((XRLabel)sender).Tag = i;
            for(int j = 0; j < values.Count; j++) {
                if(((IDInfo)values[j]).ID == i) {
                    ((XRLabel)sender).Text = ((IDInfo)values[j]).val;
                }
            }
            i++;
        }
    }
    public class IDInfo {
        public IDInfo(int i, string v) { ID = i; val = v; }
        public int ID;
        public string val;
    }
}
