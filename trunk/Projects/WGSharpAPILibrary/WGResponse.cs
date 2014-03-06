﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WGSharpAPI.Interfaces;
using WGSharpAPI.Entities;
using Newtonsoft.Json;

namespace WGSharpAPI
{
    public class WGResponse<T> : IWGResponse<T> where T : class, new()
    {
        public string Status { get; set; }

        public int Count { get; set; }

        public T Data { get; set; }
    }
}
