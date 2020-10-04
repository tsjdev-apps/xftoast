using Android.App;
using Android.Widget;
using Xamarin.Essentials;
using XFToast.Interfaces;

namespace XFToast.Droid.Services
{
public class ToastService : IToastService
{
    private static Toast _toastInstance;

    public void ShowToast(string message, bool isLongToast = false)
    {
        var toastLength = isLongToast
            ? ToastLength.Long
            : ToastLength.Short;

        MainThread.BeginInvokeOnMainThread(() =>
        {
            _toastInstance?.Cancel();
            _toastInstance = Toast.MakeText(Application.Context, 
                message, toastLength);
            _toastInstance?.Show();
        });
    }
}
}