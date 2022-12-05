namespace Interpreter_BrainFuck
{
    /// <summary>
    /// Перебирает исходный код на BrainFuck
    /// </summary>
    public class Parser
    {
        public static void ParseCode()
        {
            string code = Buffer.PutUserCode();

            for (int i = 0; i < code.Length; i++)
            {
                _executeCommand(ref i, code);
            }
        }

        static private void _executeCommand(ref int i, string code)
        {
            switch (code[i])
            {
                case '+': Buffer.Memory.Add(); break;
                case '-': Buffer.Memory.Reduce(); break;
                case '>': Buffer.Memory.MovForward(); break;
                case '<': Buffer.Memory.MovBackward(); break;
                case '.': Buffer.Memory.Print(); break;
                case ',': Buffer.Memory.Scan(); break;
                case '[': Buffer.Memory.StartCycle(ref i, ref code); break;
                case ']': Buffer.Memory.EndCycle(ref i, ref code); break;
                default: break;
            }
        }
    }
}
