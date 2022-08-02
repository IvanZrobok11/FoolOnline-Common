using Common.Enums;
using System.Runtime.Serialization;

namespace Common.DTO
{
    public class CardDTO
    {
        [DataMember(Order = 0, IsRequired = true)]
        public TypeCard Type { get; }
        [DataMember(Order = 1, IsRequired = true)]
        public SuitCard Suit { get; }

        public CardDTO()
        {
            
        }

        public CardDTO(TypeCard type, SuitCard suite)
        {
            Type = type;
            Suit = suite;
        }
    }
}
