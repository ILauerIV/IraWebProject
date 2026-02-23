using IraWebProject.ViewModels.Interfaces;
using Microsoft.AspNetCore.Components;

using Microsoft.EntityFrameworkCore.Update.Internal;
namespace IraWebProject.ViewModels
{
    public class ColorPickerViewModel : IColorPickerViewModel
    {

        public ColorPickerViewModel()
        { }
        private string _color;
        public string InColor
        { 
            get { return _color; }
            set { _color = value;
               
            }
        }
  
        public async Task UpdateColor(ChangeEventArgs e)
        {
            await Task.Delay(1);
            InColor = e.Value.ToString();
            
        }
    }
}
