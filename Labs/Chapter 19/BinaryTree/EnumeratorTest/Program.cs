using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BinaryTree;

namespace EnumeratorTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Tree<int> tree1 = new Tree<int>(10);
            tree1.Insert(5);
            tree1.Insert(11);
            tree1.Insert(5);
            tree1.Insert(-12);
            tree1.Insert(15);
            tree1.Insert(0); 
            tree1.Insert(14);
            tree1.Insert(-8);
            tree1.Insert(10);

            foreach (int item in tree1)
                Console.WriteLine(item);

            Tree<char> tree2 = new Tree<char>(' ');
            tree2.Insert('A');
            tree2.Insert('N');
            tree2.Insert('T');
            tree2.Insert('H');
            tree2.Insert('O');
            tree2.Insert('N');
            tree2.Insert('Y');

           foreach (char i in tree2)
                Console.WriteLine(i);
           
            Console.WriteLine("----------------------------------------");
            foreach (var i in tree2)
                Console.WriteLine((int)i);

            Console.WriteLine("----------------------------------------");
            
            Tree<char> tree3 = new Tree<char>(' ');
            tree3.Insert('A');
            tree3.Insert('B');
            tree3.Insert('C');
            tree3.Insert('D');
            tree3.Insert('E');
            tree3.Insert('F');
            tree3.Insert('G');
            foreach (var i in tree3)
                Console.WriteLine((int)i);

        }
    }
}
