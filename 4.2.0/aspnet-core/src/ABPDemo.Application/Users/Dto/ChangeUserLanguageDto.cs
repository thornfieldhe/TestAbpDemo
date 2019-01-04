using System.ComponentModel.DataAnnotations;

namespace ABPDemo.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}