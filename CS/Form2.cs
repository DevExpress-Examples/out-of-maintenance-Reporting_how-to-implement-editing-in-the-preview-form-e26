using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WindowsApplication1 {
    public partial class Form2 : Form {
        public string str = "";
        public Form2() {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) {
            str = this.textBox1.Text;
            this.Close();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            this.textBox1.Text = str;
        }
    }
}