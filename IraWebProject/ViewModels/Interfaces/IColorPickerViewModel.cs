using Microsoft.AspNetCore.Components;
using System.Security.Claims;

namespace IraWebProject.ViewModels.Interfaces
{
    public interface IColorPickerViewModel
    {
         string InColor { get; set; }
        Task UpdateColor(ChangeEventArgs e);
        Task<bool> SaveColor(ClaimsPrincipal p);
        Task<bool> SetCurrentUserColor(ClaimsPrincipal p);

    }
}
