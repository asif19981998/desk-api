﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desk.Core.Domain.Auth
{
    public class UserManagerResponse
    {
        public string Message { get; set; }
        public IEnumerable<string> Errors { get; set; }
        public bool IsSuccess { get; set; }
        public DateTime? ExpireDate { get; set; }
    }
}
