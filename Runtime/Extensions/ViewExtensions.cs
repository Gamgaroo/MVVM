using Gamgaroo.MVVM.Runtime.Abstractions;
using Gamgaroo.Reactive.Runtime.Abstractions;

namespace Gamgaroo.MVVM.Runtime.Extensions
{
    public static class ViewExtensions
    {
        public static void Bind<T>(this IView<T> view, IReactiveProperty<T> property)
        {
            if (property != null)
            {
                property.OnValueChanged += view.Set;
                view.Set(property.Value);
            }
            else
            {
                view.Set(default);
            }
        }

        public static void Unbind<T>(this IView<T> view, IReactiveProperty<T> property)
        {
            property.OnValueChanged -= view.Set;
            view.Set(default);
        }
    }
}