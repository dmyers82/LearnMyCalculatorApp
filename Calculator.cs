using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;


namespace LearnMyCalculatorApp
{

    public class HexUtility
    {
        /// <summary>
        /// Convert an integer to a hex string (uppercase).
        /// </summary>
        public static string IntToHex(int value, int minDigits = 0)
        {
            return value.ToString("X" + minDigits);
        }

        /// <summary>
        /// Convert a hex string to an integer.
        /// </summary>
        public static int HexToInt(string hex)
        {
            return int.Parse(hex, NumberStyles.HexNumber);
        }

        /// <summary>
        /// Convert a byte array to a hex string (e.g., for hex dumps).
        /// </summary>
        public static string BytesToHex(byte[] data, bool uppercase = true)
        {
            StringBuilder sb = new StringBuilder(data.Length * 2);
            foreach (byte b in data)
            {
                sb.Append(b.ToString(uppercase ? "X2" : "x2"));
            }
            return sb.ToString();
        }

        /// <summary>
        /// Convert a hex string back into a byte array.
        /// </summary>
        public static byte[] HexToBytes(string hex)
        {
            if (hex.Length % 2 != 0)
                throw new ArgumentException("Hex string must have even length.");

            byte[] bytes = new byte[hex.Length / 2];
            for (int i = 0; i < hex.Length; i += 2)
            {
                bytes[i / 2] = byte.Parse(hex.Substring(i, 2), NumberStyles.HexNumber);
            }
            return bytes;
        }

        /// <summary>
        /// Create a formatted hex dump (like a hex editor view).
        /// </summary>
        public static string HexDump(byte[] data, int bytesPerLine = 16)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < data.Length; i += bytesPerLine)
            {
                sb.Append(i.ToString("X8")).Append(": ");
                for (int j = 0; j < bytesPerLine && i + j < data.Length; j++)
                {
                    sb.Append(data[i + j].ToString("X2")).Append(" ");
                }
                sb.AppendLine();
            }
            return sb.ToString();
        }
        public decimal HexToDecimal(string hexValue)
        {
            return Convert.ToDecimal(Convert.ToInt32(hexValue, 16));
        }
    }
}
