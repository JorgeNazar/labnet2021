using System;
using System.Windows.Forms;
using tp2.Logic;


namespace tp2.WinFormsUI
{
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }
        private void btnPunto1_Click(object sender, EventArgs e)
        {
            try
            {
                Operaciones operaciones  = new Operaciones();
                operaciones.Punto1();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ExceptionMessage());
            }
            finally
            {
                MessageBox.Show("La operación finalizo".ExceptionMessage());
            }

        }
        private void btnPunto2_Click(object sender, EventArgs e)
        {
            #region Objetos
            MensajePersonalizado mensajeChuck = new MensajePersonalizado();
            Operaciones operaciones = new Operaciones();
            #endregion

            int dividendo;
            int divisor;

            try
            {
                dividendo = Int32.Parse(txtDividendo.Text.Trim());
                divisor = Int32.Parse(txtDivisor.Text.Trim());

                MessageBox.Show("Esto se va a descontrolar!!".ExceptionMessage());
                operaciones.Punto2(dividendo, divisor);
            }
            catch (DivideByZeroException  ex)
            {
                mensajeChuck.Show();
                MessageBox.Show($"Solo CHUCK NORRIS divide por cero!! {ex.Message}".ExceptionMessage());
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ni Dios sabe porque se rompio:  {ex.Message}".ExceptionMessage());
            }


        }

        private void btnPunto3_Click(object sender, EventArgs e)
        {
            Operaciones operaciones = new Operaciones();

            try
            {
                operaciones.Punto3();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ExceptionMessage());
            }
        }

        private void btnPunto4_Click(object sender, EventArgs e)
        {
            Operaciones operaciones = new Operaciones();

            try
            {
                operaciones.Punto4();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ExceptionMessage());
            }
        }
    }
}
