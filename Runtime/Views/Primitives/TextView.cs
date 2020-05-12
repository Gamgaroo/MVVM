using Gamgaroo.MVVM.Runtime.Abstractions;
using UnityEngine.UI;

namespace Gamgaroo.MVVM.Runtime.Views.Primitives
{
    public sealed class TextView : Text, IView<string>, IView<object>
    {
        public void Set(object viewModel)
        {
            text = viewModel.ToString();
        }

        public void Set(string viewModel)
        {
            text = viewModel;
        }
    }
}