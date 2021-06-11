using System;
using System.Collections.Generic;
using System.Text;

namespace ConversorRomanos.ClassLibrary
{
    public class Romano
    {
        int inteiro = 0;

        #region Dicionários
        readonly IDictionary<char, int> dicionarioRomanoInteiro = new Dictionary<char, int>()
        {
            { 'I', 1 },
            { 'V', 5 },
            { 'X', 10 },
            { 'L', 50 },
            { 'C', 100 },
            { 'D', 500 },
            { 'M', 1000 },
        };

        readonly IDictionary<int, string> dicionarioInteiroRomano = new Dictionary<int, String>()
        {
            { 10000, "X̄"},
            { 9000, "ĪX̄"},
            { 5000, "V̄" },
            { 4000, "ĪV̄" },
            { 1000, "M" },
            { 900, "CM" },
            { 500, "D" },
            { 400, "CD" },
            { 100, "C" },
            { 90, "XC" },
            { 50, "L" },
            { 40, "XL" },
            { 10, "X" },
            { 9, "IX" },
            { 5, "V" },
            { 4, "IV" },
            { 1, "I" },
        };
        #endregion

        public Romano()
        {

        }

        public string ConverterInteiroParaRomano(int inteiro)
        {
            var romano = new StringBuilder();

            foreach (var item in dicionarioInteiroRomano)
            {
                while (inteiro >= item.Key)    //Começar do maior número
                {
                    romano.Append(item.Value); //Concatena letra
                    inteiro -= item.Key;       //Subtrai o que já foi adicionado
                }
            }

            return romano.ToString();
        }

        public int ConverterRomanoParaInteiro(String romano)
        {
            romano = ValidarString(romano);

            if (romano.Length != 0)
            {
                int atual, anterior = 0;
                char romanoAtual, romanoAnterior = '\0';

                for (int i = 0; i < romano.Length; i++)
                {
                    romanoAtual = romano[i];

                    anterior = romanoAnterior != '\0' ? dicionarioRomanoInteiro[romanoAnterior] : '\0';
                    atual = dicionarioRomanoInteiro[romanoAtual];

                    if (anterior != 0 && atual > anterior)
                    {
                        inteiro = inteiro - (2 * anterior) + atual;
                    }
                    else
                    {
                        inteiro += atual;
                    }

                    romanoAnterior = romanoAtual;
                }
            }

            return inteiro;
        }

        private String ValidarString(String romano)
        {
            while (romano.Contains("M̄") || romano.Contains("D̄") || romano.Contains("C̄") ||
                   romano.Contains("L̄") || romano.Contains("X̄") || romano.Contains("V̄"))
            {
                if (romano.Contains("C̄M̄"))
                {
                    romano = romano.Substring(4);
                    inteiro += 900000;
                }
                else if (romano.Contains("M̄"))
                {
                    romano = romano.Substring(2);
                    inteiro += 1000000;
                }
                else if (romano.Contains("C̄D̄"))
                {
                    romano = romano.Substring(4);
                    inteiro += 400000;
                }
                else if (romano.Contains("D̄"))
                {
                    romano = romano.Substring(2);
                    inteiro += 500000;
                }
                else if (romano.Contains("X̄C̄"))
                {
                    romano = romano.Substring(4);
                    inteiro += 90000;
                }
                else if (romano.Contains("C̄"))
                {
                    romano = romano.Substring(2);
                    inteiro += 100000;
                }
                else if (romano.Contains("X̄L̄"))
                {
                    romano = romano.Substring(4);
                    inteiro += 40000;
                }
                else if (romano.Contains("L̄"))
                {
                    romano = romano.Substring(2);
                    inteiro += 50000;
                }
                else if(romano.Contains("ĪX̄"))
                {
                    romano = romano.Substring(3);
                    inteiro += 9000;
                }
                else if (romano.Contains("X̄"))
                {
                    romano = romano.Substring(2);
                    inteiro += 10000;
                }
                else if (romano.Contains("V̄ĪĪĪ"))
                {
                    romano = romano.Substring(5);
                    inteiro += 8000;
                }
                else if (romano.Contains("V̄ĪĪ"))
                {
                    romano = romano.Substring(4);
                    inteiro += 7000;
                }
                else if (romano.Contains("V̄Ī"))
                {
                    romano = romano.Substring(3);
                    inteiro += 6000;
                }
                else if (romano.Contains("ĪV̄"))
                {
                    romano = romano.Substring(3);
                    inteiro += 4000;
                }
                else if (romano.Contains("V̄"))
                {
                    romano = romano.Substring(2);
                    inteiro += 5000;
                }
            }

            return romano;
        }
    }
}
