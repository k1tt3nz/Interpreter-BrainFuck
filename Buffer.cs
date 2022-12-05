using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Interpreter_BrainFuck.Buffer;

namespace Interpreter_BrainFuck
{
    static public class Buffer
    {
        static string? userCodeBF;
        static char[] memory = new char[30000];
        static int ptr = 0;                         // Положение указателя на массиве
        static int lvlNesting = 0;                  // Уровень вложености

        static public void InitCode() => _inputCode();

        static private void _inputCode() => userCodeBF = Console.ReadLine();

        static public void OutputInterpretations() => _outputMem();

        static private void _outputMem() => Console.WriteLine(userCodeBF);

        static public string PutUserCode() => _returnUserCodeBF();

        static private string _returnUserCodeBF() { return userCodeBF; }


        /*static public void Empty()
        {
            if (_isCodeEmpty()) Console.WriteLine("Пустя строка ввода");

            InitCode();
        }

        static private bool _isCodeEmpty()
        {
            return userCodeBF == null ? true : false;
        }*/

        static public class Memory
        {
            static public void MovForward() { ptr++; }                                                // >
            static public void MovBackward() { ptr--; }                                               // <
            static public void Add() { memory[ptr]++; }                                               // +
            static public void Reduce() { memory[ptr]--; }                                            // -
            static public void Print() { Console.Write(memory[ptr]); }                                // .
            static public void Scan() { memory[ptr] = (char)Console.Read(); }                         // ,
            static public void StartCycle(ref int i, ref string code) => _openCycle(ref i, ref code); // [
            static public void EndCycle(ref int i, ref string code) => _closeCycle(ref i, ref code);  // ]

            static public void _openCycle(ref int i, ref string code)
            {
                lvlNesting = 1;

                if (memory[ptr] == 0)
                {
                    while (lvlNesting > 0)
                    {
                        i++;

                        if (code[i] == '[') lvlNesting++;
                        else if (code[i] == ']') lvlNesting--;
                    }
                }
            }

            static public void _closeCycle(ref int i, ref string code)
            {
                lvlNesting = 1;

                if (memory[ptr] != 0)
                {
                    while (lvlNesting > 0)
                    {
                        i--;

                        if (code[i] == '[') lvlNesting--;
                        else if (code[i] == ']') lvlNesting++;
                    }
                }
            }
        }

    }
}

