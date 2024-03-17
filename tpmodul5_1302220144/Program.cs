using tpmodul5_1302220144;

internal class Program
{
    private static void Main(string[] args)
    {
        HaloGeneric halo = new HaloGeneric();
        //testing input string
        halo.SapaUser("Majid");
        //testing input integer
        halo.SapaUser(123);
        //testing input float
        halo.SapaUser(123.321);

        Console.WriteLine();
        //testing input integer
        DataGeneric<int> dataInt = new DataGeneric<int>(1302220144);
        dataInt.PrintData();
    }
}