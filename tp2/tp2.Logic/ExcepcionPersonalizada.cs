using System;

namespace tp2.Logic
{
    public class ExcepcionPersonalizada : Exception
    {
        public override string Message => "Mensaje sobrecargado: " + base.Message;
        public ExcepcionPersonalizada(string mensaje) : base(mensaje)
        {
           
        }
    }
}
