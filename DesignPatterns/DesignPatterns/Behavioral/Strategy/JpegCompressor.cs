namespace DesignPatterns.Behavioral.Strategy
{
    internal class JpegCompressor : ICompressor
    {
        public void Compress(string fileName)
        {
            Console.WriteLine("Compressing using Jpeg");
        }
        private static string tens(string number)
        {
            string name = "";
            //int _number = Convert.ToInt32(number);
            //bool isTensNumber = tens_Word.Where(x => x.Key == _number).Count() > 0;
            //if (!isTensNumber && _number > 0)
            //    name = tens(number.Substring(0, 1) + "0") + "-" + ones(number.Substring(1));
            //else
            //    name = tens_Word[_number];
            return name;
        }
        private static string ones(string number)
        {
            int _number = Convert.ToInt32(number);
            //return ones_Word[_number];
            return "";
        }
    }
}
