﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Microsoft.Marketplace.SaaS.SDK.Library.Models
{
    public class CredentialsModel
    {
        [JsonProperty("Tenant ID")]
        public string TenantID { get; set; }
        [JsonProperty("Subscription ID")]
        public string SubscriptionID { get; set; }
        [JsonProperty("Service Principal ID")]
        public string ServicePrincipalID { get; set; }
        [JsonProperty("Client Secret")]
        public string ClientSecret { get; set; }

    }
}
