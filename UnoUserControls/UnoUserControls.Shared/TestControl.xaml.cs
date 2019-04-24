using System;
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

// The User Control item template is documented at https://go.microsoft.com/fwlink/?LinkId=234236

namespace UnoUserControls.Shared
{
    public sealed partial class TestControl : UserControl
    {
        public TestControl()
        {
            this.InitializeComponent();
        }

        private void uncheckButton_Click(object sender, RoutedEventArgs e)
        {
            VisualStateManager.GoToState(this, "Unchecked", true);
        }

        private void checkButton_Click(object sender, RoutedEventArgs e)
        {
            VisualStateManager.GoToState(this, "Checked", true);

        }

    }
}
