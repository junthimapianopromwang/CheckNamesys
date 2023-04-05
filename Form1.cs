using Microsoft.VisualBasic;
using System.Data;
using รายวิชาที่เปิดสอน;

namespace CheckNamesys
{
    public partial class Form1 : Form
    {

        public List<Infomation> listma = new List<Infomation>();

        public Form1()
        {
            InitializeComponent();
        }

        private void CH(object? sender, EventArgs e)
        {
            DateTimePicker picker = (DateTimePicker)sender;
            dataGridView1.Rows.Add("", "", "", "", picker.Value);
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            เช็คชื้่อนักศึกษา chk = new เช็คชื้่อนักศึกษา();
            chk.DialogResult = DialogResult.OK;
            chk.ShowDialog();
            if (chk.DialogResult == DialogResult.OK)
            {
                listma.Add(chk.GetInfo());
                RefreshDataGrid();  
            }
        }
        private void RefreshDataGrid()
        {
            dataGridView1.Rows.Clear();
            foreach (Infomation cc_ in listma)
            {
                dataGridView1.Rows.Add(cc_.No, cc_.NameClass, cc_.marean,cc_.kad, cc_.date.ToString());
            }
        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFile = new SaveFileDialog();
            saveFile.FileName = "All Product";
            saveFile.Filter = "CSV|*.csv";
            saveFile.ShowDialog();

            if (saveFile.FileName != "")
            {
                using (StreamWriter file = new StreamWriter(saveFile.FileName))
                {
                    file.WriteLine("ProductName,Catagory,Amount");
                    foreach (Infomation item in listma)
                    {
                        file.WriteLine($"{item.No}, {item.NameClass}, {item.marean}, {item.kad}, {item.date.ToString()}");
                    }
                }
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Show the OpenFileDialog.
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "CSV files (*.csv)|*.csv|All files (*.*)|*.*";
            openFileDialog.RestoreDirectory = true;
            MessageBox.Show("icon code");
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                if (openFileDialog.FileName != "")
                {
                    listma.Clear();
                    dataGridView1.Rows.Clear();
                    using (StreamReader file = new StreamReader(openFileDialog.FileName))
                    {
                        string line;
                        int count = 0;
                        while ((line = file.ReadLine()) != null)
                        {
                            if (count == 0)
                            {
                                count++;
                                continue;
                            }
                            else
                            {
                                string[] data = line.Split(',');
                                listma.Add(new Infomation()
                                {
                                    No = data[0],
                                    NameClass = data[1],
                                    marean = int.Parse(data[2]),
                                    kad = int.Parse(data[3])
                                });
                            }
                        }

                        RefreshDataGrid();
                    }
                }
            }
        }
    }
}