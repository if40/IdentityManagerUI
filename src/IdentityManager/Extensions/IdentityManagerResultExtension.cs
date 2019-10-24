using System;
using System.Linq;
using IdentityManager.Api.Models;
using IdentityManager.Core;

namespace IdentityManager.Extensions
{
    public static class IdentityManagerResultExtensions
    {
        public static ErrorModel ToError(this IdentityManagerResult result)
        {
            if (result == null) throw new ArgumentNullException(nameof(result));

            return new ErrorModel
            {
                Errors = result.Errors.ToArray()
            };
        }
    }
}
