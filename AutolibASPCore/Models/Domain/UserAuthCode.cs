using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutolibASPCore.Models.Domain
{
    public enum UserAuthCode
    {
        SUCCESS,
        USER_NOT_EXISTS,
        WRONG_PASSWORD,
        USER_ALREADY_EXISTS,
        BAD_EMAIL_FORMAT,
        BAD_PASSWORD_FORMAT,
        NO_FIRSTNAME,
        NO_LASTNAME,
        NO_BIRTHDATE
    }
}
