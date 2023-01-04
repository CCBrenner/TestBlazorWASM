namespace TestBlazorWASM.Services.Contracts
{
    public interface ICounterService
    {
        public int Count { get; set; }
        public int IncrementAmount { get; set; }
        public void IncrementCount();
    }
}
