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


        // Set up AboutPage UI
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
                ViewMaker.NewImageByHeight(VariablesGlobal.IMAGE_XAMARIN_LOGO, LayoutOptions.Center, 64));
            contentView.VerticalOptions = LayoutOptions.FillAndExpand;
            stackLayout.Children.Add(contentView);
            // ScrollView StackLayout
            StackLayout contentStackLayout = LayoutMaker.NewStackLayout(new Thickness(16, 40, 16, 40), 10);
            contentStackLayout.Orientation = StackOrientation.Vertical;
            contentStackLayout.Children.Add(AppDetailsLabel());
            contentStackLayout.Children.Add(AppInformationLabel());
            contentStackLayout.Children.Add(AppTextLabel());
            contentStackLayout.Children.Add(ViewMaker.NewButtonICommand(viewModel.OpenWebCommand, VariablesTexts.BUTTON_LEARN_MORE));
            // Add content to grid
            grid.Children.Add(stackLayout, 0, 0);
            grid.Children.Add(LayoutMaker.NewScrollView(contentStackLayout), 0, 1);

            Content = grid;
        }

        private Label AppDetailsLabel()
        {
            FormattedString appDetailsStrings = ElementMaker.NewFormattedString(3);
            Label appDetails = ViewMaker.NewLabelFormattedString(appDetailsStrings, VariablesGlobal.TEXT_SIZE_LARGE);

            appDetailsStrings.Spans[0] = ElementMaker.NewSpan(VariablesTexts.APPLICATION_NAME, VariablesGlobal.TEXT_SIZE_LARGE, FontAttributes.Bold);
            appDetailsStrings.Spans[1] = ElementMaker.NewSpan(VariablesTexts.TEXT_SPACE);
            appDetailsStrings.Spans[2] = ElementMaker.NewSpan(VariablesTexts.APPLICATION_VERSION, VariablesGlobal.TEXT_SIZE_MEDIUM, FontAttributes.None, VariablesGlobal.COLOUR_TEXT_LIGHT);
            appDetailsStrings.Spans[2].ForegroundColor = Color.FromHex(VariablesGlobal.COLOUR_TEXT_LIGHT);

            return appDetails;
        }
        private Label AppInformationLabel()
        {
            FormattedString appDetailsStrings = ElementMaker.NewFormattedString(4);
            Label appDetails = ViewMaker.NewLabelFormattedString(appDetailsStrings, VariablesGlobal.TEXT_SIZE_LARGE);

            appDetailsStrings.Spans[0] = ElementMaker.NewSpan(VariablesTexts.ABOUT_CONTENT_INFO_1_4);
            appDetailsStrings.Spans[1] = ElementMaker.NewSpan(VariablesTexts.TEXT_SPACE);
            appDetailsStrings.Spans[2] = ElementMaker.NewSpan(VariablesTexts.ABOUT_CONTENT_INFO_2_4, VariablesGlobal.TEXT_SIZE_MEDIUM, FontAttributes.Bold);
            appDetailsStrings.Spans[2].ForegroundColor = Color.FromHex(VariablesGlobal.COLOUR_TEXT_LIGHT);
            appDetailsStrings.Spans[3] = ElementMaker.NewSpan(VariablesTexts.TEXT_PERIOD);

            return appDetails;
        }
        private Label AppTextLabel()
        {
            FormattedString appDetailsStrings = ElementMaker.NewFormattedString(4);
            Label appDetails = ViewMaker.NewLabelFormattedString(appDetailsStrings, VariablesGlobal.TEXT_SIZE_MEDIUM);

            appDetailsStrings.Spans[0] = ElementMaker.NewSpan(VariablesTexts.ABOUT_CONTENT_INFO_3_4);
            appDetailsStrings.Spans[1] = ElementMaker.NewSpan(VariablesTexts.TEXT_SPACE);
            appDetailsStrings.Spans[2] = ElementMaker.NewSpan(VariablesTexts.ABOUT_CONTENT_INFO_4_4, VariablesGlobal.TEXT_SIZE_LARGE, FontAttributes.Bold);
            appDetailsStrings.Spans[2].ForegroundColor = Color.FromHex(VariablesGlobal.COLOUR_TEXT_LIGHT);
            appDetailsStrings.Spans[3] = ElementMaker.NewSpan(VariablesTexts.TEXT_PERIOD);

            return appDetails;
        }
    }
}