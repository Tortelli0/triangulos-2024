using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangulo
{
    public class Triangulo
    {
        public int x;
        public int y;
        public int z;

        public Triangulo(int x, int y, int z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        public bool VerificarTriangulo()
        {
            if (x + y <= z) return false;
            if (x + z <= y) return false;
            if (y + z <= x) return false;
            return true;
        }

        public string ObterTipoTriangulo()
        {
            if (x == y && y == z) return "equilátero";
            if (x == y || x == z || z == y) return "iscosceles";
            return "Triângulo escaleno";
        }

    }
}
