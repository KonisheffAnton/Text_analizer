using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace TEXT_ANALIZER
{
    class Unic_word: IComparable
    {
        private string Word;
        private uint word_count = 1;

        public string method_Word { get => Word; set => Word = value; }
        public uint Word_count { get => word_count; set => word_count = value; }



        public int CompareTo(object? obj)
        {
            if ((obj == null) || (!(obj is Unic_word)))
                return 0;
            else
                return string.Compare(Word, ((Unic_word)obj).Word);
        }

        

        public void Increment_count_of_unic_word()
        {
           this.Word_count = ++Word_count;
        }
    }
}
