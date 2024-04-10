namespace Triangulo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o primeiro lado do triângulo: ");
            int x = int.Parse(Console.ReadLine());

            Console.WriteLine("\nDigite o segundo lado do triângulo: ");
            int y = int.Parse(Console.ReadLine());

            Console.WriteLine("\nDigite o terceiro lado do triângulo: ");
            int z = int.Parse(Console.ReadLine());

            Triangulo triangulo = new Triangulo();

            triangulo.x = x;
            triangulo.y = y;
            triangulo.z = z;

            if (triangulo.VerificarTriangulo())
            {
                Console.WriteLine($"\nO triângulo é {triangulo.ObterTipoTriangulo()}.");
            }

            else
            {
                Console.WriteLine("\nMedidas não encaixam para formar um triângulo, tente novamente");
            }
        }
    }
}

// Outro jeito de fazer a pergunta para o usuario

// triangulo.x = ObterLado("Digite o lado x: ")
// triangulo.y = ObterLado("Digite o lado y: ")
// triangulo.z = ObterLado("Digite o lado z: ")


// M    etodo ObterLado abaixo

// static int ObterLado(string texto)
// {
//      Console.WriteLine(texto);
//
//      return Int.Parse(Console.ReadLine());
// }