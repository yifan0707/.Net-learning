using System;
using System.Diagnostics;
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

namespace PrimitiveDataType
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private void TypeSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ListBoxItem target = (typeList.SelectedItem as ListBoxItem);
            String content = target.Content.ToString();
            Debug.WriteLine(content);
            switch (content)
            {
                case "Integer":
                    ShowIntegerValue();
                    break;
                case "Long":
                    ShowLongValue();
                    break;
                case "Float":
                    ShowFloatValue();
                    break;
                case "Double":
                    ShowDoubleValue();
                    break;
                case "Decimal":
                    ShowDecimalValue();
                    break;
                case "String":
                    ShowStringValue();
                    break;
                case "Char":
                    ShowCharValue();
                    break;
                case "Boolean":
                    ShowBooleanValue();
                    break;
                default:
                    ShowDefaultValue();
                    break;
            }
        }

        private void ShowDefaultValue()
        {
            String temp = "To Do";
            resultTextBlock.Text = temp.ToString();
        }

        private void ShowIntegerValue() {
            int temp = 77;
            Debug.WriteLine("text!");
            resultTextBlock.Text = temp.ToString();
        }

        private void ShowLongValue()
        {
            long temp = 77l;
            resultTextBlock.Text = temp.ToString();
        }
        private void ShowFloatValue()
        {
            float temp = 7.7f;
            resultTextBlock.Text = temp.ToString();
        }
        private void ShowDoubleValue()
        {
            double temp = 7.7d;
            resultTextBlock.Text = temp.ToString();
        }
        private void ShowDecimalValue()
        {
            decimal temp = 77m;
            resultTextBlock.Text = temp.ToString();
        }
        private void ShowStringValue()
        {
            String temp = "String 77";
            resultTextBlock.Text = temp.ToString();
        }
        private void ShowCharValue()
        {
            Char temp = '7';
            resultTextBlock.Text = temp.ToString();
        }
        private void ShowBooleanValue()
        {
            bool temp = true;
            resultTextBlock.Text = temp.ToString();
        }

    }
}
