using Microsoft.AspNetCore.Components;

namespace IraWebProject.ViewModels.Interfaces
{
    public interface IColorPickerViewModel
    {
         string InColor { get; set; }
        Task UpdateColor(ChangeEventArgs e);
    }
}
