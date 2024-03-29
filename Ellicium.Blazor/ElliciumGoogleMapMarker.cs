﻿using Microsoft.AspNetCore.Components;

namespace Ellicium.Blazor
{
    /// <summary>
    /// ElliciumGoogleMapMarker component.
    /// </summary>
    public class ElliciumGoogleMapMarker : ElliciumComponent
    {
        /// <summary>
        /// Gets or sets the position.
        /// </summary>
        /// <value>The position.</value>
        [Parameter]
        public GoogleMapPosition Position { get; set; } = new GoogleMapPosition() { Lat = 0, Lng = 0 };

        /// <summary>
        /// Gets or sets the title.
        /// </summary>
        /// <value>The title.</value>
        [Parameter]
        public string Title { get; set; }

        /// <summary>
        /// Gets or sets the label.
        /// </summary>
        /// <value>The label.</value>
        [Parameter]
        public string Label { get; set; }

        ElliciumGoogleMap _map;

        /// <summary>
        /// Gets or sets the map.
        /// </summary>
        /// <value>The map.</value>
        [CascadingParameter]
        public ElliciumGoogleMap Map
        {
            get
            {
                return _map;
            }
            set
            {
                if (_map != value)
                {
                    _map = value;
                    _map.AddMarker(this);
                }
            }
        }

        /// <summary>
        /// Disposes this instance.
        /// </summary>
        public override void Dispose()
        {
            base.Dispose();
            Map?.RemoveMarker(this);
        }
    }
}