﻿using Czertainly.Auth.Common.Models.Dto;
using System.ComponentModel.DataAnnotations;

namespace Czertainly.Auth.Models.Dto
{
    public record UserUpdateRequestDto : ICrudRequestDto
    {
        public string? FirstName { get; init; }
        
        public string? LastName { get; init; }

        public bool Enabled { get; init; }
        
        [Required]
        [EmailAddress]
        public string? Email { get; init; }

        public Guid? CertificateUuid { get; init; }
        public string? CertificateFingerprint { get; init; }
    }
}
