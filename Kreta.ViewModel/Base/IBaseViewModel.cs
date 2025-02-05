using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kreta.ViewModelProject.Base
{
    public interface IBaseViewModel
    {
        public Task LoadDataAsync();
    }
}
