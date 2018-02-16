using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;

namespace MasterDemo
{
    /// <summary>
    /// Represents the <see cref="MasterPageViewModel"/>.
    /// </summary>
    public class MasterPageViewModel : INotifyPropertyChanged
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MasterPageViewModel"/>.
        /// </summary>
        public MasterPageViewModel()
        {
            // defining the menu items.
            MenuItems = new ObservableCollection<MenuItem>(new[]
            {
                    new MenuItem { Id = 0, Title = "Page 1" },
                    new MenuItem { Id = 1, Title = "Page 2" },
                    new MenuItem { Id = 2, Title = "Page 3" },
                    new MenuItem { Id = 3, Title = "Page 4" },
            });
        }

        /// <summary>
        /// Gets or sets the menu items.
        /// </summary>
        /// <value>
        /// An ObservableCollection of <see cref="MenuItem"/>.
        /// </value>
        public ObservableCollection<MenuItem> MenuItems { get; set; }

        /// <summary>
        /// The event for changed properties.
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Callback method for <see cref="PropertyChanged"/>.
        /// </summary>
        /// <param name="propertyName">The propertyname. Default is an empty string.</param>
        void OnPropertyChanged([CallerMemberName] string propertyName = "")
        {
            if (PropertyChanged == null)
                return;

            PropertyChanged.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}