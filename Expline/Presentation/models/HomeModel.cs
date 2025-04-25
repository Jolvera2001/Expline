using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Expline.Presentation;
public partial record HomeModel
{
    private INavigator _navigator;

    public HomeModel(
        INavigator navigator)
    {
        _navigator = navigator;
        Title = "Home";
    }

    public string? Title { get; }
}
