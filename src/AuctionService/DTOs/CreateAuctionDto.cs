using System.ComponentModel.DataAnnotations;

namespace AuctionService.DTOs;

// Essa classe é usada para representar a requisição do usuário para criação de um produto no leilão

public class CreateAuctionDto
{
    // Todas as propriedades são necessárias para o cadastro feito pelo usuário
    [Required] public string Make { get; set; }
    [Required] public string Model { get; set; }
    [Required] public int Year { get; set; }
    [Required] public string Color { get; set; }
    [Required] public int Mileage { get; set; }
    [Required] public string ImageUrl { get; set; }
    [Required] public int ReservePrice { get; set; }
    [Required] public DateTime AuctionEnd { get; set; }
}