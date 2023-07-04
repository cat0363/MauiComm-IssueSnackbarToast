using CommunityToolkit.Maui.Alerts;

namespace MauiComm_IssueSnackbarToast;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
	}

    private void btnSnackbar_Clicked(object sender, EventArgs e)
    {
        Snackbar snackbar = new Snackbar()
        {
            Text = txtMessage.Text,
            Action = null,
            Anchor = null,
            ActionButtonText = string.Empty,
            Duration = new TimeSpan(0, 0, 0, 0, 3500),
            VisualOptions = new CommunityToolkit.Maui.Core.SnackbarOptions()
            {
                BackgroundColor = Colors.Red,
                TextColor = Colors.White,
                CornerRadius = new CornerRadius(5),
            }
        };
        snackbar.Show();
    }

    private void btnToast_Clicked(object sender, EventArgs e)
    {
        Toast toast = new Toast()
        {
            Text = txtMessage.Text,
            Duration = CommunityToolkit.Maui.Core.ToastDuration.Long
        };
        toast.Show();
    }
}

