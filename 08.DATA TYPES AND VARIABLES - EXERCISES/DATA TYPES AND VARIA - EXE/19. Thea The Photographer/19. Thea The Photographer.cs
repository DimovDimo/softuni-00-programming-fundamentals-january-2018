using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19.Thea_The_Photographer
{
    class Program
    {
        static void Main(string[] args)
        {
            var numberOfPictures = long.Parse(Console.ReadLine());
            var filterTime = long.Parse(Console.ReadLine());
            var filterFactor = long.Parse(Console.ReadLine());
            var filteredPictureToBeUploaded = long.Parse(Console.ReadLine());

            var filteredPictures = (long)Math.Ceiling(numberOfPictures * (filterFactor / 100d));
            var timeForFilteredAllPictures = numberOfPictures * filterTime;
            var timeForUpload= filteredPictures * filteredPictureToBeUploaded;
            var totalTime = timeForFilteredAllPictures + timeForUpload;

            TimeSpan time = TimeSpan.FromSeconds(totalTime);
            Console.WriteLine("{0:d\\:hh\\:mm\\:ss}", time);
        }
    }
}
