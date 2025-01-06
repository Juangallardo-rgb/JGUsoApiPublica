using JGApiNasaVMsv.JGViewModels;

namespace JGApiNasaVMsv.JGViews;

public partial class JGApodPage : ContentPage
{
	public JGApodPage()
	{
		InitializeComponent();
        BindingContext = new JGApodViewModels();
    }
}