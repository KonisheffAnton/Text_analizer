using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace TEXT_ANALIZER
{
    class OperationWithFile
    {

        

        public static async Task WriteClass(List<Unic_word> unic_Words)
        {
            using StreamWriter file = new StreamWriter("Itogovii_document.txt");

            foreach (var item in unic_Words)
            {
                    await file.WriteLineAsync(item.method_Word + " " + item.Word_count);
            }
        }
    }
}



