using System;
using System.Collections.Generic;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
namespace Ejercicio05
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class EditorCode : ContentPage
    {
        public EditorCode()
        {
            InitializeComponent();
            StackLayout stack = new StackLayout();
            var MyEditor = new Editor { Text = "I am an Editor" };
            stack.Children.Add(MyEditor);
            Content = stack;
        }
    }
}
