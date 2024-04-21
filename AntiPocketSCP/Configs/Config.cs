
using Exiled.API.Interfaces;
using System.Collections.Generic;

namespace AntiPocketSCP
{
    public sealed class Config : IConfig
    {
        public bool IsEnabled { get; set; } = true;
        public bool Debug { get; set; } = false;

        public List<ItemType> DisallowedSCP { get; set; } = new List<ItemType>() {

            ItemType.SCP1576

        };
    }
}
