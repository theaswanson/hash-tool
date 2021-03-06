﻿using CSharpTest.Net.Crypto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace hashtool
{
    public class TextHasher: IHasher
    {
        public TextHasher (string textToHash = "")
        {
            this.textToHash = textToHash;
        }

        public string textToHash;

        public string GetBase64()
        {
            var plainTextBytes = System.Text.Encoding.UTF8.GetBytes(textToHash);
            return System.Convert.ToBase64String(plainTextBytes);
        }
        public string GetMD5()
        {
            MD5 md5Hash = MD5.Create();
            byte[] data = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(textToHash));
            return BytesToHash(data);
        }
        public string GetSHA1()
        {
            SHA1 sha1Hash = SHA1.Create();
            byte[] data = sha1Hash.ComputeHash(Encoding.UTF8.GetBytes(textToHash));
            return BytesToHash(data);
        }
        public string GetSHA256()
        {
            SHA256 sha256Hash = SHA256.Create();
            byte[] data = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(textToHash));
            return BytesToHash(data);
        }
        public string GetSHA512()
        {
            SHA512 sha512Hash = SHA512.Create();
            byte[] data = sha512Hash.ComputeHash(Encoding.UTF8.GetBytes(textToHash));
            return BytesToHash(data);
        }
        public string GetMD4()
        {
            // get padded uints from bytes
            List<byte> bytes = Encoding.ASCII.GetBytes(textToHash).ToList();
            uint bitCount = (uint)(bytes.Count) * 8;
            bytes.Add(128);
            while (bytes.Count % 64 != 56) bytes.Add(0);
            var uints = new List<uint>();
            for (int i = 0; i + 3 < bytes.Count; i += 4)
                uints.Add(bytes[i] | (uint)bytes[i + 1] << 8 | (uint)bytes[i + 2] << 16 | (uint)bytes[i + 3] << 24);
            uints.Add(bitCount);
            uints.Add(0);

            // run rounds
            uint a = 0x67452301, b = 0xefcdab89, c = 0x98badcfe, d = 0x10325476;
            Func<uint, uint, uint> rol = (x, y) => x << (int)y | x >> 32 - (int)y;
            for (int q = 0; q + 15 < uints.Count; q += 16)
            {
                var chunk = uints.GetRange(q, 16);
                uint aa = a, bb = b, cc = c, dd = d;
                Action<Func<uint, uint, uint, uint>, uint[]> round = (f, y) =>
                {
                    foreach (uint i in new[] { y[0], y[1], y[2], y[3] })
                    {
                        a = rol(a + f(b, c, d) + chunk[(int)(i + y[4])] + y[12], y[8]);
                        d = rol(d + f(a, b, c) + chunk[(int)(i + y[5])] + y[12], y[9]);
                        c = rol(c + f(d, a, b) + chunk[(int)(i + y[6])] + y[12], y[10]);
                        b = rol(b + f(c, d, a) + chunk[(int)(i + y[7])] + y[12], y[11]);
                    }
                };
                round((x, y, z) => (x & y) | (~x & z), new uint[] { 0, 4, 8, 12, 0, 1, 2, 3, 3, 7, 11, 19, 0 });
                round((x, y, z) => (x & y) | (x & z) | (y & z), new uint[] { 0, 1, 2, 3, 0, 4, 8, 12, 3, 5, 9, 13, 0x5a827999 });
                round((x, y, z) => x ^ y ^ z, new uint[] { 0, 2, 1, 3, 0, 8, 4, 12, 3, 9, 11, 15, 0x6ed9eba1 });
                a += aa; b += bb; c += cc; d += dd;
            }

            // return hex encoded string
            byte[] outBytes = new[] { a, b, c, d }.SelectMany(BitConverter.GetBytes).ToArray();
            return BitConverter.ToString(outBytes).Replace("-", "").ToLower();
        }
        public string GetROT13()
        {
            StringBuilder result = new StringBuilder();
            Regex regex = new Regex("[A-Za-z]");

            foreach (char c in textToHash)
            {
                if (regex.IsMatch(c.ToString()))
                {
                    int charCode = ((c & 223) - 52) % 26 + (c & 32) + 65;
                    result.Append((char)charCode);
                }
                else
                {
                    result.Append(c);
                }
            }

            return result.ToString();
        }
        public string GetWhirlpool()
        {
            WhirlpoolManaged whirlpoolHash = new WhirlpoolManaged();
            byte[] data = whirlpoolHash.ComputeHash(Encoding.UTF8.GetBytes(textToHash));
            return BytesToHash(data);
        }
        private string BytesToHash(byte[] data)
        {
            // Create a new Stringbuilder to collect the bytes
            // and create a string.
            StringBuilder sBuilder = new StringBuilder();

            // Loop through each byte of the hashed data 
            // and format each one as a hexadecimal string.
            for (int i = 0; i < data.Length; i++)
                sBuilder.Append(data[i].ToString("x2"));

            // Return the hexadecimal string.
            return sBuilder.ToString();
        }
    }
}
