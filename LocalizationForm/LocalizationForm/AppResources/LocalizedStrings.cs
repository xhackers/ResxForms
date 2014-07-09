using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocalizationForm.AppResources
{
    public class LocalizedStrings
    {
        private static readonly LocalizationResources _localizedResources = new LocalizationResources();

        public LocalizationResources LocalizationResources { get { return _localizedResources; } }

    }
}
