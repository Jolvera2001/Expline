namespace Expline.Presentation;

public partial record MainModel
{
    private INavigator _navigator;

    public MainModel(
        INavigator navigator)
    {
        _navigator = navigator;
        Title = "Main";
    }

    public string? Title { get; }
}
