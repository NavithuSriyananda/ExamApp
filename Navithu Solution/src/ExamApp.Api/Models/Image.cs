using System;
using System.ComponentModel.DataAnnotations;
using static ExamApp.Api.Constants.Constants;

namespace ExamApp.Api.Models
{
    public class Image
    {
        [Key]
        [Required]
        public int Id { get; set; }
        [Required]
        public DateTime createdAt { get; set; }
        [Required]
        public String base64String { get; set; }
        [Required]
        public EffectTypes effectType { get; set; }
        [Required]
        public int radius { get; set; }
        [Required]
        public int[] size { get; set; }

        public Image(int id, DateTime createdAt, string base64String, EffectTypes effectType, int radius, int[] size)
        {
            Id = id;
            this.createdAt = createdAt;
            this.base64String = base64String;
            this.effectType = effectType;
            this.radius = radius;
            this.size = size;
        }

        public override string ToString()
        {
            return $"\nImage Id:{Id}\nCreated At:{createdAt.ToString()}\nBase64:{base64String}\nEffect:{effectType}\nRadius:{radius}px\nSize:{size[0]}px {size[1]}px\n";
        }


    }
}
