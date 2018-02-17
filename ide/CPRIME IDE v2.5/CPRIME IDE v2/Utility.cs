using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CPRIME_IDE_v2
{
    static class Utility
    {
        public static void HighlightText(RichTextBox myRtb, string word, Color colorf, Color colort)
        {

            if (word == string.Empty)
                return;

            int s_start = myRtb.SelectionStart, startIndex = 0, index;

            while ((index = myRtb.Text.IndexOf(word, startIndex)) != -1)
            {
                myRtb.Select(index, word.Length);
                myRtb.SelectionColor = colort;
                myRtb.SelectionBackColor = colorf;
                startIndex = index + word.Length;
            }
            /*myRtb.SelectionStart = s_start;
            myRtb.SelectionLength = 0;
            myRtb.SelectionColor = Color.Black;*/
        }

    }
}
