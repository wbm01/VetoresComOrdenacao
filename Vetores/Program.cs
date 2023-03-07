using System.Net.Http.Headers;

internal class Program
{
    private static void Main(string[] args)
    {
        int[] a = new int[5];
        int[] b = new int[5];
        int[] c = new int[10];

        LerVetor(a, "Vetor a");
        LerVetor(b, "Vetor b");

        c = JuntarAeB(a, b);

        ImprimirVetor(a, "\nVetor a");
        ImprimirVetor(b, "\nVetor b");

        OrdenarVetor(c);
        ImprimirVetor(c, "\nVetor c");

        void OrdenarVetor(int[]aux)
        {
            int i, j;
            for(i = 0; i<aux.Length-1; i++)
            {
                for(j=i+1; j<aux.Length; j++)
                {
                    if (aux[i] > aux[j])
                    {
                        int aux2 = aux[i];
                        aux[i] = aux[j];
                        aux[j] = aux2;
                    }
                }
            }    


        }

        int[] JuntarAeB(int[]a, int[] b)
        {
            int[] aux = new int[10];
            for (int i = 0; i < a.Length; i++)
                aux[i] = a[i];
            for (int i = 0; i < b.Length; i++)
                aux[i + 5] = b[i];
            return aux;

        }

        void LerVetor(int[] aux, string texto)
        {
            Console.Write("\nInforme os valores do {0}: ",texto);

            for (int i = 0; i < aux.Length; i++)
            {
                Console.Write("\nVetor[{0}]: ", i);
                aux[i] = int.Parse(Console.ReadLine());

            }
        }

        void  ImprimirVetor(int[] aux, string texto)
        {
            Console.Write("\nOs valores do {0} são: ", texto);

            for (int i = 0; i < aux.Length; i++)
            {
                Console.Write("\nVetor[{0}]: {1}", i, aux[i]);
                
            }
        }

    

    }
}