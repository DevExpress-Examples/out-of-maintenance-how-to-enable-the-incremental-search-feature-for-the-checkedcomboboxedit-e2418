using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace DXSample {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }
        BindingList<Customer> GetCustomers() {
            BindingList<Customer> customers = new BindingList<Customer>();
            customers.Add(new Customer() { Id = 0, Name = "Alex", IsActive = true });
            customers.Add(new Customer() { Id = 1, Name = "Sarah", IsActive = true });
            customers.Add(new Customer() { Id = 2, Name = "Bob", IsActive = false });
            return customers;
        }
        private void Form1_Load(object sender, EventArgs e) {
            checkedComboBoxEdit.Properties.IncrementalSearch = true;
            checkedComboBoxEdit.Properties.DataSource = GetCustomers();
            checkedComboBoxEdit.Properties.DisplayMember = "Name";
            checkedComboBoxEdit.Properties.ValueMember = "Id";
        }
    }
    class Customer {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool IsActive { get; set; }
    }
}
