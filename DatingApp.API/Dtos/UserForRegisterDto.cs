using System;
using System.Text.Json.Serialization;
using System.ComponentModel.DataAnnotations;

namespace DatingApp.API.Dtos
{
    public class UserForRegisterDto
    {
        [Required]
        [JsonPropertyName("Username")]
        public string Username { get; set; }

        [Required]
        [StringLength(8, MinimumLength=4, ErrorMessage="Password needs to be between 4 & 8 characters")]
        [JsonPropertyName("Password")]
        public string Password { get; set; }
    }
}