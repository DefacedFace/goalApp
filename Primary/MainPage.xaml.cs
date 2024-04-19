using Syncfusion.Maui.Cards;

namespace Primary
{
	public partial class MainPage : ContentPage
	{
		private string[] words = [ "Objective", "Goal", "Focus", "Mission", "Plan",
			"Aim", "Intent", "Motive", "Purpose", "Resolve", "Conviction", "Drive", "Direction" ];

		public StackLayout MidStack => midStack;

		private void Motivator()
		{
			Random random = new();
			int index = random.Next(0, words.Length);
			string randomWord = words[index];
			WordofPowerment.Text = $"You Have No {randomWord}...";
			ActionSubText.Text = "Add a goal to complete within 24 hrs";
		}

		public MainPage()
		{
			// Preferences.Clear(); 
			// ^ remember to remove above when checking persistance  

			InitializeComponent();


			if (Preferences.Get("isgoal", false) == false)
			{
				Motivator();
			}
			else
			{
				GoalPress.IsVisible = false;

				SfCardView cardView = new()
				{
					Content = new Label()
					{
						Text = "SfCardView",
						HorizontalTextAlignment = TextAlignment.Center,
						VerticalTextAlignment = TextAlignment.Center
					}
				};

				midStack.Children.Add(cardView);

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
