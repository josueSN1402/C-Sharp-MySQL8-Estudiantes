using System;

namespace ClassColegio
{
    public class Evalucion
    {
        public double CalcPromedio(double n1, double n2, double n3)
        {
            double promedio = (n1 + n2 + n3) / 3;
            promedio = Math.Round(promedio * 100) / 100;
            return promedio;
        }

        public string EvaSituacion(double prom)
        {
            string situ;
            if (prom >= 0 && prom <= 5) situ = "RETIRADO";
            else if (prom >= 6 && prom <= 10) situ = "SUSTITUTORIO";
            else if (prom >= 11 && prom <= 15) situ = "PROMOVIDO";
            else if (prom > 15) situ = "EXCELENTE";
            else situ = "";

            return situ;
        }
    }
}
