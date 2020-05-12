namespace Gamgaroo.MVVM.Runtime.Abstractions
{
    public interface IView<in TViewModel>
    {
        void Set(TViewModel viewModel);
    }
}