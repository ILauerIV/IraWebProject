using IraWebProject.Data;
using IraWebProject.ViewModels.Interfaces;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Update.Internal;
using System.Security.Claims;
namespace IraWebProject.ViewModels
{
    public class ColorPickerViewModel : IColorPickerViewModel
    {
        private readonly IServiceScopeFactory _scopeFactory;
        public ColorPickerViewModel(IServiceScopeFactory scopeFactory)
        {
            _scopeFactory = scopeFactory;

        }

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

        public async Task<bool>  SaveColor( ClaimsPrincipal p)
        {
            
            using var scope = _scopeFactory.CreateAsyncScope();
            var userManager = scope.ServiceProvider.GetRequiredService<UserManager<ApplicationUser>>();
            var user = await userManager.GetUserAsync(p);
            user.BackgroundColor = InColor;
            await userManager.UpdateAsync(user);
            return  true;
        }

        public async Task<bool> SetCurrentUserColor(ClaimsPrincipal p)
        {
            using var scope = _scopeFactory.CreateAsyncScope();
            var userManager = scope.ServiceProvider.GetRequiredService<UserManager<ApplicationUser>>();
            var user = await userManager.GetUserAsync(p);
            if (!string.IsNullOrEmpty(user.BackgroundColor))
            {
                InColor = user.BackgroundColor;
                return true; 
            }

            return false; 
        }

    }
}
