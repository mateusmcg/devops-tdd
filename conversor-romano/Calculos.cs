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
                valor = inteiro % 1000;
                for (int i = inteiro; i > 0; i--)
                    romano = romano + "M";
            }

            if (valor >= 500)
            {
                inteiro = valor / 500;
                valor = inteiro % 500;
                for (int i = inteiro; i > 0; i--)
                    romano = romano + "D";
            }


            if (valor >= 100)
            {
                inteiro = valor / 100;
                valor = inteiro % 100;
                for (int i = inteiro; i > 0; i--)
                    romano = romano + "C";
            }


            if (valor >= 50)
            {
                inteiro = valor / 50;
                valor = inteiro % 50;
                for (int i = inteiro; i > 0; i--)
                    romano = romano + "L";
            }

            if (valor >= 10)
            {
                inteiro = valor / 10;
                valor = inteiro % 10;
                for (int i = inteiro; i > 0; i--)
                    romano = romano + "X";
            }

            if (valor >= 5)
            {
                inteiro = valor / 5;
                valor = inteiro % 5;
                for (int i = inteiro; i > 0; i--)
                    romano = romano + "V";
            }


            if (valor >= 1)
            {
                inteiro = valor / 1;
                valor = inteiro % 1;
                for (int i = inteiro; i > 0; i--)
                    romano = romano + "I";
            }

            return romano;

        }
    }
}