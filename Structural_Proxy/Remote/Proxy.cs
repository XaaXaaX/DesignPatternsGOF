using System;

namespace Structural_Proxy.Remote
{
    public class Proxy : IService
    {
        private readonly string key;
        private readonly Component component;

        public Proxy(string Key)
        {
            this.key = Key;
            this.component = component ?? new Component();
        }

        public void Process()
        {
            component.Process();
        }
    }
}
