﻿using System;
using WPF_Editor.Models.Interfaces;
using WPF_Editor.Models;
using System.Windows.Input;
using System.Windows;

namespace REAL.NET.Models
{
    class Scene : IScene
    {
        public ISceneMediator Scene_mediator { get; }

        private static IScene scene;

        public static IScene CreateScene(ISceneMediator scene_mediator)
        {
            if (scene is null)
                scene = new Scene(scene_mediator);
            return scene;
        }

        public void HandleClick(object sender, MouseButtonEventArgs e)
        {
            Point p = Mouse.GetPosition(null);
            System.Console.WriteLine("X={0} Y={1}", p.X, p.Y);
        }

        private Scene(ISceneMediator sceneMediator)
        {

        }

    }
}
