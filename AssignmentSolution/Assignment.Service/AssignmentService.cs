using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Service
{
    public class AssignmentService : IAssignmentService
    {
        public int CalculateScore(string puzzle)
        {
            int score = 0;
        //    bool leftready = false;
            List<char> bracketlist = new List<char>();
            for (int i = 0; i < puzzle.Length; i++)
            {
                if (puzzle[i] == '!')
                {
                    i = i + 1;
                    continue;
                }
                if (puzzle[i] == '<')
                {

                    while (puzzle[i] != '>')
                    {
                        if (puzzle[i] == '!')
                        {
                            i = i + 2;
                            continue;
                        }
                        i = i + 1;
                        Console.WriteLine(i);
                    }
                }
                Console.WriteLine("now i =" + i);
                if (puzzle[i] == '{' || puzzle[i] == '}')
                {
                    bracketlist.Add(puzzle[i]);
                }


            }
            for (int i = 0; i < bracketlist.Count; i++)
            {
                Console.Write(bracketlist[i]);
            }
            // List<char> newlist = new List<char>();
            //int layer = 0;
            //int rightlayer = 1;
            //for(int i = 0; i < bracketlist.Count; i++)
            //{
            //    if (bracketlist[i] == '{')
            //    {

            //        leftready = true;
            //        layer++;
            //    }
            //    if (bracketlist[i] == '}') {
            //        if(leftready == true)
            //        {

            //            while (i+1!= bracketlist.Count&&bracketlist[i + 1] == '}')
            //            {

            //                rightlayer = rightlayer + 1;
            //                i = i + 1;

            //            }
            //          //  Console.WriteLine(rightlayer);
            //            int Minlayer = Math.Min(rightlayer, layer);
            //            int point = ((1 + Minlayer) * Minlayer) / 2;
            //          //  Console.WriteLine(point);
            //            score = score + point;
            //            leftready = false;
            //            layer = 0;
            //            rightlayer = 1;
            //        }
            //    }

            //}
            int counter = 0;
            for (int i = 0; i < bracketlist.Count; i++)
            {
                if (bracketlist[i] == '}')
                {
                    if (counter >= 0)
                    {
                        score = score + counter;
                        counter = counter - 1;
                    }
                }
                if (bracketlist[i] == '{')
                {
                    counter++;
                }

            }
            return score;
        }
    }
}
