﻿using Frank.GameEngine.Primitives;
using System.Drawing;

namespace Frank.GameEngine.Assets.Testing.Scenes;

public class BasicTestScene : Scene
{
    public BasicTestScene() : base("Test Scene", new Camera())
    {
        var shape = ShapeFactory.CreateCube(Color.Chartreuse, 5f);
        var transform = TransformFactory.CreateTransform();
        var gameObject = GameObjectFactory.CreateGameObject(transform, shape, "Test Object");
        GameObjects.Add(gameObject);
    }
}