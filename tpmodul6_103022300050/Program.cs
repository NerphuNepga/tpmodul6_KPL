// See https://aka.ms/new-console-template for more information
using tpmodul6_103022300050;

class Program
{
    static void Main(string[] args)
    {
        SayaTubeVideo video = new SayaTubeVideo("Tutorial Design By Contract - Muhammad Arrayan Fikri");
        video.PrintVideoDetails();

        try
        {
            SayaTubeVideo tesVideoNull = new SayaTubeVideo(null);
        }
        catch (Exception ex)
        {
            Console.WriteLine("ERROR: " + ex.Message);
        }

        try
        {
            SayaTubeVideo tesVideoPanjangNama = new SayaTubeVideo(new string('W', 200));
        }
        catch (Exception ex)
        {
            Console.WriteLine("ERROR: " + ex.Message);
        }

        try
        {
            SayaTubeVideo tesVideoPlayCount = new SayaTubeVideo("Tes Video Count");
            tesVideoPlayCount.PrintVideoDetails();
            tesVideoPlayCount.IncreasePlayCount(10000001);
        }
        catch (Exception ex)
        {
            Console.WriteLine("ERROR: " + ex.Message);
        }
    }
}

