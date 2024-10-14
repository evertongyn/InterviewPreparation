namespace InterviewPreparation.Domain.Entities
{
    public class Algorithm
    {
        public required string Id { get; set; }
        public required string Name { get; set; }
        public required string Input { get; set; } 
        public string? Output { get; set; }
        public double ExecutionTime { get; set; }
    }
}
