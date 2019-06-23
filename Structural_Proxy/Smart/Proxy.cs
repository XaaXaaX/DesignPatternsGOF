using System;

namespace Structural_Proxy.Smart
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
            // Here there is some model mapping and hidden treatment 
            component.Process(new object());
        }
    }
}
