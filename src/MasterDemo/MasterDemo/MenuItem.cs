using System;

namespace MasterDemo
{
    /// <summary>
    /// Represents the <see cref="MenuItem"/> class.
    /// </summary>
    public class MenuItem
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MenuItem"/> class.
        /// </summary>
        public MenuItem()
        {
            // the target type is a type of a detail page.
            TargetType = typeof(DetailPage);
        }

        /// <summary>
        /// Gets or sets the ID.
        /// </summary>
        /// <value>
        /// The ID of the item.
        /// </value>
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the title.
        /// </summary>
        /// <value>
        /// The title of the menu item.
        /// </value>
        public string Title { get; set; }

        /// <summary>
        /// Gets or sets the target type.
        /// </summary>
        /// <value>
        /// The target type of the menu item.
        /// </value>
        public Type TargetType { get; set; }
    }
}