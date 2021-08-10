using System;

namespace AlgorithmEx1
{
    class Program
    {
        static void Main(string[] args)
        {

            string[,] places = new string[,]
            {{"POOOP", "OXXOX", "OPXPX", "OOXOX", "POXXP"}, 
            {"POOPX", "OXPXP", "PXXXO", "OXXXO", "OOOPP"}, 
            {"PXOPX", "OXOXP", "OXPOX", "OXXOP", "PXPOX"}, 
            {"OOOXX", "XOOOX", "OOOXX", "OXOOX", "OOOOO"}, 
            {"PXPXP", "XPXPX", "PXPXP", "XPXPX", "PXPXP"}
            } ;

            int[] answer = new int[5] {0,0,0,0,0 };

            var a = places[0, 0][0];
            var aColumn = places[0, 0][1];
            var aRow = places[0, 1][0];



            for (int i =0; i<places.Length;i++)
            {
                for(int j=0;j<places.Length;j++)
                {
                    for(int k=0;k<places.Length;k++)
                    {
                        a = places[i, j][k];
                        aColumn = places[i, j][k + 1];
                        aRow = places[i, j + 1][k];
                        answer[i] = 0;
                    }
                }

            }
            Console.WriteLine(a);

 
          //  return answer;
        }
    }
}
