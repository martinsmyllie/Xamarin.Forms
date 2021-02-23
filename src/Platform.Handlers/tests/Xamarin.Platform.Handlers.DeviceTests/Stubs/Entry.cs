using Xamarin.Forms;

namespace Xamarin.Platform.Handlers.DeviceTests.Stubs
{
	public partial class EntryStub : StubBase, IEntry
	{
		private string _text;

		public string Text { get => _text; set => this.SetProperty(ref _text, value); }

		public Color TextColor { get; set; }

		public bool IsPassword { get; set; }
	}
}