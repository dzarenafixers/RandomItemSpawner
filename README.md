# Custom Item Spawner for SCP:SL (14.0.2)
This plugin allows you to spawn custom items at specified locations within the SCP: Secret Laboratory game (version 14.0.2). The items are defined in a configuration file (JSON format) that contains item IDs, names, and their spawn positions. You can specify custom items and randomize their spawn across different locations in the game.

# Features:
Custom Item Support: Spawn custom items using the SCP:SL Exiled API.
Configurable Spawn Locations: Easily define multiple spawn positions for the custom items using a JSON file.
Randomized Spawning: Randomly spawn items based on the configuration file's data.
Automatic Item Spawning: Automatically load the item configurations and spawn the items on the server start.
Configuration (config.json):
Define the ID, name, and spawn position (x, y, z) for each custom item.
Modify the spawn positions as needed to add more custom locations or fine-tune existing ones.
# Example config.json:

{
    "items": [
        { "id": 1, "name": "SCP-500", "spawnPosition": [10.0, 0.0, 10.0] },
        { "id": 2, "name": "SCP-173", "spawnPosition": [20.0, 0.0, 20.0] },
        { "id": 3, "name": "SCP-049", "spawnPosition": [30.0, 0.0, 30.0] }
    ]
}
# How It Works:
Configuration File: Customize the items and their spawn locations by modifying the config.json file.
Item Spawning: On the server start or when triggered, the plugin will read the configuration file, and spawn the specified items at the defined positions.
Randomization: The plugin supports randomizing the items and their spawn locations for more dynamic gameplay.
Requirements:
SCP: Secret Laboratory server with Exiled API support (version 14.0.2).
Newtonsoft.Json (for JSON deserialization).
Installation:
Download the plugin.
Place it into your SCP:SL server's plugins folder.
Modify the config.json file to suit your needs.
Restart the server.
# devloper
MONCEF50G 
https://discord.gg/F9GCpMXMpQ
