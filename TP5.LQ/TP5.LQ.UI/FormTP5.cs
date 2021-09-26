using System;
using System.Windows.Forms;
using TP5.LQ.Logic;
namespace TP5.LQ.UI
{
    public partial class FormTP5 : Form
    {
        CustomersLogic customerLogic = new CustomersLogic();
        ProductsLogic productLogic = new ProductsLogic();
        public FormTP5()
        {
            InitializeComponent();
        }

        private void btnPunto1_Click(object sender, EventArgs e)
        {
            lblConsigna.Text = "Punto 1: Query para devolver objeto customer";
            var clientes = customerLogic.QueryOne();
            gridDB.DataSource = clientes;
        }

        private void btnPunto2_Click(object sender, EventArgs e)
        {
            lblConsigna.Text = "Punto 2: Query para devolver todos los productos sin stock";
            var productos = productLogic.QueryTwo();
            gridDB.DataSource = productos;
        }

        private void btnPunto3_Click(object sender, EventArgs e)
        {
            lblConsigna.Text = "Punto 3: Query para devolver todos los productos que tienen stock y que cuestan más de 3 por unidad";
            var productos = productLogic.QueryThree();
            gridDB.DataSource = productos;
        }

        private void btnPunto4_Click(object sender, EventArgs e)
        {
            lblConsigna.Text = "Punto 4: Query para devolver todos los customers de la Región WA";
            var clientes = customerLogic.QueryFour();
            gridDB.DataSource = clientes;
        }

        private void btnPunto5_Click(object sender, EventArgs e)
        {
            lblConsigna.Text = "Punto 5: Query para devolver el primer elemento o nulo de una lista de productos donde el ID de producto sea igual a 789";
            var productos = productLogic.QueryFive();
            gridDB.DataSource = productos;
        }

        private void btnPunto6_Click(object sender, EventArgs e)
        {
            lblConsigna.Text = "Punto 6: Query para devolver los nombre de los Customers. Mostrarlos en Mayuscula y en Minuscula.";
            var clientes = customerLogic.QuerySix();
            gridDB.DataSource = clientes;
        }

        private void btnPunto7_Click(object sender, EventArgs e)
        {
            lblConsigna.Text = "Punto 7: Query para devolver Join entre Customers y Orders donde los customers sean de la  Región WA y la fecha de orden sea mayor a 1 / 1 / 1997";
            var clientes = customerLogic.QuerySeven();
            gridDB.DataSource = clientes;
        }

        private void btnPunto8_Click(object sender, EventArgs e)
        {
            
            try
            {
                lblConsigna.Text = "Punto 8: Query para devolver los primeros 3 Customers de la  Región WA";
                var clientes = customerLogic.QueryEight();
                gridDB.DataSource = clientes;

            }
            catch (ArgumentOutOfRangeException ex)
            {

                MessageBox.Show("La tabla Customers posee menos de tres clientes pertenecientes a la región WA");
            }
        }

        private void btnPunto9_Click(object sender, EventArgs e)
        {
            lblConsigna.Text = "Punto 9: Query para devolver lista de productos ordenados por nombre";
            var productos = productLogic.QueryNine();
            gridDB.DataSource = productos;
        }

        private void btnPunto10_Click(object sender, EventArgs e)
        {
            lblConsigna.Text = "Punto 10: Query para devolver lista de productos ordenados por unit in stock de mayor a menor";
            var productos = productLogic.QueryTen();
            gridDB.DataSource = productos;
        }

        private void btnPunto12_Click(object sender, EventArgs e)
        {
            lblConsigna.Text = "Punto 12: Query para devolver el primer elemento de una lista de productos";
            var productos = productLogic.QueryTwelve();
            gridDB.DataSource = productos;
        }
    }
}
