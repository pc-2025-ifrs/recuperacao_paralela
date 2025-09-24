namespace twitter.model
{
    public record  class Criador
    {
        public required string Nome { get; set; }
        public required Guid Id { get; set; }
    }
}