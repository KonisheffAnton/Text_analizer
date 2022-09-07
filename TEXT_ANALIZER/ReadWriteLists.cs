using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace TEXT_ANALIZER
{
    class ReadWriteLists
    {
        public static string RemoveSpecialCharacters(string str)
        {
            var sb = new StringBuilder();
            foreach (char c in str)
            {
                if ((c >= 'A' && c <= 'Z') || (c >= 'a' && c <= 'z') || (c >= 'А' && c <= 'Я') || (c >= 'а' && c <= 'я') || c == '\'' || c == ' ')
                {
                    sb.Append(c);
                }
            }
            return sb.ToString();
        }

        public static async Task<List<Unic_word>> FallAsync(List<Unic_word> unic_WordsList, string path)
        {
            using (StreamReader reader = new StreamReader(path))
            {
                string? line;
                Boolean crutch = false;
                try
                {
                    while ((line = await reader.ReadLineAsync()) != null)
                    {
                        string[] words = ReadWriteLists.RemoveSpecialCharacters(line).Split(' ');
                        foreach (var item_line in words)
                        {
                            crutch = false;
                            unic_WordsList.ForEach(delegate (Unic_word unic_Word)
                            {

                                if (unic_Word.method_Word == item_line)
                                {
                                    unic_Word.Increment_count_of_unic_word();
                                    crutch = true;
                                    return;
                                }

                            });
                            if (crutch == false && item_line != " ") unic_WordsList.Add(new Unic_word() { method_Word = item_line });
                        }
                    }
                    unic_WordsList.Sort(delegate (Unic_word x, Unic_word y)
                    {
                        if (x == null && y == null) return 0;
                        else if (x == null) return -1;
                        else if (y == null) return 1;
                        else
                            return x.Word_count.CompareTo(y.Word_count);
                    });
                    unic_WordsList.Reverse();
                    return unic_WordsList;
                }
                catch {
                    Console.WriteLine("Не выполнен основной метод в readwriteLists");
                    return unic_WordsList; 
                };
            }
        }
    }
}
        
