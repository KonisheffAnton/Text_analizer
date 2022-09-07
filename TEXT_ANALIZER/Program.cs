using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

namespace TEXT_ANALIZER
{
    class Program
    {

        static async Task Main(string[] args)
        {


                 string path = "";
                 try
                 {
                     Console.Write("Введите путь: ");
                     path = Console.ReadLine();
                 }
                 catch
                 {
                     Console.WriteLine("Неверный формат ввода");
                 }   
                 List<Unic_word> unic_WordsList = new List<Unic_word>();
                 if (path != null)
                 {
                     try
                     {
                         await OperationWithFile.WriteClass(await ReadWriteLists.FallAsync(unic_WordsList, path));
                     }
                     catch
                     {

                     }
                 }
                 else Console.WriteLine("Неверный путь");
             }
        }
    }

