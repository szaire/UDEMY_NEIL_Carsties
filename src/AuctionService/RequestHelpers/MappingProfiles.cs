using AuctionService.DTOs;
using AuctionService.Entities;
using AutoMapper;

namespace AuctionService.RequestHelpers;

public class MappingProfiles : Profile
{
    // Esse mapa é criado para retornar objetos de maneira adequada de acordo com seu tipo no banco de dados
    public MappingProfiles()
    {
        // Aqui iremos mapear a entidade Auction do banco de dados para o objeto AuctionDTO. Aqui estamos incluindo
        // a entidade item
        CreateMap<Auction, AuctionDto>().IncludeMembers(x => x.Item);
        // Aqui estamos incluindo o restante da entidade ao objeto AuctionDTO
        CreateMap<Item, AuctionDto>().IncludeMembers();
        CreateMap  <CreateAuctionDto, Auction>().IncludeMembers()
            .ForMember(d => d.Item, o => o.MapFrom(s => s));
        CreateMap<CreateAuctionDto, Item>();
    }
}