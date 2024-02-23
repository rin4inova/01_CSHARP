int a = 6;
int b = 7;
int c = 108;
int d = 7;
int e = 205;


int max = a;
if (b > max)
{
    max = b;
}

if (c > max)
{
    max = c;
}

if (d > max)
{
    max = d;
}

if (e > max)
{
    max = e;
}

Console.WriteLine ("max = " + max);