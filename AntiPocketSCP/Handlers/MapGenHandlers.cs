
using Exiled.Events.EventArgs.Map;
using System.Collections.Generic;

namespace AntiPocketSCP.Handlers
{
    internal class MapGenHandlers
    {
        public MapGenHandlers(List<ItemType> DisallowedSCP)
        {
            _disallowedSCP = DisallowedSCP;
        }

        private List<ItemType> _disallowedSCP;
        public void onScpItemSpawn(FillingLockerEventArgs ev)
        {
            if (_disallowedSCP.Contains(ev.Pickup.Type))
            {
                ev.IsAllowed = false;
            }
        }
    }
}
