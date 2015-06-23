namespace BookStore.UI
{
    using System.IO;
    using Interfaces;

    public class FileRenderer : IRenderer
    {
        public void WriteLine(string message, params object[] parameters)
        {
            using (var writer = File.AppendText(@"../../output.txt"))
            {
                writer.WriteLine(message, parameters);
            }
        }
    }
}
