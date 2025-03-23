using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Numerics;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace tpmodul6_103022300050
{
    class SayaTubeVideo
    {
        private int id, playCount;
        private string title;

        public SayaTubeVideo(string title)
        {
            Debug.Assert(!string.IsNullOrEmpty(title), "title tidak boleh null.");
            Debug.Assert(title.Length <= 100, "title tidak lebih dari 100 karakter");

            Random random = new Random();
            this.title = title;
            this.id = random.Next(10000, 99999);
            this.playCount = 0;
        }

        public void IncreasePlayCount(int playCount)
        {
            Debug.Assert(playCount >= 0 && playCount <= 10000000, "Play Count harus kurang dari 10.000.000 dan tidak kurang dari 0.");
            try
            {
                checked
                {
                    this.playCount += playCount;
                }
            }
            catch (OverflowException)
            {
                Console.WriteLine("Error: Play count overflow!");
            }
        }
        public void PrintVideoDetails()
        {
            Console.WriteLine("Video ID         : " + this.id);
            Console.WriteLine("Video Title      : " + this.title);
            Console.WriteLine("Video Play Count : " + this.playCount);
        }
    }
}
