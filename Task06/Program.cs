using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task06
{
    class Program
    {
        [Flags]
        enum FontStyle:byte
        {
            None = 0,
            Bold = 1,
            Italic = 2,
            Underline =4,
        }

        static void Main(string[] args)
        {
            FontStyle style = FontStyle.None;
            Console.ForegroundColor = ConsoleColor.Green;
            ShowStyles(style);
            MainLogic(ref style);
        }

        private static void MainLogic(ref FontStyle style)
        {
            SelectStyleType(ReadStyle(), ref style);
        }

        private static void SelectStyleType(char v, ref FontStyle style)
        {
            switch (v)
            {
                case '1':
                    ChangeStyle(ref style, FontStyle.Bold);
                    break;
                case '2':
                    ChangeStyle(ref style, FontStyle.Italic);
                    break;
                case '3':
                    ChangeStyle(ref style, FontStyle.Underline);
                    break;
            }
        }

        private static char ReadStyle()
        {
            Console.WriteLine("Введите:");
            Console.WriteLine("       1: bold");
            Console.WriteLine("       2: italic");
            Console.WriteLine("       3: underline");
            Console.WriteLine("Любую другую клавишу для выхода");
            return Console.ReadKey().KeyChar;
        }

        private static void ChangeStyle(ref FontStyle style, FontStyle newStyle)
        {
            style = style ^ newStyle;
            ShowStyles(style);
            MainLogic(ref style);
        }

        private static void ShowStyles(FontStyle style)
        {
            Console.WriteLine("");
            Console.WriteLine("Параметры надписи: {0}", style);
        }
    }
}
