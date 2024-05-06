using NewReportingToolApp.Models;
using System;
using System.Collections.Generic;
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
        private readonly List<Observer> _observers = new List<Observer>();

        public Form1()
        {
            InitializeComponent();
            addColums();
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
        public void RegisterObserver(Observer observer)
        {
            _observers.Add(observer);
        }

        private void NotifyObservers()
        {
            foreach (var observer in _observers)
            {
                observer.OnSearchTextChanged(TextBoxString);
            }
        }

        private void textBox_TextChanged(object sender, EventArgs e)
        {
            NotifyObservers();
        }
    }
}
