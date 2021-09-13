using System;


namespace tp2.Logic
{
    public class Operaciones
    {
        private int varResultado;
        public void Punto1()
        {
            try
            {
                int Dividendo = 10;
                int Divisor = 0;
                
                
                varResultado.Divisiones(Dividendo, Divisor);

            }
            catch (InvalidOperationException ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                throw ex;
            }
           
        }

        public void Punto2(int dividendo, int divisor)
        {
            try
            {

                varResultado.Divisiones(dividendo, divisor);
            }
            catch (DivideByZeroException ex)
            {
                throw ex;
            }
        }

        public void Punto3()
        {
            throw new DivideByZeroException();
        }

        public void Punto4()
        {
            throw new ExcepcionPersonalizada(" - Mensaje pesonalizado");
        }
    }
    public static class Extensions
    {
        public static string ExceptionMessage(this string message)
        {
            return message;
        }

        public static void Divisiones(this int resultado, int dividendo, int divisor)
        {
            resultado = dividendo / divisor;
        }
    }
}
