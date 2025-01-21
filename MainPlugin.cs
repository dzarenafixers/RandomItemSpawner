using System;
using System.Linq;
using Exiled.API.Features;
using RandomItemSpawner.Handlers;
using static Exiled.CustomItems.API.Features.CustomItem;

namespace RandomItemSpawner
{
    public class MainPlugin : Plugin<Config>
    {
        public override string Name => "RandomItemSpawner";
        public override string Author => "Moncef50G";
        public override string Prefix => "random_item_spawner";
        public override Version RequiredExiledVersion => new Version(9, 4, 0);

        public static MainPlugin Instance;

        public override void OnEnabled()
        {
            Instance = this;
            Exiled.Events.Handlers.Server.RoundStarted += OnRoundStarted;

            Log.Info($"{Name} has been enabled!");
        }

        public override void OnDisabled()
        {
            Exiled.Events.Handlers.Server.RoundStarted -= OnRoundStarted;

            Instance = null;
            Log.Info($"{Name} has been disabled!");
        }

        private void OnRoundStarted()
        {
            ItemSpawner.SpawnCustomItems(Config.SpawnCount);
        }
    }
}