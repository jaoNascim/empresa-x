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
        public List<Product> Products { get; set; } = new List<Product>();

        public Form1()
        {
            InitializeComponent();
            SelectCustomers();
            SelectProducts();
        }

        private void SelectCustomers()
        {
            var rep = new CustomerServices();
            Customers = rep.SelectAll().OrderBy(x => x.id).ToList();

            foreach (var item in Customers)
            {
                CustomerListView.Items.Add(new ListViewItem(new String[] { item.id.ToString(), item.name, item.address, item.phone, item.email }));
            }

            DeleteCustomerIdCB.DataSource = Customers;
            DeleteCustomerIdCB.DisplayMember = "name";
            DeleteCustomerIdCB.ValueMember = "id";
        }

        private void SelectProducts()
        {
            var rep = new ProductServices();
            Products = rep.SelectAll().OrderBy(x => x.id).ToList();

            foreach (var item in Products)
            {
                ProductListView.Items.Add(new ListViewItem(new String[] { item.id.ToString(), item.name, item.description, item.price.ToString(), item.qty.ToString() }));
            }

            DeleteProductIdCB.DataSource = Products;
            DeleteProductIdCB.DisplayMember = "name";
            DeleteProductIdCB.ValueMember = "id";
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
                var id = DeleteCustomerIdCB.SelectedValue;

                var rep = new CustomerServices();
                rep.Delete(int.Parse(id.ToString()));

                //CustomerStatus.Text = "Customer succesfully deleted!";

                CustomerListView.Items.Clear();
                SelectCustomers();
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message);
            }
        }

        private void CreateProductButton_Click(object sender, EventArgs e)
        {
            try
            {
                var name = CreateProductName.Text;
                var desc = CreateProductDescription.Text;
                var price = CreateProductPrice.Text;
                var qty = CreateProductQuantity.Text;

                var product = new Product(name, desc, int.Parse(price), int.Parse(qty));
                Products.Add(product);

                var rep = new ProductServices();
                rep.Create(product);

                //CustomerStatus.Text = "Customer succesfully created!";

                ProductListView.Items.Clear();
                SelectProducts();
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message);
            }
        }

        private void UpdateProductButton_Click(object sender, EventArgs e)
        {
            try
            {
                var id = UpdateProductId.Text;
                var name = UpdateProductName.Text;
                var desc = UpdateProductDescription.Text;
                var price = UpdateProductPrice.Text;
                var qty = UpdateProductQuantity.Text;

                var rep = new ProductServices();
                rep.Update(int.Parse(id), name, desc, int.Parse(price), int.Parse(qty));

                //CustomerStatus.Text = "Customer succesfully updated!";

                ProductListView.Items.Clear();
                SelectProducts();
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message);
            }
        }

        private void DeleteProductButton_Click(object sender, EventArgs e)
        {
            try
            {
                var id = DeleteProductId.Text;

                var rep = new ProductServices();
                rep.Delete(int.Parse(id));

                //CustomerStatus.Text = "Customer succesfully deleted!";

                ProductListView.Items.Clear();
                SelectProducts();
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message);
            }
        }
    }
}