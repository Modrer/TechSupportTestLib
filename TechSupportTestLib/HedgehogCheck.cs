namespace HedgehogCheckLib
{
    public static class HedgehogCheck
    {
        private static (int, int, int) GetNumbers(int[] hendehogs, int colorNum)
        {
            return colorNum switch
            {
                0 => (hendehogs[0], hendehogs[1], hendehogs[2]),
                1 => (hendehogs[1], hendehogs[2], hendehogs[0]),
                2 => (hendehogs[2], hendehogs[1], hendehogs[0]),
                _ => (0, 0, 0),
            };
        }

        public static int Check(int[] hendehogs, int colorNum)
        {
            int mainCollor, color1, color2;
            (mainCollor, color1, color2) = GetNumbers(hendehogs, colorNum);

            int count;

            //First exchange of colors
            (count, color2, mainCollor) = (color1 < color2) switch
            {
                true => (color2, color2 - color1, mainCollor + color1 * 2),
                _ => (color1, color1 - color2, mainCollor + color2 * 2)
            };

            //If color2 % 3 =! 0 then we cant turn all into one color
            if (color2 % 3 != 0)
            {
                return -1;
            }

            if (color2 != 0 && mainCollor == 0)
            {
                return -1;
            }

            return count;

        }
    }
}
