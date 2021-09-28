using System;

namespace Practica03WS.Code
{
    public class Calcular
    {

        public double Cuadrado(int B)
        {
            var result = B * B;
            return result;
        }

        public double Triangulo(int T, int O)
        {
            var result = (T * O) / 2;
            return result;
        }

        public double Circulo(int C)
        {
            var result = Math.PI * Math.Pow(C, 2);
            return result;
        }

    }
}