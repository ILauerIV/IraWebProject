
using IraWebProject.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Components;

namespace IraWebProject.UnitTest.ViewModelTests
{
    public class ColorPickerViewmodelTest
    {
        [Fact]
        public void UpdateColor_ShouldUpdateInColor()
        {
            // Arrange
            var viewModel = new ColorPickerViewModel(null);
            var changeEventArgs = new ChangeEventArgs { Value = "Red" };
            // Act
            viewModel.UpdateColor(changeEventArgs).Wait();
            // Assert
            Xunit.Assert.Equal("Red", viewModel.InColor);
        }

        [Fact]
        public void Update_Color_ShouldCheckForNullValue()
        {
            // Arrange
            var viewModel = new ColorPickerViewModel(null);
            var changeEventArgs = new ChangeEventArgs { Value = null };
            // Act
            viewModel.UpdateColor(changeEventArgs).Wait();
            // Assert
            Xunit.Assert.Null(viewModel.InColor);
        }

        [Fact]
        public void UpdateColor_ShouldHandleEmptyString()
        {
            // Arrange
            var viewModel = new ColorPickerViewModel(null);
            var changeEventArgs = new ChangeEventArgs { Value = "" };
            // Act
            viewModel.UpdateColor(changeEventArgs).Wait();
            // Assert
            Xunit.Assert.Equal("", viewModel.InColor);
        }
    }
}
