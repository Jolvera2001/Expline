using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Expline.Presentation;
public partial record TransactionsModel
{
    private INavigator _navigator;

    public TransactionsModel(
        INavigator navigator)
    {
        _navigator = navigator;
        Title = "Transactions";
    }

    public string? Title { get; }
}
