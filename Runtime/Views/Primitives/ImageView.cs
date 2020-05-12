using Gamgaroo.MVVM.Runtime.Abstractions;
using UnityEngine;
using UnityEngine.UI;

namespace Gamgaroo.MVVM.Runtime.Views.Primitives
{
    public sealed class ImageView : Image, IView<Sprite>
    {
        [SerializeField]
        private readonly bool _disableOnNull = true;

        public void Set(Sprite viewModel)
        {
            if (_disableOnNull)
                enabled = viewModel != null;

            sprite = viewModel;
        }
    }
}