using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Entities
{
    public class BaseEntity
    {
        [JsonIgnore]
        public int Id { get; set; }
    }
}
