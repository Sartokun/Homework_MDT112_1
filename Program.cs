using System;

class Program {
    static void Main(string[] args) {

        //รับเลข 6 หลัก
        Console.Write("Please enter 6 digit numder : ");
        string numder = Console.ReadLine();

        //ตรวจาสอบเลข 6 หลัก
        if (numder.Length != 6) {
            Console.WriteLine("You entered an invalid number.");
        }

        //ตรวจสอบว่าเป็นตัวเลขหรือไม่?
        int num1 = numder[0] - '0';
        int num2 = numder[1] - '0';
        int num3 = numder[2] - '0';
        int num4 = numder[3] - '0';
        int num5 = numder[4] - '0';
        int num6 = numder[5] - '0';

        Console.WriteLine("{0},{1},{2},{3},{4},{5}",num1, num2, num3, num4, num5, num6);

        if (num1 < 0 || num1 > 9 ||
            num2 < 0 || num2 > 9 ||
            num3 < 0 || num3 > 9 ||
            num4 < 0 || num4 > 9 ||
            num5 < 0 || num5 > 9 ||
            num6 < 0 || num6 > 9
        ) {
            Console.WriteLine("Please enter 6 digit only");
        }

    }
}