using System.Collections.Generic;
using System.Linq;

namespace TrapezoidCipher
{
    
    public class NumericalKey : INumericalKey
    {
        
        public List<int> GetKey(string keyword)
        {
            List<string> heavyKeyword = new List<string>();

            foreach (char word in keyword)
            {
                heavyKeyword.Add(word.ToString());
            }

            return GetKey(heavyKeyword);
        }

        private List<int> GetKey(List<string> keyword)
        {
            var sorted = keyword.OrderBy(letter => letter).ToList();

            for (var ct = 0; ct < sorted.Count; ct++)
            {
                string letter = sorted[ct];
                int replacement = (ct + 1);

                var letterIndex = keyword.IndexOf(letter);
                keyword[letterIndex] = replacement.ToString();
            }

            List<int> key = new List<int>();
            foreach (var numerical in keyword)
            {
                key.Add(int.Parse(numerical));
            }

            return key.ToList();
        }
    }
}
