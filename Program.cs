using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UAS_100
{
   class Node
    {
        public int IdObat;
        public string NamaObat;
        public char DosisObat;
        public char HargaObat;
        public Node next;
    }

    class List
    {
        Node START;

        public List()
        {
            START = null;
        }

        public void add()
        {
            int id;
            string nmObat;
            char dosObat;
            char hObat;

            Console.WriteLine("\nMasukkan Id Obat : ");
            id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\nMasukkan Nama Obat : ");
            nmObat = Console.ReadLine();
            Console.WriteLine("\nMasukkan Dosis Obat : ");
            dosObat = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("\nMasukkan Harga Obat : ");
            hObat = Convert.ToChar(Console.ReadLine());

            Node nodeBaru = new Node();
            nodeBaru.IdObat = id;
            nodeBaru.NamaObat = nmObat;
            nodeBaru.DosisObat = dosObat;
            nodeBaru.HargaObat = hObat;

            if (START == null || id == START.IdObat)
            {
                if ((START != null) && (id == START.IdObat))
                {
                    Console.WriteLine("");
                }

                nodeBaru.next = START;
                START = nodeBaru;
                return;
            }

            Node previous, current;
            previous = START;
            current = START;

            while ((current != null) &&(id == current.IdObat))
            {
                if (id == current.IdObat)
                {
                    Console.WriteLine("");
                    return;
                }
                previous = current;
                current = current.next;
            }
            nodeBaru.next = current;
            previous.next = nodeBaru;
        }

        public bool Search(int id, ref Node previous, ref Node current)
        {
            previous = current;
            while ((current != null) && (id == current.IdObat))
            {
                previous = current;
                current = current.next;
            }
            if (current == null)
                return (false);
            else
                return (true);
        }
        public void treverse()
        {
            if (listEmpty())
                Console.WriteLine("\nList kosong :");
            else
            {
                Console.WriteLine("\nData di dalam list adalah :");
                Node currentNode;
                for (currentNode = START; currentNode != null; currentNode = currentNode.next)
                    Console.Write(currentNode.IdObat + "" + currentNode.NamaObat + "" + currentNode.DosisObat + "" + currentNode.HargaObat +  "\n");
                Console.WriteLine();
            }
        }

        public bool listEmpty()
        {
            if (START == null)
                return true;
            else
                return false;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List obj = new List();
            while (true)
            {
                try
                {
                    Console.WriteLine("\nMenu");
                    Console.WriteLine("1. Menambah data kedalam List");
                    Console.WriteLine("2. Melihat semua data didalam List");
                    Console.WriteLine("3. Mencari Sebuah data didalam List");
                    Console.WriteLine("4. Exit");
                    Console.WriteLine("\nMasukkan pilihan anda (1-4): ");
                    char ch = Convert.ToChar(Console.ReadLine());
                    switch (ch)
                    {
                        case '1':
                            {
                                obj.add();
                            }
                            break;
                        case '2':
                            {
                                obj.treverse();
                            }
                            break;
                        case '3':
                            {
                                if (obj.listEmpty() == true)
                                {
                                    Console.WriteLine("\nList Kosong !");
                                    break;
                                }
                                Node previous, current;
                                previous = current = null;
                                Console.Write("\nMasukkan Id Obat Yang Ingin Dicari : ");
                                int num = Convert.ToInt32(Console.ReadLine());
                                if (obj.Search(num, ref previous, ref current) == false)
                                    Console.WriteLine("\nData tidak ditemukan.");
                                else
                                {
                                    Console.WriteLine("\nData ketemu");
                                    Console.WriteLine("\nNomor Mahasiswa: " + current.IdObat);
                                    Console.WriteLine("\nNama: " + current.NamaObat);
                                }
                            }
                            break;
                        case '4':
                            return;
                        default:
                            {
                                Console.WriteLine("\nPilihan tidak valid");
                                break;
                            }
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("");
                }
            }
        }
    }
}


// 2. Singly Linked List
// 3. Array merupakan tempat untuk menyimpan data, sedangkan linked list merupakan sebuah algoritma yang digunakan untuk menyusun dan mengurutkan data.
// 4. Enqueue dan Dequeue
// 5. a. 3
//    b. Cara membacanya 80, 41, 53, 16, 25, 55, 46, 42. (Inorder)
