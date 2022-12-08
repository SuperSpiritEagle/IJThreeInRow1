using System;

namespace IJThreeInRow
{
    class Program
    {
        static void Main(string[] args)
        {
            int filledRows = 52;
            int seriesPictures = 3;
            int imagesAlbum ;
            int notIncludedInAlbum;
            imagesAlbum = filledRows / seriesPictures;
            imagesAlbum = imagesAlbum * seriesPictures;
            notIncludedInAlbum = filledRows - imagesAlbum;
            Console.WriteLine($"Полностью заполненных рядов можно будет вывести {imagesAlbum}" +
                $"\nкартинок сверх меры {notIncludedInAlbum}");
        }
    }
}
