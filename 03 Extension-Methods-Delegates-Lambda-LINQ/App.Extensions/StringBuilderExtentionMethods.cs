namespace App.Extensions
{
    using System.Text;

    public static class StringBuilderExtentionMethods
    {
        public static StringBuilder Substring(this StringBuilder sb, int index)
        {
            StringBuilder sbSubstring = new StringBuilder();

            string sbString = sb.ToString();
            int length = sbString.Length - index;
            sbString = sbString.Substring(index, length);
            sbSubstring.Append(sbString);

            return sbSubstring;
        }

        public static StringBuilder Substring(this StringBuilder sb, int index, int length)
        {
            StringBuilder sbSubstring = new StringBuilder();

            string sbString = sb.ToString().Substring(index,length);
            sbSubstring.Append(sbString);

            return sbSubstring;
        }
    }
}