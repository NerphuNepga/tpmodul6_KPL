using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace tpmodul6_103022300050
{
    class SayaTubeVideo
    {
        private int id, playCount;
        private string title;
        private static Random random = new Random();

        public SayaTubeVideo(string title)
        {
            this.title = title;
            this.id = random.Next(10000, 99999);
            this.playCount = 0;
        }

        public void IncreasePlayCount(int playCount)
        {
            this.playCount += playCount;
        }
        public void PrintVideoDetails()
        {
            Console.WriteLine("Video ID         : " + this.id);
            Console.WriteLine("Video Title      : " + this.title);
            Console.WriteLine("Video Play Count : " + this.playCount);
        }
    }
}
