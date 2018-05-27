using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tasks.Lib.Module;

namespace HW_File_Work
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Последовательность целых чисел");
            Console.WriteLine();
            TaskFibonachi task = new TaskFibonachi();
            task.TaskFib();

            Console.WriteLine();
            Console.WriteLine("===============================================");
            Console.WriteLine();

            Console.WriteLine("Сумма чисел А и В.");
            Console.WriteLine();
            SummAB s = new SummAB();
            s.Summ();
        }
    }
}
