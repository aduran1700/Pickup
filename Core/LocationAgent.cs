using System;

namespace Core
{
    public class LocationAgent
    {
        public string Id { get; private set; } = Guid.NewGuid().ToString();
        public Location Location { get; private set; }

        public void BroadcastLocation() =>
            Location = new Location(99, 99);
    }
}