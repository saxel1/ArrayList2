using System;
using System.Collections;


public class Point
{


    public int x;
    public int y;




    public Point(int x, int y)
    {
        x = x;
        y = y;
    }
    public string ToString()
    {
        return x + "," + y;
    }
}
public class ArrayListTest
{

    public static void Main(string[] args)
    {

        ArrayList AL = new ArrayList();
        Random R = new Random();
        for (int i = 0; i < 10; i++)
        {
            Point p = new Point(R.Next(50), R.Next(50));
            AL.Add(p);
        }
        PrintValues(AL);
        AL.Sort();
        PrintValues(AL);
    }
}