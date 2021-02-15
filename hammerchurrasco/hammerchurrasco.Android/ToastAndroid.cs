using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using hammerchurrasco.Droid;
using hammerchurrasco.Interfaces;

[assembly: Xamarin.Forms.Dependency(typeof(ToastAndroid))]
namespace hammerchurrasco.Droid
{
    public class ToastAndroid : IToastMessage
    {
        public void longAlert(string message)
        {
            Toast msg = Toast.MakeText(Application.Context, message, ToastLength.Long);
            msg.SetGravity(GravityFlags.Center, 10, 10);
            msg.Show();
        }

        public void shortAlert(string message)
        {
            Toast msg = Toast.MakeText(Application.Context, message, ToastLength.Short);
            msg.SetGravity(GravityFlags.Center, 10, 10);
            msg.Show();
        }
    }
}