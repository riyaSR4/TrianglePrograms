using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace TrianglePrograms
{
    public class Triangles
    {
        public void AlphabetTriangle()
        {
            char ch = 'A';
            int i, j, k, m;
            Console.WriteLine("Enter the limit :");
            int n = Convert.ToInt32(Console.ReadLine());
            for (i = 1; i <= n; i++)
            {
                for (j = n; j >= i; j--)
                    Console.Write(" ");
                for (k = 1; k <= i; k++)
                    Console.Write(ch++);
                ch--;
                for (m = 1; m < i; m++)
                    Console.Write(--ch);
                Console.Write("\n");
                ch = 'A';
            }
        }

        public void NumberTriangle()
        {
            int i, j, k, l;
            Console.WriteLine("Enter the limit: ");
            int n = Convert.ToInt32(Console.ReadLine());
            for(i = 1; i <= n; i++)
            {
                for(j = 1; j <= n-i; j++)
                {
                    Console.Write(" ");
                }
                for(k = 1; k <= i;k++)
                {
                    Console.Write(k);
                }
                for(l = i-1; l>= 1; l--)
                {
                    Console.Write(l);
                }
                Console.Write('\n');
            }
        }
    }
}
