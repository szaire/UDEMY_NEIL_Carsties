namespace AuctionService.DTOs;

// Essa classe irá representar a requisição que atualiza os leilões que o usuário criou

public class UpdateAuctionDto
{
    public string Make { get; set; }
    public string Model { get; set; }
    public int Year { get; set; }
    public string Color { get; set; }
    public int Mileage { get; set; }
}