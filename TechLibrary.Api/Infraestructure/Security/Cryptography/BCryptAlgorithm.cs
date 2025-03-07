﻿using TechLibrary.Api.Domain.Entities;

namespace TechLibrary.Api.Infrastructure.Security.Cryptography
{
    public class BCryptAlgorithm
    {
        public string HashPassword(string password) => BCrypt.Net.BCrypt.HashPassword(password);

        public bool Verify(string passaword, User user) => BCrypt.Net.BCrypt.Verify(passaword, user.Password);
    }
}
