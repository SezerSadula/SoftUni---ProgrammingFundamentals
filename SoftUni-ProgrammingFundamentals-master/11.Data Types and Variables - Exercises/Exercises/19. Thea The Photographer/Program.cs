using System;

namespace _19.Thea_The_Photographer
{
    class Program
    {
        static void Main(string[] args)
        {
            ulong picturesTaken = ulong.Parse(Console.ReadLine());
            ulong timeInSecondsToFilterPicture = ulong.Parse(Console.ReadLine());
            ulong percentageOfGoodPictures = ulong.Parse(Console.ReadLine());
            ulong timeToUploadPicture = ulong.Parse(Console.ReadLine());

            ulong goodPictures = (ulong)Math.Ceiling(picturesTaken / 100d * percentageOfGoodPictures);

            ulong timeInSeconds = (goodPictures * timeToUploadPicture) + (timeInSecondsToFilterPicture * picturesTaken);

            TimeSpan time = TimeSpan.FromSeconds(timeInSeconds);

            Console.WriteLine(time.ToString(@"d\:hh\:mm\:ss"));
        }
    }
}
