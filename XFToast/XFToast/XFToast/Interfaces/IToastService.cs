namespace XFToast.Interfaces
{
    public interface IToastService
    {
        void ShowToast(string message, bool isLongToast = false);
    }
}
