using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            char resultValue = NonRepeatFunctionReturnValue("aaaaaabbbsasdweqwe");
            //char resultValue = NonRepeatFunctionReturnValue("aaaaaabbbsasweweq");
            //char resultValue = NonRepeatFunctionReturnValue("qaaaaaabbbsaswewe");
            //char resultValue = NonRepeatFunctionReturnValue("aaaaaabbbsaswewe");

            if (resultValue != '\0')
                Console.WriteLine("Sonuc : " + resultValue + " ");
            else
                Console.WriteLine("Tekrar etmeyen karakter bulunamadı");

            Console.ReadKey();
        }

        private static char NonRepeatFunctionReturnValue(string value)
        {
            for (var i = 0; i < value.Length; i++)
            {
                char character = value[i];

                if (value.IndexOf(character) == i && value.IndexOf(character, i + 1) == -1)
                {
                    return character;
                }
            }
            return '\0';
        }
    }
}
