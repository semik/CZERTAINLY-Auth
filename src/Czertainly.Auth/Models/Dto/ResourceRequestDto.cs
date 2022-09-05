﻿using Czertainly.Auth.Common.Models.Dto;
using System.ComponentModel.DataAnnotations;

namespace Czertainly.Auth.Models.Dto
{
    public record ResourceRequestDto : ICrudRequestDto
    {
        [Required]
        public string? Name { get; init; }
        public string? ListingEndpoint { get; init; }

    }
}
