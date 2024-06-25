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
        public List<Sale> Sales { get; set; } = new List<Sale>();

        public Form1()
        {
            InitializeComponent();
            SelectCustomers();
            SelectProducts();
            SelectSales();
        }

        private void SelectCustomers()
        {
            var rep = new CustomerServices();
            Customers = rep.SelectAll().OrderBy(x => x.id).ToList();

            foreach (var item in Customers)
            {
                CustomerListView.Items.Add(new ListViewItem(new String[] { item.id.ToString(), item.name, item.address, item.phone, item.email }));
            }

            CreateSaleCustomer.DataSource = Customers;
            CreateSaleCustomer.DisplayMember = "name";
            CreateSaleCustomer.ValueMember = "id";

            UpdateSaleCustomer.DataSource = Customers;
            UpdateSaleCustomer.DisplayMember = "name";
            UpdateSaleCustomer.ValueMember = "id";
        }

        private void SelectProducts()
        {
            var rep = new ProductServices();
            Products = rep.SelectAll().OrderBy(x => x.id).ToList();

            foreach (var item in Products)
            {
                ProductListView.Items.Add(new ListViewItem(new String[] { item.id.ToString(), item.name, item.description, item.price.ToString(), item.qty.ToString() }));
            }

            CreateSaleProduct.DataSource = Products;
            CreateSaleProduct.DisplayMember = "name";
            CreateSaleProduct.ValueMember = "id";

            UpdateSaleProduct.DataSource = Products;
            UpdateSaleProduct.DisplayMember = "name";
            UpdateSaleProduct.ValueMember = "id";
        }

        private void SelectSales()
        {
            var rep = new SaleServices();
            Sales = rep.SelectAll().OrderBy(x => x.id).ToList();

            foreach (var item in Sales)
            {
                SaleListView.Items.Add(new ListViewItem(new String[] { item.id.ToString(), item.customer_id.ToString(), item.product_id.ToString(), item.qty.ToString() }));
            }

            UpdateSaleId.DataSource = Sales;
            UpdateSaleId.DisplayMember = "id";
            UpdateSaleId.ValueMember = "id";
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

        private void CreateProductButton_Click(object sender, EventArgs e)
        {
            try
            {
                var name = CreateProductName.Text;
                var desc = CreateProductDescription.Text;
                var price = CreateProductPrice.Value;
                var qty = CreateProductQuantity.Value;

                var product = new Product(name, desc, price, qty);
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
                var price = UpdateProductPrice.Value;
                var qty = UpdateProductQuantity.Value;

                var rep = new ProductServices();
                rep.Update(int.Parse(id), name, desc, price, qty);

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

        private void SaleCreateButton_Click(object sender, EventArgs e)
        {
            try
            {
                var customer = CreateSaleCustomer.SelectedValue;
                var product = CreateSaleProduct.SelectedValue;
                var qty = CreateSaleQty.Value;

                var selectedProduct = Products.Where(x => x.id == int.Parse(product.ToString())).FirstOrDefault();

                if (qty <= selectedProduct.qty)
                {
                    var sale = new Sale(int.Parse(customer.ToString()), int.Parse(product.ToString()), qty);
                    Sales.Add(sale);

                    var rep = new SaleServices();
                    rep.Create(sale);

                    SaleListView.Items.Clear();
                    SelectSales();

                    var repP = new ProductServices();
                    repP.Update(selectedProduct.id, selectedProduct.name, selectedProduct.description, selectedProduct.qty, (selectedProduct.qty - qty));

                    ProductListView.Items.Clear();
                    SelectProducts();
                }
                else
                    MessageBox.Show("Quantity can't be greater than stock.");
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message);
            }
        }

        private void UpdateSaleButton_Click(object sender, EventArgs e)
        {
            try
            {
                var id = UpdateSaleId.SelectedValue;
                var cust = UpdateSaleCustomer.SelectedValue;
                var prod = UpdateSaleProduct.SelectedValue;
                var qty = UpdateSaleQuantity.Value;

                var selectedProduct = Products.Where(x => x.id == int.Parse(prod.ToString())).FirstOrDefault();

                if (qty <= selectedProduct.qty)
                {
                    var rep = new SaleServices();
                    rep.Update(int.Parse(id.ToString()), int.Parse(cust.ToString()), int.Parse(prod.ToString()), qty);

                    SaleListView.Items.Clear();
                    SelectSales();

                    var repP = new ProductServices();
                    repP.Update(selectedProduct.id, selectedProduct.name, selectedProduct.description, selectedProduct.qty, (selectedProduct.qty - qty));

                    ProductListView.Items.Clear();
                    SelectProducts();
                }
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message);
            }
        }

        private void DeleteSaleButton_Click(object sender, EventArgs e)
        {
            try
            {
                var id = DeleteSaleId.Text;

                var rep = new SaleServices();
                rep.Delete(int.Parse(id));

                //CustomerStatus.Text = "Customer succesfully deleted!";

                SaleListView.Items.Clear();
                SelectSales();
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message);
            }
        }
    }
}