namespace Primary
{
	public partial class MainPage : ContentPage
	{
		public Label _EmptyGoalText => EmptyGoalText;


		public MainPage() : base()
		{
			Preferences.Clear();
			// ^ remember to remove when checking persistance
			InitializeComponent();
			DateText.Text = DateTime.Now.Date.ToShortDateString();
			GoalDataChanged();

		}

		public void GoalDataChanged()
		{
			string currentGoalValue = Preferences.Get("GoalSaveValue", "Null");

			if (Preferences.Get("isgoal", false) == false)
			{
				//
			}

			else
			{
				EmptyGoalText.VerticalTextAlignment = TextAlignment.Start;
				EmptyGoalText.HorizontalTextAlignment = TextAlignment.Start;
				GoalPress.IsVisible = false;
				EmptyGoalText.Text = currentGoalValue;

				Button timeLimit = new Button
				{
					VerticalOptions = LayoutOptions.End,
					HorizontalOptions = LayoutOptions.Center,
					BackgroundColor = Color.FromArgb("B6D969"),
					Text = "00:00:00",
					TextColor = Color.FromArgb("121212"),
					Margin = new Thickness(0, 0, 0, 20)

				};

				poop.Children.Add(timeLimit);
				Grid.SetRow(timeLimit, 2);

			}
		}

		private void InitGoalButton(object sender, EventArgs e)
		{
			GoalSheet goalSheet = new(this)
			{
				HasHandle = true,
				CornerRadius = 10

			};
			goalSheet.ShowAsync(Window);
		}

	}
}
