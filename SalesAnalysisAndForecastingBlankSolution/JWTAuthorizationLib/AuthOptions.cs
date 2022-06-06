using System;
using System.Text;
using Microsoft.IdentityModel.Tokens;

namespace JWTAuthorizationLib
{
    /// <summary>
    /// Authorization options.
    /// </summary>
	public class AuthOptions
	{
        /// <summary>
        /// Token publisher.
        /// </summary>
        public const string ISSUER = "MyAuthServer";

        /// <summary>
        /// Token handler.
        /// </summary>
        public const string AUDIENCE = "MyAuthClient";

        /// <summary>
        /// Encryption key.
        /// </summary>
        const string KEY = "mysupersecret_secretkey!123";

        /// <summary>
        /// Token life time.
        /// This is default time = 1 minute.
        /// </summary>
        public const int LIFETIME = 1;

        /// <summary>
        /// Generate security key.
        /// </summary>
        /// <returns></returns>
        public static SymmetricSecurityKey GetSymmetricSecurityKey()
        {
            return new SymmetricSecurityKey(Encoding.ASCII.GetBytes(KEY));
        }
    }
}
