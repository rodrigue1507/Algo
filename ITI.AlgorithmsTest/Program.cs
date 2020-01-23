using System;
using NUnit.Common;
using NUnitLite;
namespace ITI.AlgorithmsTest
{
    class Program
    {
        static int Main(string[] args)
        {
          return new AutoRun(typeof(Program).Assembly).Execute(args, new ExtendedTextWrapper(Console.Out), Console.In);    
        }
    }
}
