﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Net.Sockets;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.NetworkInformation;

using EF_CONFIG;
using EF_CONFIG.BaseModel;
using EF_CONFIG.DataTransform;
using EF_CONFIG.Model;

using WinFormsMvp;
using WinFormsMvp.Forms;
using NeedleController.Presenters;
using NeedleController.Presenters.NeedlePickingPresenters;

namespace NeedleController.Views.NeedlePickingUCs
{
    [PresenterBinding(typeof(CameraViewerPresenter))]
    public partial class CameraViewerUC : MvpUserControl, ICameraViewerUC
    {
        public CameraViewerUC()
        {
            InitializeComponent();
        }

    }
}
