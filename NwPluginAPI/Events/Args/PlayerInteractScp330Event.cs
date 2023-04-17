using LiteNetLib;
using UnityEngine;

using AdminToys;
using PlayerRoles;
using Footprinting;
using CustomPlayerEffects;
using MapGeneration.Distributors;

using Interactables.Interobjects;
using Interactables.Interobjects.DoorUtils;

using CommandSystem;
using PlayerStatsSystem;

using InventorySystem.Items;
using InventorySystem.Items.Radio;
using InventorySystem.Items.Pickups;
using InventorySystem.Items.Usables;
using InventorySystem.Items.Firearms;
using InventorySystem.Items.ThrowableProjectiles;

using PluginAPI.Core;
using PluginAPI.Enums;
using PluginAPI.Core.Attributes;

using static BanHandler;
using static MapGeneration.Distributors.Scp079Generator;

namespace PluginAPI.Events
{
	public class PlayerInteractScp330Event : IEventArguments
	{
		public ServerEventType BaseType { get; } = ServerEventType.PlayerInteractScp330;
		[EventArgument]
		public Player Player { get; }
		[EventArgument]
		public int MaxCandiesPerLife { get; set; }
		[EventArgument]
		public bool PlaySound { get; set; }

		public PlayerInteractScp330Event(ReferenceHub hub, int maxCandiesPerLife, bool playSound)
		{
			Player = Player.Get(hub);
			MaxCandiesPerLife = maxCandiesPerLife;
			PlaySound = playSound;
		}

		PlayerInteractScp330Event() { }
	}
}
