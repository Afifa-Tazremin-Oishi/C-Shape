using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_3
{

    /// <summary>
    /// Indexer Overloading.........................
    /// </summary>

    class IndexedNames
    {
        private string[] namelist = new string[size];
        static public int size = 10;

        public IndexedNames()
        {
            for (int i = 0; i < size; i++)
            {
                namelist[i] = "AIUB";
            }
        }
        public string this[int index]
        {
            get
            {
                string tmp;

                if (index >= 0 && index <= size - 1)
                {
                    tmp = namelist[index];
                }
                else
                {
                    tmp = "";
                }

                return (tmp);
            }
            set
            {
                if (index >= 0 && index <= size - 1)
                {
                    namelist[index] = value;
                }
            }
        }

        public int this[string name]
        {
            get
            {
                int index = 0;

                while (index < size)
                {
                    if (namelist[index] == name)
                    {
                        return index;
                    }
                    index++;
                }
                return index;
            }
        }

        static void Main(string[] args)
        {
            IndexedNames names = new IndexedNames();

            names[0] = "A";
            names[1] = "I";
            names[2] = "U";
            names[3] = "B";
            names[4] = "I";
            names[5] = "A";
            names[6] = "N";
            names[7] = "!";

            //using the first indexer with int parameter
            for (int i = 0; i < IndexedNames.size; i++)
            {
                Console.Write(names[i]+" ");
            }
            Console.WriteLine();

            //using the second indexer with the string parameter
            Console.WriteLine(names["A"]);
            Console.WriteLine(names["I"]);
            Console.WriteLine(names["U"]);
            Console.WriteLine(names["B"]);
            Console.WriteLine(names["!"]);
            Console.ReadKey();
        }
    }
}
