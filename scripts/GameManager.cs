using Godot;
using System;

public partial class GameManager : Node {
	public override void _Process(double delta) {
		if (Input.IsActionPressed("quit")) {
			GetTree().Quit();
		}
	}
}
