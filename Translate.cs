using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnglishTranslate
{
    class Translate
    {

        private string word;

        public Translate(string word)
        {
            this.word = word;
        }

        public string Word
        {
            get
            { return word; }
            set
            {
                word = value;
            }
        }

        public int TranslaterSrb(string fWordSrb)
        {
            if (fWordSrb == this.word)
            {
                return 1;

            }
            else
            {
                return 0;
            }
            

          
        }
        public int TranslaterEng(string fWordEng)
        {
            if (fWordEng == this.word)
            {
                return 1;
            }
            else
            {
                return 0;
            }



        }



    }
}
