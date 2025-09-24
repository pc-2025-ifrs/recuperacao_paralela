// See https://aka.ms/new-console-template for more information
using twitter.model;


var criador = new Criador
{
    Id = Guid.NewGuid(),
    Nome = "Rafaelsantosp"
};
var tweet = new Tweet
{
    Id = Guid.NewGuid(),
    Texto = "Eu me formo esse ano!!!",
    Criador = criador
};

var comentario1 = new twitter.model.Comentarios
{
    Id = Guid.NewGuid(),
    Texto = "OK!!!",
    QuantidadeLikes = 2
};

tweet.Comentarios?.Add(comentario1);





Console.WriteLine(criador.Id+" "+tweet.Criador.Nome);
Console.WriteLine(tweet.Id +" "+tweet.Texto);

foreach (var comentario in tweet.Comentarios!)
{
    Console.WriteLine(comentario);
}
