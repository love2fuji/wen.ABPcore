using System.ComponentModel.DataAnnotations;

namespace wen.ABPcore.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}