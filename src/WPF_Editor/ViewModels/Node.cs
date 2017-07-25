﻿using System.Collections.Generic;
using GraphX.PCL.Common.Enums;
using GraphX.PCL.Common.Interfaces;
using GraphX.PCL.Common.Models;
using Repo;

namespace WPF_Editor.ViewModels
{
    public sealed class Node : Element, INode, IGraphXVertex
    {

        public Node(INode inode) : base(inode) { }
        #region IGraphXVertex implementation
        public bool Equals(IGraphXVertex other)
        {
            if (other is null)
            {
                return false;
            }
            return ID == other.ID;
        }
        public long ID { get; set; }
        public ProcessingOptionEnum SkipProcessing { get; set; }
        public double Angle { get; set; }
        public int GroupId { get; set; }
        #endregion

    }
}