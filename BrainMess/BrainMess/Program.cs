using System;
using System.Collections.Generic;
using System.Globalization;

namespace BrainMess
{
   public class BrainMessInterpreter
    {
        public List<int> tape;
        public int tapeHead = 0;

        public BrainMessInterpreter()
        {
            tape = new List<int>();
            tape.Add(0);
        }

        public void Forward()
        {
            ++tapeHead;
            if (tapeHead + 1 > tape.Count)
            {
                tape.Insert(tapeHead, 0);
            }
        }

        public void Backward()
        {
            --tapeHead;
        }

        public void Increment()
        {
            ++tape[tapeHead];
        }

        public void Decrement()
        {
            --tape[tapeHead];
        }

        public void Print()
        {
            Console.WriteLine(((char)tape[tapeHead]).ToString(CultureInfo.InvariantCulture));
        }

        public void Record()
        {
            throw new Exception("Not Implemented!");
        }

        public void LoopForward(int position, string input)
        {
            if (int.Parse(tape[tapeHead].ToString(CultureInfo.InvariantCulture)) != 0)
            {
                int length = input.IndexOf("]", position, StringComparison.Ordinal);
                string substr = input.Substring(position + 1, length - position - 1);
                while (tape[tapeHead] >1)
                {
                    Interprate(substr);
                }
            }
        }


        public void Interprate(string input)
        {
            if (!String.IsNullOrEmpty(input))
            {
                char[] inputchararray = input.ToCharArray(0, input.Length);
                int counter = 0;
                foreach (char sign in inputchararray)
                {
                    switch (sign)
                    {
                        case '>':
                            Forward();
                            break;
                        case '<':
                            Backward();
                            break;
                        case '+':
                            Increment();
                            break;
                        case '-':
                            Decrement();
                            break;
                        case '.':
                            Print();
                            break;
                        case ',':
                            Record();
                            break;
                        case '[':
                            LoopForward(counter, input);
                            break;
                      }
                    counter++;
                }
            }
        }
    }

    class BrainMessConsole
    {
        static void Main()
        {
            string phrase = Console.ReadLine();
            BrainMessInterpreter objbrainmess = new BrainMessInterpreter();
            objbrainmess.Interprate(phrase);
            Console.ReadLine();
        }
    }
}
