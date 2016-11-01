using MvvmCross.Binding.BindingContext;
using MvvmCross.iOS.Views;

namespace FirstProject.Ios.Views
{
    public partial class FirstView : MvxViewController
    {
        public FirstView() : base("FirstView", null)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            var set = this.CreateBindingSet<FirstView, Core.ViewModels.FirstViewModel>();
            set.Bind(LabelName).To(vm => vm.Name);
            set.Bind(LabelLastName).To(vm => vm.LastName);
            set.Bind(TextFullNamne).To(vm => vm.FullName);
            set.Apply();
        }
    }
}
