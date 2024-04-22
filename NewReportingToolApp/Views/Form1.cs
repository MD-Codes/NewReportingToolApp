using System;
using System.Data;
using System.Windows.Forms;

namespace NewReportingToolApp
{
    public partial class Form1 : Form, IReportingTool
    {
        public event EventHandler SearchAttempted;
        public string message;
        public DataView dv { get; set; }
        public DataTable dt { get; set; }

        public Form1()
        {
            InitializeComponent();
            addColums();
           textBox.TextChanged += (sender, e) => SearchAttempted?.Invoke(sender, e);
        }
        public string TextBoxString
        {
            get => this.textBox.Text;
            set => this.textBox.Text = value;
        }

        public void SetDataView(DataView data)
        {
            dataGridView1.DataSource = data;
        }
        public void addColums()
        {
            dt = new DataTable();
            dt.Columns.Add("Name");
            dt.Columns.Add("Donors");
            dt.Columns.Add("Party");
            dt.Columns.Add("Total Amount");
            dv = new DataView(dt);
        }
    }
}
