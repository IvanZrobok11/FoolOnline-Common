using System.Runtime.Serialization;
using Domain.DTO;

namespace Common.DTO
{
    public class FoolRoomDTO
    {
        [DataMember(Order = 0, IsRequired = false)] public IEnumerable<PlayerDTO> PlayersInRoom { get; set; }
        [DataMember(Order = 1, IsRequired = true)] public bool GameIsProcess { get; set; }
        [DataMember(Order = 2, IsRequired = false)] public FoolSessionDTO Session { get; set; }
    }
}
