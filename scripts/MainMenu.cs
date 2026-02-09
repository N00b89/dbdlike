using Godot;
using System;

public partial class MainMenu : CanvasGroup
{
	private Player _player;
	private PackedScene _lobbyScene;
	private Node3D _lobbyInstance;
	
	public void OnPlayKillerPressed()
	{
		if (_player != null)
		{
			_player.Type = Player.CharacterType.Killer;	
		}
	}
	
	public void OnPlaySurvivorPressed()
	{
		if (_player != null)
		{
			_player.Type = Player.CharacterType.Survivor;
		}
	}
	
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		_player = GetParent().GetNodeOrNull<Player>("%Player");
		_lobbyScene = ResourceLoader.Load<PackedScene>("res://scenes/lobby.tscn");
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
	}
}
