namespace SistemaColegio
{
    public class Estudiante
    {
        private string dni;
        private string apaterno;
        private string amaterno;
        private string nombres;
        private string cursos;
        private int edad;
        private int nota1;
        private int nota2;
        private int nota3;

        public string Dni { get => dni; set => dni = value; }
        public string Apaterno { get => apaterno; set => apaterno = value; }
        public string Amaterno { get => amaterno; set => amaterno = value; }
        public string Nombres { get => nombres; set => nombres = value; }
        public string Cursos { get => cursos; set => cursos = value; }
        public int Edad { get => edad; set => edad = value; }
        public int Nota1 { get => nota1; set => nota1 = value; }
        public int Nota2 { get => nota2; set => nota2 = value; }
        public int Nota3 { get => nota3; set => nota3 = value; }
    }
}
