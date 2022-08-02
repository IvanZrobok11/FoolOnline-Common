using System.Runtime.Serialization;
using Common.DTO;
using Common.Enums;

namespace Domain.DTO
{
    public class FoolSessionDTO
    {
        [DataMember(Order = 0, IsRequired = false)] public Dictionary<CardDTO, CardDTO> CardsOnTable { get; set; }
        [DataMember(Order = 1, IsRequired = true)] public int CountCardsInDeck { get; set; }
        [DataMember(Order = 2, IsRequired = true)] public SuitCard? Trump { get; set; }
        [DataMember(Order = 3, IsRequired = true)] public IEnumerable<string> MoversId { get; set; }
        [DataMember(Order = 4, IsRequired = true)] public string BeaterId { get; set; }
        [DataMember(Order = 5, IsRequired = false)] public IEnumerable<string> ConfirmedIfCardsIsBeatenIds { get; set; }
    }
}
