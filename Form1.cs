using empresa_x.Context;
using empresa_x.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace empresa_x
{
    public partial class Form1 : Form
    {
        public List<Customer> Customers { get; set; } = new List<Customer>();

        public Form1()
        {
            InitializeComponent();
            SelectCustomers();
        }

        private void SelectCustomers()
        {
            var rep = new CustomerServices();
            Customers = rep.SelectAll();

            foreach (var item in Customers)
            {
                CustomerListView.Items.Add(new ListViewItem(new String[] { item.id.ToString(), item.name, item.address, item.phone, item.email }));
            }
        }

        private void CreateCustomerButton_Click(object sender, EventArgs e)
        {
            try
            {
                var name = CreateCustomerName.Text;
                var address = CreateCustomerAddress.Text;
                var phone = CreateCustomerPhone.Text;
                var email = CreateCustomerEmail.Text;

                var customer = new Customer(name, address, phone, email);
                Customers.Add(customer);

                var rep = new CustomerServices();
                rep.Create(customer);

                //CustomerStatus.Text = "Customer succesfully created!";

                CustomerListView.Items.Clear();
                SelectCustomers();
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message);
            }
        }

        private void UpdateCustomerButton_Click(object sender, EventArgs e)
        {
            try
            {
                var id = UpdateCustomerId.Text;
                var name = UpdateCustomerName.Text;
                var address = UpdateCustomerAddress.Text;
                var phone = UpdateCustomerPhone.Text;
                var email = UpdateCustomerEmail.Text;

                var rep = new CustomerServices();
                rep.Update(int.Parse(id), name, address, phone, email);

                //CustomerStatus.Text = "Customer succesfully updated!";

                CustomerListView.Items.Clear();
                SelectCustomers();
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message);
            }
        }

        private void DeleteCustomerButton_Click(object sender, EventArgs e)
        {
            try
            {
                var id = DeleteCustomerId.Text;

                var rep = new CustomerServices();
                rep.Delete(int.Parse(id));

                //CustomerStatus.Text = "Customer succesfully deleted!";

                CustomerListView.Items.Clear();
                SelectCustomers();
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message);
            }
        }
    }
}