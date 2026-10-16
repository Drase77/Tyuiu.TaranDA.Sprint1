using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.TaranDA.Sprint1.Task6.V9.Lib
{
    public class DataService : ISprint1Task6V9
    {
        public string MoveLetterToStart(string value)
        {
            string[] words = value.Split(
                new[] { ' ' },
                StringSplitOptions.RemoveEmptyEntries
            );

            for (int i = 0; i < words.Length; i++)
            {
                string word = words[i];

                if (word.Length > 1)
                {
                    words[i] = word.Substring(word.Length - 1)
                                + word.Substring(0, word.Length - 1);
                }
            }

            return string.Join(" ", words);
        }
    }
}