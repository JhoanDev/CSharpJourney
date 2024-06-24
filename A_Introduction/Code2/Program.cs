using System;

namespace Code2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SByte dotNetSByte = 100; //dot net
            sbyte csharpSByte = -50; //csharp puro
            Console.WriteLine($"SByte (dotNetSByte) + sbyte (csharpSByte): {csharpSByte + dotNetSByte}");

            Byte dotNetByte = 255;
            byte csharpByte = 20;
            Console.WriteLine($"Byte (dotNetByte) + byte (csharpByte): {csharpByte + dotNetByte}");

            short csharpShort = 20;
            Int16 dotNetShort = 123;
            Console.WriteLine($"short (csharpShort) + Int16 (dotNetShort): {csharpShort + dotNetShort}");

            int csharpInt = 30;
            Int32 dotNetInt = 20000000;
            Console.WriteLine($"int (csharpInt) + Int32 (dotNetInt): {dotNetInt + csharpInt}");

            long csharpLong = 29389237347;
            Int64 dotNetLong = 50;
            Console.WriteLine($"long (csharpLong) + Int64 (dotNetLong): {dotNetLong + csharpLong}");

            bool csharpBoolFalse = false;
            Console.WriteLine($"bool (csharpBoolFalse): {csharpBoolFalse}");
            Boolean csharpBoolTrue = true;
            Console.WriteLine($"Boolean (csharpBoolTrue): {csharpBoolTrue}");

            char genderF = 'F';
            Console.WriteLine($"char (genderF): {genderF}");
            Char genderM = 'M';
            Console.WriteLine($"Char (genderM): {genderM}");

            char unicodeA = '\u0041'; //letra A na tabela unicode
            Console.WriteLine($"Unicode character (unicodeA): {unicodeA}");

            float csharpFloat = 1.6f;
            Console.WriteLine($"float (csharpFloat): {csharpFloat}");
            Single dotNetFloat = 1.5f;
            Console.WriteLine($"Single (dotNetFloat): {dotNetFloat}");

            double csharpDouble = 324.543;
            Console.WriteLine($"double (csharpDouble): {csharpDouble}");
            Double dotNetDouble = 23.62;
            Console.WriteLine($"Double (dotNetDouble): {dotNetDouble}");

            string sentence1 = "Cristiano é o melhor";
            Console.WriteLine($"string (sentence1): {sentence1}");
            String sentence2 = "Maior da champions";
            Console.WriteLine($"String (sentence2): {sentence2}");

            object objString = "Pedro";
            Console.WriteLine($"object (objString): {objString}");
            object objInt = 2;
            Console.WriteLine($"object (objInt): {objInt}");

            // Min and max values
            Console.WriteLine($"int.MinValue: {int.MinValue}");
            Console.WriteLine($"int.MaxValue: {int.MaxValue}");
            Console.WriteLine($"short.MinValue: {short.MinValue}");
            Console.WriteLine($"short.MaxValue: {short.MaxValue}");
            Console.WriteLine($"sbyte.MinValue: {sbyte.MinValue}");
            Console.WriteLine($"sbyte.MaxValue: {sbyte.MaxValue}");
            Console.WriteLine($"decimal.MinValue: {decimal.MinValue}");
            Console.WriteLine($"decimal.MaxValue: {decimal.MaxValue}");
        }
    }
}
