namespace RangeSliderTest

open Xamarin.Forms
open Xamarin.RangeSlider.Forms

type App() =
    inherit Application()

    let stack = StackLayout(VerticalOptions = LayoutOptions.Center)
    let label = Label(XAlign = TextAlignment.Center, Text = "Welcome to F# Xamarin.Forms!")
    let rangeSlider = RangeSlider(MinimumValue = 0.f, MaximumValue = 100.f, LowerValue = 10.f, UpperValue = 90.f, HeightRequest = 10.0, WidthRequest = 100.0)
    do
        stack.Children.Add(label)
        stack.Children.Add(rangeSlider)
        base.MainPage <- ContentPage(Content = stack)
