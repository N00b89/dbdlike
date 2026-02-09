using Godot;

public partial class Game : Node3D
{
	public override void _Ready()
	{
	}

	// Called only on the server.
	public void StartGame()
	{
		// All peers are ready to receive RPCs in this scene.
	}
}
