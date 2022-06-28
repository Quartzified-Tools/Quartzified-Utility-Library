using System;

namespace Quartzified.Common
{
    public class Convert
    {
        /// <summary>
        /// Converts byte array to bool
        /// </summary>
        /// <param name='array'>Byte array to convert</param>
        /// <returns>Bool from byte array</returns>
        public static bool BytesToBool(byte[] array)
        {
            if ((array == null) || (array.Length != 1))
                throw new Exception("Unable to convert bytes to bool");

            return BitConverter.ToBoolean(array, 0);
        }

        /// <summary>
        /// Converts bool to byte array
        /// </summary>
        /// <param name='value'>Bool to convert</param>
        /// <returns>Byte array from bool</returns>
        public static byte[] BoolToBytes(bool value)
        {
            byte[] bytes = BitConverter.GetBytes(value);

            if (1 != bytes.Length)
                throw new Exception(string.Format("Size of bool does not match the length of created byte array"));

            return bytes;
        }
    }
}


