
namespace programa3._3.Class
{
    
        class VerificadorNumero
        {
            public static string VerificarDigitos(int numero)
            {
                if (numero >= 10 && numero <= 99)
                {
                    return "El número tiene dos dígitos.";
                }
                else if (numero >= 1 && numero <= 9)
                {
                    return "El número tiene un dígito.";
                }
                else
                {
                    return "El número ingresado no es válido.";
                }
            }
        }
    }

