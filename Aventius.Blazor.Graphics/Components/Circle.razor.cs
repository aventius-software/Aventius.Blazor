﻿#region Namespaces

using Aventius.Blazor.Graphics.Shared;
using Microsoft.AspNetCore.Components;

#endregion

namespace Aventius.Blazor.Graphics.Components
{
    public class CircleBase : ShapeComponentBase
    {
        #region Parameters

        [Parameter]
        public int Radius { get; set; }

        [Parameter]
        public int X { get; set; }

        [Parameter]
        public int Y { get; set; }

        #endregion

        #region Override Methods

        protected override void UpdateStyle()
        {
            InternalStyle = $"stroke:{OutlineColour};stroke-width:{OutlineThickness};fill:{Colour};" + Style;
        }

        #endregion
    }
}
