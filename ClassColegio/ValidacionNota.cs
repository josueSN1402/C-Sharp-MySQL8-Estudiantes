namespace ClassColegio
{
    public class ValidacionNota
    {
        public bool ValidarRango(int valor)
        {
            if (valor >= 0 && valor <= 20) return true;
            else return false;
        }

        public bool EsEntero(string txt)
        {
            if (int.TryParse(txt, out _))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
