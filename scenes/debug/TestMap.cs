using Godot;
using System;
using System.Collections.Generic;

public partial class TestMap : Map
{
		private List<TileSpawner> _tileSpawners = new List<TileSpawner>();
	
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		// Get all tile spawners and add them to list.
		foreach (Node child in GetChildren())
		{
			if (child is TileSpawner spawner)
			{
				_tileSpawners.Add(spawner);
			}
		}
		
		// Spawn each tile.
		foreach (TileSpawner spawner in _tileSpawners)
		{
			spawner.DespawnTile();
			spawner.SpawnTile(TileSpawner.RandomTileName());
		}
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
	}
}
