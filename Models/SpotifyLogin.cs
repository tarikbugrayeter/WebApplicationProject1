﻿using System;
using System.Collections.Generic;

namespace WebApplicationProject1.Models;

public partial class SpotifyLogin
{
    public int SpotifyId { get; set; }

    public string? Email { get; set; }

    public string? Password { get; set; }
}
