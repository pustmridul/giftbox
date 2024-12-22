using System.ComponentModel.DataAnnotations;

namespace giftbox.Data
{
    public class Employee
    {
        [Key]
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? OwnGiftNo { get; set; }
        public bool IsGifted { get; set; }
        public bool IsReceived { get; set; }

        public string? ReceiveGiftNo { get; set; }
    }
}
