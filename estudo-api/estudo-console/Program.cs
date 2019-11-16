using System;
using estudo_jwt;

namespace estudo_console
{
    class Program
    {
        static void Main(string[] args)
        {
            var jwt = new estudo_jwt.EstudoJWT();
            var token = jwt.CreateToken(args[0]);
            Console.WriteLine(token);
            Console.WriteLine(jwt.ValidateToken(token).ToString());
            Console.ReadLine();
        }
    }
}
