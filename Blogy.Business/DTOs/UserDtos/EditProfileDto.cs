﻿using Microsoft.AspNetCore.Http;

namespace Blogy.Business.DTOs.UserDtos
{
    public class EditProfileDto
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string UserName { get; set; }
        public string? Title { get; set; }
        public string? ImageUrl { get; set; }
        public IFormFile? ImageFile { get; set; }
        public string CurrentPassword { get; set; }
        public string Email { get; set; }
        public string? PhoneNumber { get; set; }
    }
}
