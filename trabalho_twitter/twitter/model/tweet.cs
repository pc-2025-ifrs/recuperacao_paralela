namespace twitter.model
{
    public record class Tweet
    {
        public required string Texto { get; set; }
        public required Guid Id { get; set; }
        public required Criador Criador { get; set; }

        public List<Comentarios> Comentarios { get; } = new List<Comentarios>();

        public void Comentar(string texto = "")
            {
                this.Comentarios.Add(new Comentarios
                {
                    Id = Guid.NewGuid(),
                    Texto = texto
                });
            }
    }
} 
