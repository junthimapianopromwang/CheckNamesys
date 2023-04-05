using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace รายวิชาที่เปิดสอน
{
    public partial class เช็คชื้่อนักศึกษา : Form
    {
        Infomation Info;
        public เช็คชื้่อนักศึกษา()
        {
            InitializeComponent();
        }

        public Infomation GetInfo()
        {
            return Info;
        }

        private void Addbutton1_Click(object sender, EventArgs e)
        {
            string No = textBox1.Text;
            string Classname = textBox2.Text;
            int Marean = int.Parse(Ma_textBox4.Text);
            int maima = int.Parse(textBox3.Text);

            Info = new Infomation()
            {
                No = No,
                NameClass = Classname,
                marean = Marean,
                kad = maima,
                date = dateTimePicker1.Value
                
            };
            this.DialogResult = DialogResult.OK;

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void N0_label1_Click(object sender, EventArgs e)
        {

        }
    }
    }

