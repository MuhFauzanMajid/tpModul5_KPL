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
    }
}   