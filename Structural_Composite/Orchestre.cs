using System.Collections.Generic;
using System.Threading.Tasks;

namespace Structural_Composite
{
    public class Orchestre: IInstrument
    {
        private readonly IEnumerable<IInstrument> Instruments;

        public Orchestre(IEnumerable<IInstrument> instruments)
        {
            this.Instruments = instruments;
        }

        public void Play()
        {
            Parallel.ForEach(this.Instruments, instrument => instrument.Play());
        }
    }
}
