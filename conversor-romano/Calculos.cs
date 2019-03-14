using System;

namespace conversor_romano
{
    public class Calculos
    {
        public string converterInteiroRomano(int valorConverter)
        {
            if (valorConverter < 1 || valorConverter > 3000)
                throw new ArgumentException("O valor informado está fora do range esperado.");
            else
            {
                string teste = converter(valorConverter);
                Console.WriteLine(teste);
                return teste;
            }
        }

        private string converter(int valor)
        {
            int inteiro = 0;
            string romano = string.Empty;

            if (valor >= 1000)
            {
                inteiro = valor / 1000;
                valor = valor % 1000;
                for (int i = inteiro; i > 0; i--)
                    romano = romano + "M";
            }

            if (valor >= 500)
            {
                inteiro = valor / 500;
                valor = valor % 500;
                for (int i = inteiro; i > 0; i--)
                    romano = romano + "D";
            }


            if (valor >= 100)
            {
                inteiro = valor / 100;
                valor = valor % 100;
                for (int i = inteiro; i > 0; i--)
                    romano = romano + "C";
            }


            if (valor >= 50)
            {
                inteiro = valor / 50;
                valor = valor % 50;
                for (int i = inteiro; i > 0; i--)
                    romano = romano + "L";
            }

            if (valor >= 10)
            {
                inteiro = valor / 10;
                valor = valor % 10;
                for (int i = inteiro; i > 0; i--)
                    romano = romano + "X";
            }

            if (valor >= 5)
            {
                inteiro = valor / 5;
                valor = valor % 5;
                for (int i = inteiro; i > 0; i--)
                    romano = romano + "V";
            }


            if (valor >= 1)
            {
                inteiro = valor / 1;
                valor = valor % 1;
                for (int i = inteiro; i > 0; i--)
                    romano = romano + "I";
            }

            return romano;

        }
    }
}