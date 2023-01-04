using TestBlazorWASM.Services.Contracts;

namespace TestBlazorWASM.Services
{
    public class CounterService : ICounterService
    {
        public int Count { get; set; } = 0;
        public int IncrementAmount { get; set; } = 1;
        public void IncrementCount() => Count += IncrementAmount;
    }
}
