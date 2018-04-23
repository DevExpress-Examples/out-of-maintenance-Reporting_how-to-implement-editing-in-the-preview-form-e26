using System;
using System.Windows.Forms;
// ...


namespace WindowsApplication1 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) {
            XtraReport1 rep = new XtraReport1();
            rep.ShowPreviewDialog();
        }
    }
}