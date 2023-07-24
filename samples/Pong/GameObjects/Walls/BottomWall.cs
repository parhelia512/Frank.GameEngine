﻿using Frank.GameEngine.Primitives;
using System.Drawing;
using System.Numerics;

namespace Pong.GameObjects;

public class BottomWall : GameObject
{
    public BottomWall()
    {
        Transform.Position = new Vector3(3, 3, 0);
        Shape.Polygon = PolygonFactory.CreateCube(234, 2, 0);
        Shape.Color = Color.White;
    }
}