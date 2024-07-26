
namespace EjercicioClases
{
    public class SuperHeroe
    {
        public string Nombre { get; set; }

        public String IdentidadSecreta { get; set; }

        public String Ciudad { get; set; }

        public bool PuedeVolar { get; set; }

        public string SuperPoder { get; set; }

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
                Console.WriteLine($"Super Poder: {SuperPoder}");
                Console.WriteLine();
            }
        }
    }
}
