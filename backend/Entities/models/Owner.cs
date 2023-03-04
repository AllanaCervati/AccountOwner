using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema; 


namespace Entities.models;

[Table("owner")]
public class Owner
    {
        [Key]
        public Guid OwnerId{ get; set;}

        [Required]
        [StringLength(60)]
        public string? Name {get; set; }

        public DateTime DateOfBirth { get; set; }

        [Required]
        [StringLength(100)]

        public string? Address { get; set; }

        public ICollection<Account> ?accounts { get; set; }
    }
