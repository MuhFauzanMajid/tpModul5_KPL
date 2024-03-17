using tpmodul5_1302220144;

internal class Program
{
    private static void Main(string[] args)
    {
        //testing input integer
        DataGeneric<int> dataInt = new DataGeneric<int>(1302220144);
        dataInt.PrintData();

        //testing input string
        DataGeneric<string> dataString = new DataGeneric<string>("1302220144");
        dataString.PrintData();
    }
}