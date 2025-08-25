float[] units = {1, 10, 1000, 1000000, 25.4F, 304.8F, 914.4F, 1609344F };

// mm = 1, cm = 2, m = 3, km = 4, inch = 5, feet = 6, yards = 7, miles = 8
// täs pmo kieles ei oo definee );


while (true)
{
    Console.WriteLine("Mitä haluat muuttaa miksi");
    Console.WriteLine("1 - metriyksiköt, 2 - imperial yksiköt");

    int.TryParse(Console.ReadLine(), out int vastaus);

    // Console.WriteLine(vastaus);

    if (vastaus == 1)
    {
        Console.WriteLine("\n1 - Kilometrit \n2 - Metrit\n3 - Senttimetrit\n4 - Millimetrit");
        int.TryParse(Console.ReadLine(), out int vastaus2);
        switch (vastaus2) 
        {
            case 1:
                Console.WriteLine("Kilometrit muunnettuna muihin yksikköihin.");
                for(int i = 0; i < units.Length; i++) 
                {

                }

                break;

            default:
                break;

        }

    }
    else if (vastaus == 2)
    {

    }
    else
    {
        Console.WriteLine("vaa 1 tai 2");
        Console.Clear();

    }

}