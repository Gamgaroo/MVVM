using Gamgaroo.MVVM.Runtime.Abstractions;
using TMPro;

namespace Gamgaroo.MVVM.Runtime.Views.Primitives
{
    public class TextMeshProView : TextMeshProUGUI, IView<string>, IView<object>
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