using System;
using System.Collections.Generic;

namespace Psythyst.Core.Data
{
    /// <summary>
    /// ProjectModel Struct.
    /// </summary>
    public struct ProjectModel
    { 
        public ProjectContextModel[] Context { get; }

        public ProjectComponentModel[] Component { get; }

        public ProjectCustomEntityIndexModel[] CustomEntityIndex { get; }

        public ProjectModel (
            ProjectContextModel[] Context, 
            ProjectComponentModel[] Component,
            ProjectCustomEntityIndexModel[] CustomEntityIndex) {

            this.Context = Context;
            this.Component = Component;
            this.CustomEntityIndex = CustomEntityIndex;
        }
    }
}