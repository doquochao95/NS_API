﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsMvp;

namespace NeedleController.Views
{
    public interface INeedleInfoView : IView
    {
        event EventHandler NeedleInfoViewLoaded;
        event EventHandler NeedleInfoViewExited;
        event EventHandler NeedleInformationTabControlSelectedIndexChanged;


        void Load_NeedleInfoView();
        void Exit_NeedleInfoView();
        void Check_NeedleInformationTabControl();
    }
}
