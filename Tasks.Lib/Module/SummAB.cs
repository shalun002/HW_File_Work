using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tasks.Lib.Module
{
    public class SummAB
    {
        public void Summ()
        {
            string pathInp = @"INPUT.txt";
            string pathOut = @"OUTPUT.txt";

            FileInfo file = new FileInfo(pathInp);

            int A = 12;
            int B = 13;
            int sumOfAB;
            int numberA;
            int numberB;

            using (BinaryWriter writer = new BinaryWriter(File.Open(pathInp, FileMode.OpenOrCreate)))
            {
                writer.Write(A);
                writer.Write(B);
            }

            using (BinaryReader reader = new BinaryReader(File.Open(pathInp, FileMode.Open)))
            {
                while (reader.PeekChar() > -1)
                {
                    numberA = reader.ReadInt32();
                    reader.PeekChar();
                    numberB = reader.ReadInt32();
                    sumOfAB = numberA + numberB;
                    Console.WriteLine("Певрое число - {0}, второе число - {1}. ", numberA, numberB);

                    using (BinaryWriter writerSum = new BinaryWriter(File.Open(pathOut, FileMode.OpenOrCreate)))
                    {
                        writerSum.Write(sumOfAB);
                    }
                    using (BinaryReader readerSum = new BinaryReader(File.Open(pathOut, FileMode.Open)))
                    {
                        Console.WriteLine("Сумма двух чисел - {0}.", readerSum.Read());
                    }
                }

            }
            Console.ReadLine();
        }
    }
}