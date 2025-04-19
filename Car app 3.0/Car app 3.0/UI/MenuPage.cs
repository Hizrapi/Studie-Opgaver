using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_app_3._0.UI
{
    /// <summary> En hel side (titel + punkter) der kan pushes på navigation‑stakken. </summary>
    public readonly record struct MenuPage(string Title, IReadOnlyList<MenuItem> Items);
}
