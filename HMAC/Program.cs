using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMAC
{
    class Program
    {
        static void Main(string[] args)
        {
            const string firstMessage = "First Message";
            const string secondMessage = "Second Message";

            Console.WriteLine("HMAC");
            Console.WriteLine("----------------------------------");
            Console.WriteLine($"First Message : {firstMessage}");
            Console.WriteLine($"Second Message : {secondMessage}");
            Console.WriteLine();

            var key = HMAC.GenerateKey();

            var hmacMd5Message = HMAC.ComputeHmacmd5(Encoding.UTF8.GetBytes(firstMessage), key);
            var hmacMd5Message2 = HMAC.ComputeHmacmd5(Encoding.UTF8.GetBytes(secondMessage), key);

            var hmacSha1Message = HMAC.ComputeHmacSha1(Encoding.UTF8.GetBytes(firstMessage), key);
            var hmacSha1Message2 = HMAC.ComputeHmacSha1(Encoding.UTF8.GetBytes(secondMessage), key);

            var hmacSha256Message = HMAC.ComputeHmacSha256(Encoding.UTF8.GetBytes(firstMessage), key);
            var hmacSha256Message2 = HMAC.ComputeHmacSha256(Encoding.UTF8.GetBytes(secondMessage), key);

            var hmacSha512Message = HMAC.ComputeHmacSha512(Encoding.UTF8.GetBytes(firstMessage), key);
            var hmacSha512Message2 = HMAC.ComputeHmacSha512(Encoding.UTF8.GetBytes(secondMessage), key);

            Console.WriteLine();
            Console.WriteLine("MD5 HMAC");
            Console.WriteLine();
            Console.WriteLine($"Fist Message : {Convert.ToBase64String(hmacMd5Message)}");
            Console.WriteLine($"Second Message : {Convert.ToBase64String(hmacMd5Message2)}");

            Console.WriteLine();
            Console.WriteLine("SHA1 HMAC");
            Console.WriteLine();
            Console.WriteLine($"Fist Message : {Convert.ToBase64String(hmacSha1Message)}");
            Console.WriteLine($"Second Message : {Convert.ToBase64String(hmacSha1Message2)}");

            Console.WriteLine();
            Console.WriteLine("SHA256 HMAC");
            Console.WriteLine();
            Console.WriteLine($"Fist Message : {Convert.ToBase64String(hmacSha256Message)}");
            Console.WriteLine($"Second Message : {Convert.ToBase64String(hmacSha256Message2)}");

            Console.WriteLine();
            Console.WriteLine("SHA512 HMAC");
            Console.WriteLine();
            Console.WriteLine($"Fist Message : {Convert.ToBase64String(hmacSha512Message)}");
            Console.WriteLine($"Second Message : {Convert.ToBase64String(hmacSha512Message2)}");

        }
    }
}
