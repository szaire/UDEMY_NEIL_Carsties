using AuctionService.Entities;

namespace AuctionService.DTOs;

// Um DTO (Data Tansfer Object - Objeto de Transferência de Dados) é um padrão
// de software voltado para transferência de dados entre as camadas de uma aplicação
// Consiste no entendimento de como as informações trafegam dentro do sistema.
// Será a base para o retorno do dado retirado do banco de dados

public class AuctionDto
{
    // Auction
    public Guid Id { get; set; }
    public int ReservePrice { get; set; }
    public string Seller { get; set; }
    public string Winner { get; set; }
    public int SoldAmount { get; set; }
    public int CurrentHighBid { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }
    public DateTime AuctionEnd { get; set; }
    public Status Status { get; set; }
    
    // Item
    public string Make { get; set; }
    public string Model { get; set; }
    public int Year { get; set; }
    public string Color { get; set; }
    public int Mileage { get; set; }
    public string ImageUrl { get; set; }
}