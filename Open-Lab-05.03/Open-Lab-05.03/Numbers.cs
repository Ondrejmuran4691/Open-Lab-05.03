using System;
using System.Linq;
namespace Open_Lab_05._03
{
    public class Numbers
    {
        public string FormatNum(int num)
        {
            string n = "";
            string nu = "";
            int counter = 0;
            string final = "";
            string final2 = "";
            nu = num.ToString();
            foreach(char c in nu.Reverse())
            {
                n += c;
                counter++;
                if(counter%3 == 0)
                {
                    n += ",";
                }
            }
            final = n.ToString(); ;
            foreach (char c in final.Reverse())
            {
                final2 += c;
            }
            if (final2.StartsWith(","))
            {

                final2 = final2.Remove(0, 1);
            }
            return final2.ToString();
        }
    }
}
