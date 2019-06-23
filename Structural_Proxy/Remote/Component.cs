using System.Net.Http;

namespace Structural_Proxy.Remote
{
    internal class Component
    {
        public void Process()
        {
            HttpClient remote = new HttpClient();
            remote.BaseAddress = new System.Uri("https://www.google.com");

            remote.GetAsync("/search?q=proxy+pattern");
        }
    }
}