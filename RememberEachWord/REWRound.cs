using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using System.Windows.Forms;

namespace RememberEachWord
{
    class REWRound
    {
        private string roundName = "";
        private string[] words;
        private bool[] states;

        public string RoundName
        {
            get { return roundName; }
            set { roundName = value; }
        }

        public int WordsCount
        { get { return words.Length; } }
        

        public REWRound(string nm, int wnum)
        {
            roundName = nm;
            words = new string[wnum];
            states = new bool[wnum];
            for (int i = 0; i < wnum; i++)
            {
                words[i] = "";
                states[i] = false;
            }
        }

        ~REWRound()
        {
            int wnum = words.Length;
            for (int i = 0; i < wnum; i++)
            {
                words[i] = null;
            }
            words = null;
        }

        public override string ToString()
        {
            return roundName;
        }

        public string GetTxtAt(int ind)
        {
            if ((ind >= 0) && (ind < words.Length))
            {
                return words[ind];
            }
            else return "";
        }

        public bool GetStateAt(int ind)
        {
            if ((ind >= 0) && (ind < words.Length))
            {
                return states[ind];
            }
            else return false;
        }

        public void SetAt(string txt, bool st, int ind)
        {
            if ((ind >= 0) && (ind < words.Length))
            {
                words[ind] = txt;
                states[ind] = st;
            }
        }

        public static void SaveRound(REWRound rr, ProjFileStream pfs)
        {
            pfs.WriteString(rr.roundName);
            for (int i = 0; i < rr.WordsCount; i++)
            {
                pfs.WriteString(rr.words[i]);
                pfs.WriteBool(rr.states[i]);
            }
        }

        public static REWRound LoadRound(ProjFileStream pfs, int fileCount, int maxCount)
        {
            string name = pfs.ReadString();
            REWRound rr = new REWRound(name, maxCount);
            for (int i = 0; i < fileCount; i++ )
            {
                string wrd = pfs.ReadString();
                bool stt = pfs.ReadBool();
                if (i < maxCount)
                {
                    rr.SetAt(wrd, stt, i);
                }
            }

            return rr;
        }
    }
}
