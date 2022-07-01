using System;
using System.Security.Cryptography;
using System.Text;

namespace Quartzified.Cryptography
{
	public class Cryptography
	{
		/// <summary>
		/// Hashes the Input with use of a salt
		/// </summary>
		/// <param name="input">Input to Encrypt</param>
		/// <param name="salt">Encryption Salt</param>
		/// <returns></returns>
		public static string PBKDF2Hash(string input, string salt)
		{
			byte[] bytes = Encoding.UTF8.GetBytes(salt);
			return BitConverter.ToString(new Rfc2898DeriveBytes(input, bytes, 10000).GetBytes(20)).Replace("-", string.Empty);
		}

		/// <summary>
		/// Hashes the Input with use of a salt
		/// </summary>
		/// <param name="input">Input to Encrypt</param>
		/// <param name="salt">Encryption Salt</param>
		/// <returns></returns>
		public static string PBKDF2Hash(string input, int salt)
		{
			byte[] bytes = BitConverter.GetBytes(salt);
			return BitConverter.ToString(new Rfc2898DeriveBytes(input, bytes, 10000).GetBytes(20)).Replace("-", string.Empty);
		}
	}
}
