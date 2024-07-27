
namespace EjercicioClases
{
    public class SuperHeroe
    {
        public string Nombre { get; set; }

        public string IdentidadSecreta { get; set; }

        public string Ciudad { get; set; }

        public bool PuedeVolar { get; set; }

        public SuperPoder SuperPoder { get; set; }

        // Constructor
        public SuperHeroe()
        {
            PuedeVolar = true;
            SuperPoder = new SuperPoder();
        }

        public void Imprimir()
            {
            Console.WriteLine($"Nombre: {Nombre}");
            Console.WriteLine($"Identidad Secreta: {IdentidadSecreta}");
            Console.WriteLine($"Ciudad: {Ciudad}");
            Console.WriteLine($"Puede Volar: {(PuedeVolar ? "Sí" : "No")}");
            Console.WriteLine($"Super Poder: {SuperPoder.Nombre}");
            Console.WriteLine($"Descripción de Poder: {SuperPoder.Descripcion}");
            Console.WriteLine($"Nivel de Super Poder: {SuperPoder.Nivel}");
            Console.WriteLine();
        }
  
    }
}
