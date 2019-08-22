using Xamarin.Forms;

using ToDo.Makers;
using ToDo.ViewModels;

namespace ToDo.Views
{
    public partial class AboutPage : ContentPage
    {
        AboutViewModel viewModel;

        public AboutPage(AboutViewModel viewModel)
        {
            this.viewModel = viewModel;
            PageLayout();
        }


        private void PageLayout()
        {
            Title = VariablesTexts.PAGE_NAME_ABOUT;
            // Gird
            Grid grid = LayoutMaker.NewGrid(2, 0);
            grid.RowDefinitions[0].Height = GridLength.Auto;
            grid.RowDefinitions[1].Height = GridLength.Star;
            // Grid StackLayout
            StackLayout stackLayout = LayoutMaker.NewStackLayout(new Thickness(0, 0, 0, 0));
            stackLayout.BackgroundColor = Color.FromHex(VariablesGlobal.COLOUR_ACCENT);
            stackLayout.VerticalOptions = LayoutOptions.FillAndExpand;
            stackLayout.HorizontalOptions = LayoutOptions.Fill;
            ContentView contentView = ViewMaker.NewContentView(new Thickness(0, 40, 0, 40),
                ViewMaker.NewImageByHeight("xamarin_logo.png", LayoutOptions.Center, 64));
            contentView.VerticalOptions = LayoutOptions.FillAndExpand;
            stackLayout.Children.Add(contentView);
            // ScrollView StackLayout
            StackLayout contentStackLayout = LayoutMaker.NewStackLayout(new Thickness(16, 40, 16, 40), 10);
            contentStackLayout.Orientation = StackOrientation.Vertical;
            contentStackLayout.Children.Add(AppDetailsLabel());
            contentStackLayout.Children.Add(AppInformationLabel());
            contentStackLayout.Children.Add(AppTextLabel());
            contentStackLayout.Children.Add(ViewMaker.NewButtonICommand(viewModel.OpenWebCommand, "Learn more"));
            // Add content to grid
            grid.Children.Add(stackLayout, 0, 0);
            grid.Children.Add(LayoutMaker.NewScrollView(contentStackLayout), 0, 1);

            Content = grid;
        }

        private Label AppDetailsLabel()
        {
            FormattedString appDetailsStrings = ElementMaker.NewFormattedString(3);
            Label appDetails = ViewMaker.NewLabelFormattedString(appDetailsStrings, VariablesGlobal.TEXT_SIZE_LARGE);

            appDetailsStrings.Spans[0] = ElementMaker.NewSpan("ToDo", VariablesGlobal.TEXT_SIZE_LARGE, FontAttributes.Bold);
            appDetailsStrings.Spans[1] = ElementMaker.NewSpan(" ");
            appDetailsStrings.Spans[2] = ElementMaker.NewSpan("1.0", VariablesGlobal.TEXT_SIZE_MEDIUM, FontAttributes.None, VariablesGlobal.COLOUR_TEXT_LIGHT);
            appDetailsStrings.Spans[2].ForegroundColor = Color.FromHex(VariablesGlobal.COLOUR_TEXT_LIGHT);

            return appDetails;
        }
        private Label AppInformationLabel()
        {
            FormattedString appDetailsStrings = ElementMaker.NewFormattedString(4);
            Label appDetails = ViewMaker.NewLabelFormattedString(appDetailsStrings, VariablesGlobal.TEXT_SIZE_LARGE);

            appDetailsStrings.Spans[0] = ElementMaker.NewSpan("This app is written in C# and native APIs using the");
            appDetailsStrings.Spans[1] = ElementMaker.NewSpan(" ");
            appDetailsStrings.Spans[2] = ElementMaker.NewSpan("Xamarin Platform", VariablesGlobal.TEXT_SIZE_MEDIUM, FontAttributes.Bold);
            appDetailsStrings.Spans[2].ForegroundColor = Color.FromHex(VariablesGlobal.COLOUR_TEXT_LIGHT);
            appDetailsStrings.Spans[3] = ElementMaker.NewSpan(".");

            return appDetails;
        }
        private Label AppTextLabel()
        {
            FormattedString appDetailsStrings = ElementMaker.NewFormattedString(4);
            Label appDetails = ViewMaker.NewLabelFormattedString(appDetailsStrings, VariablesGlobal.TEXT_SIZE_MEDIUM);

            appDetailsStrings.Spans[0] = ElementMaker.NewSpan("It shares code with its");
            appDetailsStrings.Spans[1] = ElementMaker.NewSpan(" ");
            appDetailsStrings.Spans[2] = ElementMaker.NewSpan("iOS, Android, and Windows", VariablesGlobal.TEXT_SIZE_LARGE, FontAttributes.Bold);
            appDetailsStrings.Spans[2].ForegroundColor = Color.FromHex(VariablesGlobal.COLOUR_TEXT_LIGHT);
            appDetailsStrings.Spans[3] = ElementMaker.NewSpan(".");

            return appDetails;
        }
    }
}