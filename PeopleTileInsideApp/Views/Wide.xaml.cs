using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI;
using Windows.UI.Core;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Media.Imaging;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace PeopleTileInsideApp.Views
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Wide : Page
    {
        public Wide()
        {
            this.InitializeComponent();
            SystemNavigationManager.GetForCurrentView().AppViewBackButtonVisibility = AppViewBackButtonVisibility.Visible;
            SystemNavigationManager.GetForCurrentView().BackRequested += (s, e) => Frame.Navigate(typeof(MainPage));
            //Main Method
            WideTile();
        }

        public void WideTile()
        {
            Ellipse00Backgrund.ImageSource = new BitmapImage(new Uri(this.BaseUri, @"../Assets/People/Image01.jpg"));
            Ellipse10Backgrund.ImageSource = new BitmapImage(new Uri(this.BaseUri, @"../Assets/People/Image02.jpg"));
            Ellipse31Backgrund.ImageSource = new BitmapImage(new Uri(this.BaseUri, @"../Assets/People/Image03.jpg"));
            Ellipse01Backgrund.ImageSource = new BitmapImage(new Uri(this.BaseUri, @"../Assets/People/Image04.jpg"));
            Ellipse21Backgrund.ImageSource = new BitmapImage(new Uri(this.BaseUri, @"../Assets/People/Image01.jpg"));
            Ellipse31Backgrund.ImageSource = new BitmapImage(new Uri(this.BaseUri, @"../Assets/People/Image02.jpg"));
            Ellipse41Backgrund.ImageSource = new BitmapImage(new Uri(this.BaseUri, @"../Assets/People/Image03.jpg"));
            Ellipse02Backgrund.ImageSource = new BitmapImage(new Uri(this.BaseUri, @"../Assets/People/Image04.jpg"));
            Ellipse12Backgrund.ImageSource = new BitmapImage(new Uri(this.BaseUri, @"../Assets/People/Image01.jpg"));
            Ellipse22Backgrund.ImageSource = new BitmapImage(new Uri(this.BaseUri, @"../Assets/People/Image02.jpg"));
            Ellipse32Backgrund.ImageSource = new BitmapImage(new Uri(this.BaseUri, @"../Assets/People/Image03.jpg"));
        }

        private void HyperlinkButton_Click(object sender, RoutedEventArgs e)
        {
            txtFeelFree.Text = "You clicked in the tile";
        }

        //private void grdWideTile_PointerMoved(object sender, PointerRoutedEventArgs e)
        //{
        //    grdWideTile.BorderThickness = new Thickness(2);
        //    grdWideTile.BorderBrush = new SolidColorBrush(Colors.White);
        //    grdWideTile.BorderBrush.Opacity = 0.5;
        //}

        //private void grdWideTile_PointerExited(object sender, PointerRoutedEventArgs e)
        //{
        //    grdWideTile.BorderThickness = new Thickness(0);
        //}
    }
}
