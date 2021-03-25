using System;

namespace Tuplas_y_Prog_Funcional
{
    class Program
    {
        static void Main(string[] args)
        {

            var van = Sol();

            van.Counter.Increment();
            Console.WriteLine(van.Counter.get());
            van.SolDB.Add(1);

        }

        public static (

            (Action Increment, Action Substract, Func<int> get) Counter,
            (Action<int> Add, Action<int> Update, Action<int> Delete) SolDB
            )

            Sol() => (

                Counter(),

                SolDB()

                );

        private static (Action Increment, Action Substract, Func<int> get) Counter()
        {
            throw new NotImplementedException();
        }

        private static (Action<int> Add, Action<int> Update, Action<int> Delete) SolDB()
        {
            throw new NotImplementedException();
        }

       
    }
}
