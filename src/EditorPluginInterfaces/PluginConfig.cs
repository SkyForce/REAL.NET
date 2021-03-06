﻿/* Copyright 2017-2018 REAL.NET group
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 * http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License. */

using System.Collections.Generic;

namespace EditorPluginInterfaces
{
    using Toolbar;

    /// <summary>
    /// Plugins' configuration class
    /// </summary>
    public class PluginConfig
    {
        /// <summary>
        /// Model of the editor, allows to manipulate repository and keep consistence with editor.
        /// </summary>
        public IModel Model { get; }

        /// <summary>
        /// Scene's reference that should be given to plugin
        /// </summary>
        public IScene Scene { get; }

        /// <summary>
        /// Toolbar's reference that should be given to plugin
        /// </summary>
        public IToolbar Toolbar { get; }

        /// <summary>
        /// Console's reference that should be given to plugin
        /// </summary>
        public IConsole Console { get; }

        /// <summary>
        /// Palette's reference that should be given to plugin
        /// </summary>
        public IPalette Palette { get; }

        public Dictionary<string, object> Properties { get; }

        /// <summary>
        /// Initializes a new instance of <see cref="PluginConfig"/> 
        /// </summary>
        /// <param name="model">Model of the editor, allows to manipulate repository and keep consistence 
        /// with editor.</param>
        /// <param name="scene">Scene</param>
        /// <param name="toolbar">Toolbar</param>
        /// <param name="console">Console</param>
        /// <param name="palette">Palette</param>
        public PluginConfig(IModel model, IScene scene, IToolbar toolbar, IConsole console, IPalette palette, Dictionary<string, object> properties)
        {
            this.Model = model;
            this.Scene = scene;
            this.Toolbar = toolbar;
            this.Console = console;
            this.Palette = palette;
            this.Properties = properties;
        }
    }
}
