﻿using System;
using System.Collections.Generic;
using System.Linq;

using UIKit;
using MonoTouch.Dialog;

namespace App1.iOS
{
    public partial class DialogViewController1 : DialogViewController
    {
        public DialogViewController1() : base(UITableViewStyle.Grouped, null)
        {
            Root = new RootElement("DialogViewController1")
            {
                new Section ("First Section") {
                    new StringElement ("Hello", () => {
                        var alert = UIAlertController.Create ("Hola", "Thanks for tapping, merci!", UIAlertControllerStyle.Alert);
                        var defaultAction = UIAlertAction.Create ("OK", UIAlertActionStyle.Default, null);
                        alert.AddAction (defaultAction);
                        PresentViewController (alert, true, null);
                    }),
                    new EntryElement ("Name", "Enter your name", String.Empty)
                },
                new Section ("Second Section") {
                },
            };
        }
    }
}