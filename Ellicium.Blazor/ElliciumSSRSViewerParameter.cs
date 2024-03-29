using Microsoft.AspNetCore.Components;
using System.Collections.Generic;
using System.Linq;

namespace Ellicium.Blazor
{
    /// <summary>
    /// ElliciumSSRSViewerParameter component.
    /// </summary>
    public class ElliciumSSRSViewerParameter : ComponentBase
    {
        string _parameterName;

        /// <summary>
        /// Gets or sets the name of the parameter.
        /// </summary>
        /// <value>The name of the parameter.</value>
        [Parameter]
        public string ParameterName
        {
            get
            {
                return _parameterName;
            }
            set
            {
                if (_parameterName != value)
                {
                    _parameterName = value;
                    if (Viewer != null)
                    {
                        Viewer.Reload();
                    }
                }
            }
        }

        string _value;

        /// <summary>
        /// Gets or sets the value.
        /// </summary>
        /// <value>The value.</value>
        [Parameter]
        public string Value
        {
            get
            {
                return _value;
            }
            set
            {
                if (_value != value)
                {
                    _value = value;
                    if (Viewer != null)
                    {
                        Viewer.Reload();
                    }
                }
            }
        }

        ElliciumSSRSViewer _viewer;

        /// <summary>
        /// Gets or sets the viewer.
        /// </summary>
        /// <value>The viewer.</value>
        [CascadingParameter]
        public ElliciumSSRSViewer Viewer
        {
            get
            {
                return _viewer;
            }
            set
            {
                if (_viewer != value)
                {
                    _viewer = value;
                    _viewer.AddParameter(this);
                }
            }
        }
    }
}