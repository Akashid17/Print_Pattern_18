using System;

class PatternX
{
    public void Display(int iNo1, int iNo2)
    {
        if(iNo1 < 0)
        {
            iNo1 = -iNo1;
        }

        if(iNo2 < 0)
        {
            iNo2 = -iNo2;
        }

        if(iNo1 == 0 && iNo2 == 0)
        {
            Console.WriteLine("Unable to Print Pattern it contains Zero for Rows & Columns");
        }
        else if(iNo1 == 0)
        {
            Console.WriteLine("Unable to Print Pattern it contains Zero for Rows");
        }
        else if(iNo2 == 0)
        {
            Console.WriteLine("Unable to Print Pattern it contains Zero for Columns");
        }
        else
        {
            int iCnt = 1;

            for(int i = iNo1; i > 0; i--)
            {
                if(i % 2 == 0)
                {
                    iCnt = 2;
                }
                else
                {
                    iCnt = 1;
                }

                for(int j = 1; j <= iNo2; j++)
                {
                    Console.Write(iCnt+"\t");
                    iCnt = iCnt + 2 ;
                }
                Console.WriteLine();
            }
        }
    }
}

class Demo
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter Number of Rows and Columns");

        int iValue1 = Convert.ToInt32(Console.ReadLine());
        int iValue2 = Convert.ToInt32(Console.ReadLine());

        PatternX pobj = new PatternX();
        pobj.Display(iValue1,iValue2);
    }
}