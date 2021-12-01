using Microsoft.AspNetCore.Mvc;

namespace backend.Controllers;

[Route("api/[helloworld]")]
[ApiController]

    public class HelloWorldController
    {
        static void Main(string[] args) {
            Console.WriteLine("Hello Kris!");
            Console.ReadKey();
        }
    }
