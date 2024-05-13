// See https://aka.ms/new-console-template for more information
using System;
using System.Text.RegularExpressions;

    int n = 1;
    int a = 0;
rep1:  a += 1;
Random rnd = new ();
int dice = rnd.Next(1, 7);
if (dice == n) { goto rep2; }
    else{ goto rep1; }
rep2: n += 1;
    if (n<7) { goto rep1; }
    else{ Console.WriteLine("Du har gjort " + a + " kast");}

