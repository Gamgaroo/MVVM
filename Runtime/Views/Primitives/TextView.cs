using Gamgaroo.MVVM.Runtime.Abstractions;
using UnityEngine.UI;

namespace Gamgaroo.MVVM.Runtime.Views.Primitives
{
    public sealed class TextView : Text, IView<string>, IView<float>, IView<int>
    {
        public void Set(string viewModel)
        {
            text = viewModel;
        }

        public void Set(float viewModel)
        {
            text = viewModel.ToString();
        }

        public void Set(int viewModel)
        {
            text = viewModel.ToString();
        }
    }
}