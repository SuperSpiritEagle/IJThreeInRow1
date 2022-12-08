using System;

namespace IJThreeInRow
{
    class Program
    {
        static void Main(string[] args)
        {
            int filledRows = 17;
            int seriesPictures = 3;
            int imagesAlbum = 0;
            int notIncludedInAlbum = 2;

            for (int i = 0; i < filledRows; i++)
            {
                for (int j = 0; j < seriesPictures; j++)
                {
                    Console.Write((imagesAlbum++) + "\t");
                }
                Console.WriteLine();
                Console.WriteLine();
            }

            Console.WriteLine($"Полностью заполненных рядов можно будет вывести {filledRows}" +
                $"\nкартинок сверх меры {notIncludedInAlbum}");

        }
    }
}
