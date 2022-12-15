using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using crudapi.Entities;

namespace crudapi.Models.Users
{
    public class UpdateRequest
    {
        public string? Title { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }

        [EnumDataType(typeof(Role))]
        public string? Role { get; set; }

        [EmailAddress]
        public string? Email { get; set; }

        private string? _password;
        [MinLength(6)]
        public string? Password
        {
            get => _password;
            set => _password = replaceEmptyWithNull(value);
        }

        private string? _confirmPassword;
        [Compare("Password")]
        public string? ConfirmPassword
        {
            get => _confirmPassword;
            set => _confirmPassword = replaceEmptyWithNull(value);
        }

        private string? replaceEmptyWithNull(string? value)
        {
            return string.IsNullOrEmpty(value) ? null : value;
        }
    }
}