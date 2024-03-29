using System.Collections.Generic;
using System.Text;

namespace Ellicium.Blazor.Rendering
{
    /// <summary>
    /// Class StepGenerator.
    /// Implements the <see cref="Ellicium.Blazor.Rendering.IPathGenerator" />
    /// </summary>
    /// <seealso cref="Ellicium.Blazor.Rendering.IPathGenerator" />
    public class StepGenerator : IPathGenerator
    {
        /// <summary>
        /// Pathes the specified data.
        /// </summary>
        /// <param name="data">The data.</param>
        /// <returns>System.String.</returns>
        public string Path(IEnumerable<Point> data)
        {
            var path = new StringBuilder();
            var start = true;

            foreach (var point in data)
            {
                if (start)
                {
                    path.Append($"{point.X.ToInvariantString()} {point.Y.ToInvariantString()}");
                    start = false;
                    continue;
                }

                path.Append($" H {point.X.ToInvariantString()}");
                path.Append($" V {point.Y.ToInvariantString()}");
            }

            return path.ToString();
        }
    }
}
