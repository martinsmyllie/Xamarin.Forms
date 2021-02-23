﻿using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Platform.Handlers.DeviceTests.Stubs;
using Xunit;

namespace Xamarin.Platform.Handlers.DeviceTests
{
	public partial class SwitchHandlerTests : HandlerTestBase<SwitchHandler>
	{
		[Fact(DisplayName= "[SwitchHandler] Is Toggled Initializes Correctly")]
		public async Task IsToggledInitializesCorrectly()
		{
			var switchStub = new SwitchStub()
			{
				IsToggled = true
			};

			await ValidatePropertyInitValue(switchStub, () => switchStub.IsToggled, GetNativeIsChecked, switchStub.IsToggled);
		}

		[Theory(DisplayName = "[SwitchHandler] Track Color Initializes Correctly")]
		[InlineData(true)]
		[InlineData(false)]
		public async Task TrackColorInitializesCorrectly(bool isToggled)
		{
			var switchStub = new SwitchStub()
			{
				IsToggled = isToggled,
				TrackColor = Color.Red
			};

			await ValidateTrackColor(switchStub, Color.Red);
		}

		[Fact(DisplayName = "[SwitchHandler] Track Color Updates Correctly")]
		public async Task TrackColorUpdatesCorrectly()
		{
			var switchStub = new SwitchStub()
			{
				IsToggled = true
			};

			await ValidateTrackColor(switchStub, Color.Red, () => switchStub.TrackColor = Color.Red);
		}

		[Fact(DisplayName = "[SwitchHandler] ThumbColor Initializes Correctly")]
		public async Task ThumbColorInitializesCorrectly()
		{
			var switchStub = new SwitchStub()
			{
				IsToggled = true,
				ThumbColor = Color.Blue
			};

			await ValidateThumbColor(switchStub, Color.Blue);
		}

		[Fact(DisplayName = "[SwitchHandler] Track Color Updates Correctly")]
		public async Task ThumbColorUpdatesCorrectly()
		{
			var switchStub = new SwitchStub()
			{
				IsToggled = true
			};

			await ValidateThumbColor(switchStub, Color.Red, () => switchStub.ThumbColor = Color.Red);
		}
	}
}