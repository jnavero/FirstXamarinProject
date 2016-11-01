// WARNING
//
// This file has been generated automatically by Xamarin Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace FirstProject.Ios.Views
{
    [Register ("FirstView")]
    partial class FirstView
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UILabel LabelName { get; set; }

        [Outlet]
        [GeneratedCode("iOS Designer", "1.0")]
        UILabel LabelLastName{ get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UITextField TextFullNamne { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (LabelName != null) {
                LabelName.Dispose ();
                LabelName = null;
            }
            if (LabelLastName != null)
            {
                LabelLastName.Dispose();
                LabelLastName = null;
            }
            if (TextFullNamne != null) {
                TextFullNamne.Dispose ();
                TextFullNamne = null;
            }
        }
    }
}
