using Exiled.API.Features;
using AntiPocketSCP.Handlers;
using System;

namespace AntiPocketSCP
{
    public sealed class AntiSCP1576 : Plugin<Config>
    {
        public override string Author => "dyrklord";

        public override string Name => "AntiPocketSCP";

        public override string Prefix => "AntiPocketSCP";

        public override Version Version => new Version(1, 0, 0);

        private MapGenHandlers _mapGenHandlers;

        public override void OnDisabled()
        {
            Exiled.Events.Handlers.Map.FillingLocker -= _mapGenHandlers.onScpItemSpawn;
            _mapGenHandlers = null;
            base.OnDisabled();
        }
        public override void OnEnabled()
        {
            _mapGenHandlers = new MapGenHandlers(Config.DisallowedSCP);
            Exiled.Events.Handlers.Map.FillingLocker += _mapGenHandlers.onScpItemSpawn;
            base.OnEnabled();
        }
    }
}