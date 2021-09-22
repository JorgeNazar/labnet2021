using System;
using System.Windows.Forms;
using TP4.EF.Entities;
using TP4.EF.Logic;

namespace TP4.EF.UI
{
    public partial class TP4UI : Form
    {
        public CustomersLogic customerLogic = new CustomersLogic();
        public EmployeesLogic employeesLogic = new EmployeesLogic();
        public TP4UI()
        {
            InitializeComponent();
        }

        private void btnAllCustomer_Click(object sender, EventArgs e)
        {
            var clientes = customerLogic.GetAll();
            gridDB.DataSource = clientes;
        }

        private void btnAllEmployees_Click(object sender, EventArgs e)
        {
            var empleados = employeesLogic.GetAll();
            gridDB.DataSource = empleados;
            
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Customers cliente = customerLogic.GetByID(txtBuscar.Text);
           
                //gridDB.SelectedCells[2];
                if (cliente == null)
                {
                    MessageBox.Show("No Existe el ID");
                }
                else
                { 
                    txtCustomerID.Text = cliente.CustomerID;
                    txtCompanyName.Text = cliente.CompanyName;
                    txtContactName.Text = cliente.ContactName;
                    txtContactTitle.Text = cliente.ContactTitle;
                    txtAddress.Text = cliente.Address;
                    txtCity.Text = cliente.City;
                    txtRegion.Text = cliente.Region;
                    txtPostalCode.Text = cliente.PostalCode;
                    txtCountry.Text = cliente.Country;
                    txtPhone.Text = cliente.Phone;
                    txtFax.Text = cliente.Fax;
                }
            
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Customers customer = new Customers();

            customer.CustomerID  = txtCustomerID.Text;
            customer.CompanyName = txtCompanyName.Text;
            customer.ContactName = txtContactName.Text;
            customer.ContactTitle = txtContactTitle.Text;
            customer.Address = txtAddress.Text;
            customer.City = txtCity.Text;
            customer.Region = txtRegion.Text;
            customer.PostalCode = txtPostalCode.Text;
            customer.Country = txtCountry.Text;
            customer.Phone = txtPhone.Text;
            customer.Fax = txtFax.Text;

            customerLogic.Modify(customer);
        }
    }
}
