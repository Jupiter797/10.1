using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10._1
{
    class Alpha
    {
        protected int intValue;

        public Alpha(int value)
        {
            intValue = value;
        }

        public virtual void Set(int value)
        {
            intValue = value;
        }

        public virtual void Show()
        {
            Console.WriteLine($"Значення цілочисельного поля: {intValue}");
        }
    }

    class Bravo : Alpha
    {
        private string textField;

        public Bravo(int value, string text) : base(value)
        {
            textField = text;
        }

        public override void Set(int value)
        {
            base.Set(value);
        }

        public void Set(string text)
        {
            textField = text;
        }

        public override void Show()
        {
            base.Show();
            Console.WriteLine($"Значення текстового поля: {textField}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;

            Bravo bravo = new Bravo(1, "Один");

            bravo.Show();

            bravo.Set(2);

            bravo.Set("Два");

            bravo.Show();

            Console.CursorVisible = false;
            Console.ReadKey();
        }
    }
}
