using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Diagnostics;
using System.Windows;

namespace Ribbon_MVVM
{
    public partial class MainWindowViewModel : ObservableObject
    {
        [ObservableProperty]
        private string inputText = "";

        [RelayCommand]
        private async Task SomeTaskAsync()
        {
            await Task.Delay(500);
            Debug.WriteLine(InputText);
            MessageBox.Show(InputText);
        }
    }
}
