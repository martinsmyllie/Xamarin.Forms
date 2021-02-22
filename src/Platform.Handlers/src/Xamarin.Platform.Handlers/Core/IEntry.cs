using Xamarin.Forms;

namespace Xamarin.Platform
{
    public interface IEntry : IView, IText
	{
        bool IsPassword { get; }
    }
}