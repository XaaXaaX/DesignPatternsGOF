using System;

namespace Structural_Proxy.Virtual
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

        public bool IsValid
        {
            get
            {
                return !string.IsNullOrWhiteSpace(this.key);
            }
        }

        public void Process()
        {
            if (!this.IsValid)
            {
                throw new UnauthorizedAccessException();
            }
            component.Process();
        }
    }
}
