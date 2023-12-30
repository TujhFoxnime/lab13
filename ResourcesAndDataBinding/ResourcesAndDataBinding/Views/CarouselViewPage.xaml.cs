using ResourcesAndDataBinding.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ResourcesAndDataBinding.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CarouselViewPage : ContentPage
    {
        private JournalViewModel Journals { get; set; }
        public CarouselViewPage()
        {
            InitializeComponent();
            Journals = new JournalViewModel();
            BindingContext = Journals;
        }

        private void JournalList_CurrentItemChanged(object sender, CurrentItemChangedEventArgs e)
        {

            var currentItem = e.CurrentItem;
            var previousItem = e.PreviousItem;
        }

        private void JournalList_PositionChanged(object sender, PositionChangedEventArgs e)
        {
            int currentPosition = e.CurrentPosition;
            int previousPosition = e.PreviousPosition;
        }
    }
}