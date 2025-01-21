using Exiled.API.Interfaces;

namespace RandomItemSpawner
{
    public class Config : IConfig
    {
        public bool IsEnabled { get; set; } = true;
        public bool Debug { get; set; }

        public int SpawnCount { get; set; } = 50; // عدد العناصر المطلوب نشرها
    }
}