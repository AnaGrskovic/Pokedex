﻿namespace Library.AnaGrskovic.Contracts.Models.Security
{
    public class JWTSettings
    {
        public string Key { get; set; } = default!;
        public string Issuer { get; set; } = default!;
        public string Audience { get; set; } = default!;
        public short ValidHours { get; set; } = default!;
    }
}
