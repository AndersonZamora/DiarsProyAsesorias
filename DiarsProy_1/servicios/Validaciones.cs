using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DiarsProy_1.servicios
{
    public class Validaciones : IValidaciones
    {
        public bool validarLetra(string nombre)
        {
            try
            {
                char[] charArr = nombre.ToCharArray();
                foreach (char cd in charArr)
                {
                    if (char.IsNumber(cd))
                        return false;
                }
            }
            catch (Exception e)
            {

            }
            return true;
        }

        public bool validarnUMEROS(string nombre)
        {
            try
            {
                char[] charArr = nombre.ToCharArray();
                foreach (char cd in charArr)
                {
                    if (!char.IsNumber(cd))
                        return false;
                }

            }
            catch (Exception e)
            {

            }
            return true;
        }
    }
}