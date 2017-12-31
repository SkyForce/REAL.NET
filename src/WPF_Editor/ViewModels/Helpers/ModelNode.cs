﻿/* Copyright 2017
 * Yurii Litvinov
 * Ivan Yarkov
 * Egor Zainullin
 * Denis Sushentsev
 * Arseniy Zavalishin
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License. */

using GraphX.PCL.Common.Enums;
using GraphX.PCL.Common.Interfaces;
using Repo;

namespace WPF_Editor.ViewModels.Helpers
{
    public class ModelNode : ModelElement, INode, IGraphXVertex
    {
        private INode _node;

        public ModelNode(INode node) : base(node)
        {
            this._node = node;
        }

        #region IGraphXVertex implementation

        public bool Equals(IGraphXVertex other)
        {
            if (other is null)
                return false;
            return this.ID == other.ID;
        }

        public long ID { get; set; }
        public ProcessingOptionEnum SkipProcessing { get; set; }
        public double Angle { get; set; }
        public int GroupId { get; set; }

        #endregion
    }
}