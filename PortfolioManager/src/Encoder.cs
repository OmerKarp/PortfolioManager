using System;

namespace PortfolioManager.src
{
    internal class Encoder
    {
        // Method to transform digits based on the given or current day (Encoding)
        private static string TransformPrice(string price, bool isEncoding, int? dayOfMonth = null)
        {
            // If dayOfMonth is not provided, use the current day
            if (dayOfMonth == null)
            {
                dayOfMonth = DateTime.Now.Day;
            }

            int formulaResult = 2 * dayOfMonth.Value * dayOfMonth.Value + dayOfMonth.Value + 7; // 2x^2 + x + 7 formula

            char[] transformedChars = new char[price.Length];

            // Loop through each digit and transform it based on the day
            for (int i = 0; i < price.Length; i++)
            {
                char digit = price[i];
                int digitValue = int.Parse(digit.ToString());

                // Calculate a transformation based on the formula result
                int shift = (formulaResult + i) % 10; // Shift changes based on formula result + index

                // Encoding or Decoding based on the flag
                int newDigit = isEncoding ? (digitValue + shift) % 10 : (digitValue - shift + 10) % 10;

                transformedChars[i] = newDigit.ToString()[0];
            }

            return new string(transformedChars);
        }

        // Encoding function (scrambles and transforms)
        public static string EncodePrice(string price, int? dayOfMonth = null)
        {
            return TransformPrice(price, true, dayOfMonth); // True means encoding
        }

        // Decoding function (reverses the encoding)
        public static string DecodePrice(string encodedPrice, int? dayOfMonth = null)
        {
            return TransformPrice(encodedPrice, false, dayOfMonth); // False means decoding
        }

        static void Main(string[] args)
        {
            Console.Write("Enter a price (6-7 digits): ");
            string price = Console.ReadLine();

            if (!string.IsNullOrEmpty(price))
            {
                // Optionally pass a specific dayOfMonth, or leave it null to use the current day
                string encodedPrice = EncodePrice(price); // Uses current day by default
                Console.WriteLine($"Encoded Price: {encodedPrice}");

                string decodedPrice = DecodePrice(encodedPrice); // Uses current day by default
                Console.WriteLine($"Decoded Price: {decodedPrice}");
            }
            else
            {
                Console.WriteLine("Invalid input.");
            }

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
