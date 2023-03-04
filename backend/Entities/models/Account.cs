using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema; 


namespace Entities.models;

    [Table("account")]
    public class Account
    {
        public Guid AccountId { get; set; }

        [Required]
        public DateTime DateCreated { get; set; }

        [Required]
        public string? AccountType { get; set; }

        [ForeignKey(nameof(Owner))]
        public Guid OwnerId { get; set; }
        public Owner? Owner { get; set; }
    }
