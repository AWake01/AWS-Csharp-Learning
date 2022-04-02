int[] ary = new int[] { 1, 5, 7, 14, 1, 2, 5, 20, 8, 13, 6, 18 };
bool finished = false;

while (finished == false)
{
    finished = true;

    for (int i = 0; i < ary.Length - 1; i++)
    {
        // Console.WriteLine(ary[i]);
        int n1 = ary[i];
        int n2 = ary[i + 1];

        if (n1 > n2)
        {
            int temp = n1;
            (ary[i], ary[i + 1]) = (ary[i + 1], ary[i]);



            finished = false;
        }
    }
}

for (int i = 0; i < ary.Length; i++)
{
    Console.WriteLine(ary[i]);
}
 
Console.ReadLine();
