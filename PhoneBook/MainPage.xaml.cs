﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace PhoneBook
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        /// <summary>
        /// Constructor
        /// </summary>
        public MainPage()
        {
            this.InitializeComponent();
        }

        protected async override void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);
            DataContext = await Contact.GetContacts();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(AddContact));
        }

        private void Contacts_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void button_Click_1(object sender, RoutedEventArgs e)
        {
            
        }

        private void button_Click_2(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(DeleteContact));
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {

        }

        private void button1_Click_1(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(EditContact));
        }
    }
}
