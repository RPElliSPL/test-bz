using Microsoft.AspNetCore.Components;
using System;

namespace Ellicium.Blazor
{
    /// <summary>
    /// Configures a level of nodes in a <see cref="ElliciumTree" /> during data-binding.
    /// </summary>
    /// <example>
    /// <code>
    /// &lt;ElliciumTree Data=@rootEmployees&gt;
    ///     &lt;ElliciumTreeLevel TextProperty="LastName" ChildrenProperty="Employees1"  HasChildren=@(e =&gt; (e as Employee).Employees1.Any()) /&gt;
    /// &lt;/ElliciumTree&gt;
    /// @code {
    ///  IEnumerable&lt;Employee&gt; rootEmployees; 
    ///  protected override void OnInitialized()
    ///  {
    ///     rootEmployees = NorthwindDbContext.Employees.Where(e => e.ReportsTo == null);
    ///  }
    /// }
    /// </code>
    /// </example>
    public class ElliciumTreeLevel : ComponentBase
    {
        /// <summary>
        /// Specifies the name of the property which provides values for the <see cref="ElliciumTreeItem.Text" /> property of the child items.
        /// </summary>
        [Parameter]
        public string TextProperty { get; set; }

        /// <summary>
        /// Specifies the name of the property which returns child data. The value returned by that property should be IEnumerable
        /// </summary>
        [Parameter]
        public string ChildrenProperty { get; set; }

        /// <summary>
        /// Determines if a child item has children or not. Set to <c>value =&gt; true</c> by default.
        /// </summary>
        /// <example>
        /// <code>
        ///     &lt;ElliciumTreeLevel HasChildren=@(e =&gt; (e as Employee).Employees1.Any()) /&gt;
        /// </code>
        /// </example>
        [Parameter]
        public Func<object, bool> HasChildren { get; set; } = value => true;

        /// <summary>
        /// Determines if a child item is expanded or not. Set to <c>value =&gt; false</c> by default.
        /// </summary>
        /// <example>
        /// <code>
        ///     &lt;ElliciumTreeLevel Expanded=@(e =&gt; (e as Employee).Employees1.Any()) /&gt;
        /// </code>
        /// </example>
        [Parameter]
        public Func<object, bool> Expanded { get; set; } = value => false;

        /// <summary>
        /// Determines if a child item is selected or not. Set to <c>value =&gt; false</c> by default.
        /// </summary>
        /// <example>
        /// <code>
        ///     &lt;ElliciumTreeLevel Selected=@(e =&gt; (e as Employee).LastName == "Fuller") /&gt;
        /// </code>
        /// </example>
        [Parameter]
        public Func<object, bool> Selected { get; set; } = value => false;

        /// <summary>
        /// Determines the text of a child item.
        /// </summary>
        /// <example>
        /// <code>
        ///     &lt;ElliciumTreeLevel Text=@(e =&gt; (e as Employee).LastName) /&gt;
        /// </code>
        /// </example>
        [Parameter]
        public Func<object, string> Text { get; set; }

        /// <summary>
        /// Gets or sets the template.
        /// </summary>
        [Parameter]
        public RenderFragment<ElliciumTreeItem> Template { get; set; }

        /// <summary>
        /// The ElliciumTree which this item is part of.
        /// </summary>
        [CascadingParameter]
        public ElliciumTree Tree
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                value.AddLevel(this);
            }
        }
    }
}