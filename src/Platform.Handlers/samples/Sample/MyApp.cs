﻿using System;
using System.Collections.Generic;
using Xamarin.Forms;
using Xamarin.Platform;
using Xamarin.Platform.Core;

namespace Sample
{
	public class MyApp : IApp
	{
		public MyApp()
		{
			Platform.Init();
		}

		public IView CreateView()
		{
			var verticalStack = new VerticalStackLayout() { Spacing = 5, BackgroundColor = Color.AntiqueWhite };
			var horizontalStack = new HorizontalStackLayout() { Spacing = 2, BackgroundColor = Color.CornflowerBlue };

			var label = new Label { Text = "This will disappear in ~5 seconds", BackgroundColor = Color.Fuchsia };
			label.Margin = new Thickness(15, 10, 20, 15);

			verticalStack.Add(label);

			var button = new Button() { Text = "A Button", Width = 200 };
			var button2 = new Button()
			{
				TextColor = Color.Green,
				Text = "Hello I'm a button",
				BackgroundColor = Color.Purple,
				Margin = new Thickness(12)
			};

			horizontalStack.Add(button);
			horizontalStack.Add(button2);
			horizontalStack.Add(new Label { Text = "And these buttons are in a HorizontalStackLayout" });

			verticalStack.Add(horizontalStack);

			var monkeyList = new List<string>
			{
				"Baboon",
				"Capuchin Monkey",
				"Blue Monkey",
				"Squirrel Monkey",
				"Golden Lion Tamarin",
				"Howler Monkey",
				"Japanese Macaque"
			};

			var picker = new Picker { Title = "Select a monkey", TitleColor = Color.Red, TextColor = Color.Orange };

			picker.ItemsSource = monkeyList;
			verticalStack.Add(picker);

			var slider = new Slider();
			slider.ValueChanged += value => Console.WriteLine($"Slider value: {value:0.000}");
			verticalStack.Add(slider);

			verticalStack.Add(new Switch());
			verticalStack.Add(new Switch() { OnColor = Color.Green });
			verticalStack.Add(new Switch() { ThumbColor = Color.Yellow });
			verticalStack.Add(new Switch() { OnColor = Color.Green, ThumbColor = Color.Yellow });

			return verticalStack;
		}
	}
}