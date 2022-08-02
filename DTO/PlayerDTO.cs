using System.Runtime.Serialization;

namespace Common.DTO
{
    public class PlayerDTO
    {
        [DataMember(Order = 0, IsRequired = true)]
        public string Id { get; set; }
        [DataMember(Order = 1, IsRequired = false)]
        public string Name { get; set; }
    }
}
