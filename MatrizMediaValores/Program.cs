internal class Program
{
    private static void Main(string[] args)
    {
        double[,]mat = new double[5,3];


        PreencheMatriz(mat,5,3);
        ImprimeMatriz(mat,3);


        void PreencheMatriz(double[,] aux, int lin, int col)
        {
            
            for (int linha = 0; linha < 5; linha++)
            {
                for (int coluna = 0; coluna < 3; coluna++)
                {
                   
                    if (coluna == 2)
                    {
                        aux[linha, 2] = (aux[linha, 0] + aux[linha, 1])/2;
                    }

                    else 
                    {
                        Console.WriteLine(" \nDigite o valor da posicao [{0},{1}]", linha, coluna);
                        aux[linha, coluna] = double.Parse(Console.ReadLine());
                       
                    }
                                   

                    

                }
            }
        }

       


        void ImprimeMatriz(double[,]aux,int col)
        {
            Console.Clear();
            

            for (int linha = 0; linha < 5; linha++)
            {
                for (int coluna = 0; coluna < 3; coluna++)
                {   
                    
                    Console.Write(aux[linha,coluna] + " |");

                    if(coluna == (col - 1))
                    {
                        Console.WriteLine("\n");
                    }
                   
                }
            }

        }

    }

   
}