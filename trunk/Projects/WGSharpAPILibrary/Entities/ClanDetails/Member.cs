﻿/*
The MIT License (MIT)

Copyright (c) 2014 Iulian Grosu

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in
all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
THE SOFTWARE.
 */
using System;
using Newtonsoft.Json;

namespace WGSharpAPI.Entities.ClanDetails
{
    [JsonArray("members")]
    public class Member
    {
        /// <summary>
        /// Clan member account id. Equivalent to a player's account id.
        /// </summary>
        [JsonProperty("account_id")]
        public long Id { get; set; }

        [JsonProperty("account_name")]
        public string Name { get; set; }

        [JsonProperty("created_at")]
        public long DateJoined { get; set; }

        [JsonProperty("role")]
        public string Role { get; set; }

        [JsonProperty("role_i18n")]
        public string LocalizedRole { get; set; }

        [Obsolete("Warning. The field will be disabled.")]
        [JsonProperty("updated_at")]
        public long DateDetailsUpdated { get; set; }
    }
}
