﻿using System;
using System.Collections.Generic;

namespace WebApplicationProject1.Models;

public partial class NetflixLogin
{
    public int NetflixId { get; set; }

    public string? Email { get; set; }

    public string? Password { get; set; }
}
