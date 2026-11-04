 namespace Exercicios.Algoritmos;

 class CalculaImpar
{
      static int CalculaImpaar(int x, int y)
    {
        int cont = 0;
        if (x > y)
        {
            for (int i = y; i <= x; i++)
            {
                if (i % 2 != 0)
                    cont += i;
            }
        }


        else if (y > x)
        {
            for (int j = x; j <= y; j++)
            {
                if (j % 2 != 0)
                    cont += j;
            }
        }
        return cont;
    }
}