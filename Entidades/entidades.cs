using System;
using System.Text;
using System.Globalization;
using System.Runtime.CompilerServices;

namespace Entidades
{
    public enum Esistema { Decimal, Binario }

    public class Numeracion
    {

        private Esistema sistema;
        private double valor;
        private bool valido = true;
        private string error;


        //inicializadores

        public Esistema Sistema
        {
            get
            {
                return this.sistema;
            }
        }

        public string Valor
        {
            get
            {
                if (!this.valido)
                {
                    return this.error;
                }
                if (this.sistema == Esistema.Binario)
                {
                    return Numeracion.DecimalABinario(this.valor);
                }
                return valor.ToString();
            }

        }

        public string Error
        {
            set
            {
                this.error = value;
                this.valido = false;
                this.valor = double.MinValue;
            }
        }


        private void InicializarValores(string valor, Esistema sistema)
        {
            this.sistema = sistema;
            if (sistema == Esistema.Binario && Numeracion.EsBinario(valor))
            {
                this.valor = Numeracion.BinarioADecimal(valor);
            }else if (double.TryParse(valor, out double posibleAsignacion))
            { 
                this.valor = posibleAsignacion;
            }else
            {
                this.Error = "el numero ingresado no es valido";
            }
        
        }
        public Numeracion(string valor, Esistema sistema)
        {
            InicializarValores(valor, sistema);
        }

        public Numeracion(string valor) : this(valor, Esistema.Decimal) {}

        public Numeracion(double valor, Esistema sistema):this(valor.ToString(), sistema){}


        //metodo publico
        public string? ConvertirA(Esistema sistema)
        {
            if (!this.valido)
            {
                return this.error;
            }
            if (sistema == Esistema.Decimal)
            {
                return this.valor.ToString();
            }
            return Numeracion.DecimalABinario(this.valor);

        }


        //metodos privados

        private static bool EsBinario(string valor)
        {
            foreach(char c in valor)
            {
                if (c != '0' && c != '1')
                {
                    return false;
                }
            }
            return true;
        }

        private static string DecimalABinario(double numeroConComa)
        {
            int numero = (int)numeroConComa;
            if (numero == 0)
            {
                return "0";
            }
            if (numero < 0)
            {
                return "Error: no se puede mostrar numeros negativos en binario";
            }
            StringBuilder binario = new StringBuilder();
            int largoTotal = 1;
            int numeroResta = 1;
            while (numero >= numeroResta * 2)
            {
                largoTotal++;
                numeroResta *=2;
            }
            numero -= numeroResta;
            binario.Append('1');
            while (numero > 0)
            {
                numeroResta = numeroResta / 2;
                if (numeroResta <= numero)
                {
                    binario.Append('1');
                    numero -= numeroResta;
                }else{
                    binario.Append('0');
                }
            }
            int cerosFinales = binario.Length;
            while (cerosFinales < largoTotal)
            {
                binario.Append('0');
                cerosFinales++;
            }
            return binario.ToString();
        }
        private static string DecimalABinario(string numero)
        {
            int.TryParse(DecimalABinario(numero), out int numeroEnInt);
            return DecimalABinario(numeroEnInt);
        }

        public static double BinarioADecimal(string? binario)
        {
            char[] arrayBinario = binario.ToCharArray();
            Array.Reverse(arrayBinario);
            int total = 0;
            int aumento = 1;
            foreach (char numerito in arrayBinario)
            {
                string comparar = numerito.ToString();
                if (comparar == "1")
                {
                    total += aumento;
                }
                aumento = aumento * 2;
            }
            return (double)total;
        }

        private void validarInteraccion(Numeracion n1, Numeracion n2)
        {
            if (n1 != n2)
            {
                this.Error = "No se puede operar entre numeros de diferentes sistemas";
            }
            if(!n1.valido || !n2.valido)
            {
                this.Error = "Uno de los dos operandos es invalido";
            }
        }       

        public static bool operator ==(Esistema sistema,Numeracion n1)
        {
            return n1.sistema == sistema;
        }
        public static bool operator !=(Esistema sistema, Numeracion n1)
        {
            return !(sistema == n1);
        }

        public static bool operator ==(Numeracion n2, Numeracion n1)
        {
            return (n1.sistema == n2.sistema);
        }
       
        public static bool operator !=(Numeracion n2, Numeracion n1)
        {
            return !(n2 == n1);
        }

        public static Numeracion operator -(Numeracion n1, Numeracion n2)
        {
            Numeracion devuelve = new Numeracion((n1.valor - n2.valor), n1.sistema);
            devuelve.validarInteraccion(n1, n2);
            return devuelve;
        }
        public static Numeracion operator +(Numeracion n1, Numeracion n2)
        {
            Numeracion devuelve = new Numeracion((n1.valor + n2.valor), n1.sistema);
            devuelve.validarInteraccion(n1, n2);
            return devuelve;
        }
        public static Numeracion operator *(Numeracion n1, Numeracion n2)
        {
            Numeracion devuelve = new Numeracion((n1.valor * n2.valor), n1.sistema);
            devuelve.validarInteraccion(n1, n2);
            return devuelve;
        }
        public static Numeracion operator /(Numeracion n1, Numeracion n2)
        {
            Numeracion devuelve = new Numeracion((n1.valor / n2.valor), n1.sistema);
            if (n2.valor == 0)
            {
                devuelve.Error = "Error,no se puede dividir por 0";
            }
            devuelve.validarInteraccion(n1, n2);
            return devuelve;
        }
    }
    public class Operacion
    {
        private Numeracion primerOperando;
        private Numeracion segundoOperando;

        public Operacion(Numeracion primerOperando,Numeracion segundoOperando)
        {
            this.primerOperando = primerOperando;
            this.segundoOperando = segundoOperando;
        }


        public Numeracion PrimerOperando
        {
            get
            {
                return primerOperando;
            }
            set
            {
                primerOperando = value;
            }
        }
        public Numeracion SegundoOperando
        {
            get
            {
                return this.segundoOperando;
            }
            set 
            { 
                this.segundoOperando = value; 
            }
        }
        public Numeracion Operar(char operador)
        {
            if (this.primerOperando is null || this.segundoOperando is null)
            {
                Numeracion devuelve = new Numeracion("0");
                devuelve.Error = "No se definio uno de los dos operadores";
                return devuelve; 
            }
            switch(operador)
            {
                case '-':
                    return this.primerOperando -this.segundoOperando;
                case '*':
                    return this.primerOperando *this.segundoOperando;
                case '/':
                    return this.primerOperando / this.segundoOperando;
            }
            return this.primerOperando + this.segundoOperando;
        }
    }
}