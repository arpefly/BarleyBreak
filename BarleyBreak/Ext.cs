using System;

namespace BarleyBreak
{
    public static class Ext
    {
        private static readonly Random random = new Random();

        public static void ShuffleInProcess(this string[] array)
        {
            string temp;
            int a, b;

            for (byte i = 0; i < 100; i++)
            {
                a = random.Next(0, 16);
                b = random.Next(0, 16);

                temp = array[a];
                array[a] = array[b];
                array[b] = temp;
            }
        }   // Расширение перемешивания массива возможных значений кнопки
    }
}