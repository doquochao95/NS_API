using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using NeedleTracking.UserControlUC;
using NeedleTracking.UserControlUC.VolatilityUC;
using NeedleTracking.UserControlUC.RequestUC;
using System.Windows.Media;
using System.Threading;
using NeedleTracking.ViewModel;
using NeedleTracking.ViewModel.VolatilityMenuViewModels;
using NeedleTracking.ViewModel.RequestMenuViewModels;

namespace NeedleTracking.Domain
{
    public class NotEmptyValidationRule : ValidationRule
    {
        public override ValidationResult Validate(object value, CultureInfo cultureInfo)
        {
            return string.IsNullOrWhiteSpace((value ?? "").ToString())
                ? new ValidationResult(false, "Field is required.")
                : ValidationResult.ValidResult;
        }
    }
}
