using System;

namespace _05.HTML_Dispatcher
{
    class HTMLDispatcherMain
    {
        static void Main()
        {
            var div = new ElementBuilder("div");
            div.AddAttribute("id", "page");
            div.AddAttribute("class", "big");
            div.AddContent("<p>Hello</p>");
            Console.WriteLine(div * 3);
            Console.WriteLine();

            var p = new ElementBuilder("p");
            p.AddAttribute("style", "font-size: 5px;");
            Console.WriteLine(p);
            Console.WriteLine();

            p.AddContent("This is a paragraph");
            Console.WriteLine(p);
            Console.WriteLine();

            Console.WriteLine(p * 15);
            Console.WriteLine();

            var image = HTMLDispatcher.CreateImage(@"http://www.google.bg", "missing", "Google");
            Console.WriteLine(image);
            Console.WriteLine();

            var link = HTMLDispatcher.CreateURL(@"https://facebook.com", "Facebook", "Click me!");
            Console.WriteLine(link);
            Console.WriteLine();

            var input = HTMLDispatcher.CreateInput("radio", "gender", "0");
            Console.WriteLine(input);
            Console.WriteLine();
        }
    }
}
