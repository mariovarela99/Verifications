using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Verify
{
    public class Verifications
    {
        // Funcao que verifica se o number e positivo
        public bool isPositive(int number)
        {
            if (number > 0) return true; else return false;
        }

        // Funcao que verifica se o number e negativo
        public bool isNegative(int number)
        {
            if (number < 0) return true; else return false;
        }

        // Funcao que verifica se o number e par
        public bool isPar(int number)
        {
            if (number % 2 == 0) return true; else return false;
        }

        // Funcao que verifica se o number e impar
        public bool isImpar(int number)
        {
            if (number % 2 != 0) return true; else return false;
        }

        // Funcao que soma os divisores de um number
        public int SomarDivisores(int number)
        {
            int Soma = 0;

            for (int i = 1; i < number; i++)
            {
                if (number % i == 0)
                    Soma += i;
            }

            return Soma;
        }

        // Funcao que conta os divisores de um number
        public int ContarDivisores(int number)
        {
            int Contador = 0;

            for (int i = 1; i < number; i++)
            {
                if (number % i == 0)
                    Contador++;
            }

            return Contador;
        }

        // Funcao que verifica se um number e perfeito
        public bool isPerfect(int number)
        {
            if (SomarDivisores(number) == number)
                return true;
            else return false;
        }

        // Funcao que verifica se um number e primo
        public bool isPrimo(int number)
        {
            if (ContarDivisores(number) == 2)
                return true;
            else return false;
        }

        // Funcao que retorna o maior entre dois numbers
        public int GetMax(int number1, int number2)
        {
            if (number1 > number2) 
                return number1;
            else 
                if (number2 > number1) 
                    return number2;
               
            return 0;
        }

        // Funcao que retorna o menor entre dois numbers
        public int GetMin(int number1, int number2)
        {
            if (number1 < number2)
                return number1;
            else
                if (number2 < number1)
                    return number2;

            return 0;
        }

        // Funcao que verifica se dois numbers sao iguais
        public bool AreEquals(int number1, int number2)
        {
            if (number1 == number2)
                return true;
            else return false;
        }

        // Funcao que verifica se dois numbers sao amigos
        public bool AreFriends(int num1, int num2)
        { 
            if (SomarDivisores(num1) == SomarDivisores(num2))
                return true; 
            else 
                return false;
        }

        public string ParOrImpar(int number)
        {
            if (number % 2 == 0) return "Par"; else return "Impar";
        }

        public string PositiveOrNegative(int number)
        {
            if (number > 0) return "Positive"; else return "Negative";
        }

        public double MediaArtimetica3(int n1, int n2, int n3)
        {
            return ((n1 + n2 + n3) / 3);
        }

        /*public string Order3Numbers(int n1, int n2, int n3)
        {
            if (n1 > n3 && n2 > n3)
            {
                return String.Format("{0} => {1} => {2} ", n3, GetMin(n1, n2), GetMax(n1, n2));
            }
            else
            {
                if((n1 < n3 && n2 < n3))
                    return String.Format("{0} => {1} => {2} ", GetMax(n1, n2), GetMin(n1, n2), n3);
            }
        }*/
    }
}
