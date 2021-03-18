using System;
using System.Collections.Generic;

namespace Listas_y_numeros
{
    class Program
    {
        static void Main(string[] args)
        {
        List<int> listanumeros = new List<int>();

        listanumeros.Add (1);
        listanumeros.Add (2);
        listanumeros.Add (3);
        listanumeros.Add (4);
        listanumeros.Add (5);
        
        listanumeros[1]= 6;
        listanumeros[listanumeros.Count -1] = 7;
        listanumeros.Add(8);
        listanumeros.Add(9);

        listanumeros.Remove(0);
        
        for(int i = 0; i <listanumeros.Count; i++)
        {
            listanumeros[i] = listanumeros[i]*3;
        }


        for (int i = 0; i <listanumeros.Count; i++)
        {
            if (listanumeros[i] >20)
            {
                listanumeros.Remove(listanumeros[i]);
            }
        }
        for (int i =0; i < listanumeros.Count; i++)
        {
            Console.Write(listanumeros[i]);
        }

         

        

        }
    }
}
