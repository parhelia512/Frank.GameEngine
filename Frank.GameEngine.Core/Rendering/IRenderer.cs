﻿using Frank.GameEngine.Core.GameObjects;
using Microsoft.Xna.Framework.Graphics;

namespace Frank.GameEngine.Core.Rendering;

public interface IRenderer
{
	void Dispose();
	void Render(IGameObject gameObject);
	Texture2D GetTexture(Enum seed, int width, int height, int variation = 25);
}