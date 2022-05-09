using Microsoft.AspNetCore.Identity;

namespace LoginFuzzy.Model
{
    public class MyErrorDescriber : IdentityErrorDescriber
    {
        public override IdentityError PasswordRequiresUpper()
        {
            return new IdentityError()
            {
                Code = nameof(PasswordRequiresUpper),
                Description = "La contraseña debe contener al menos una mayúscula ('A'-'Z')."
            };
        }
        public override IdentityError PasswordRequiresLower()
        {
            return new IdentityError()
            {
                Code = nameof(PasswordRequiresLower),
                Description = "La contraseña debe contener al menos una minúscula ('a'-'z')."
            };
        }
        public override IdentityError PasswordRequiresNonAlphanumeric()
        {
            return new IdentityError()
            {
                Code = nameof(PasswordRequiresNonAlphanumeric),
                Description = "La contraseña debe contener al menos un caracter no alfanumérico."
            };
        }
        public override IdentityError PasswordTooShort(int length)
        {
            return new IdentityError()
            {
                Code = nameof(PasswordTooShort),
                Description = "La contraseña debe contener un mínimo de "+length.ToString()+" caracteres."
            };
        }
        public override IdentityError DuplicateUserName(string userName)
        {
            return new IdentityError()
            {
                Code = nameof(DuplicateUserName),
                Description = "El usuario " + userName + ", ya existe."
            };
        }
        public override IdentityError DuplicateEmail(string email)
        {
            return new IdentityError()
            {
                Code = nameof(DuplicateEmail),
                Description = "El email " + email + ", ya existe."
            };
        }
    }
}
