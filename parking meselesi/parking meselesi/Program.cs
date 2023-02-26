double umumi_mebleg = 0;
double faiz1 = 0.8;
double faiz2 = 0.5;
double faiz3 = 0.25;
int saat = Convert.ToInt32(Console.ReadLine());

if (saat <= 3)
{
    umumi_mebleg = +saat;
    Console.WriteLine(umumi_mebleg);
}
else if (saat <= 5 && saat > 3)
{
    umumi_mebleg = +3 + faiz1 * (saat - 3);
    Console.WriteLine(umumi_mebleg);
}
else if (saat <= 8 && saat > 5) ;
{
    umumi_mebleg = +3 + faiz1 * 2 + faiz2 * (saat - 5);
    Console.WriteLine(umumi_mebleg);
}
else if (saat <= 8 && saat > 5)
{
    umumi_mebleg = +3 + faiz1 * 2 + faiz2 * (saat - 5);
    Console.WriteLine(umumi_mebleg);
}
else
{
    umumi_mebleg = +3 + faiz1 * 2 + faiz2 * 3 + faiz3 * (saat - 8);
    Console.WriteLine(umumi_mebleg);
}