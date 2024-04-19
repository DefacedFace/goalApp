using System.Windows.Input;
using Syncfusion.Maui.Cards;

namespace Primary;
public partial class GoalSheet
{


	private MainPage mainPage;
	public GoalSheet(MainPage mainPage)
	{
		InitializeComponent();
		this.mainPage = mainPage;
		Loaded += TargetGoalEntry;


	}

	private void TargetGoalEntry(object sender, EventArgs e)
	{
		EntryGoal.Focus();
	}

	private async void PushDoneButton(object sender, EventArgs e)
	{
		bool decision = await App.Current.MainPage.DisplayAlert
		("Finalize Goal?",
		 "You won't be able to change or cancel goal for 24 hours.", "Accept", "Cancel");

		if (decision)
		{
			string goalKeyText = EntryGoal.Text;
			string goalKeyValueDescText = EntryGoalDesc.Text;

			Preferences.Set("GoalSaveKey", goalKeyText);
			Preferences.Set("GoalSaveValue", goalKeyValueDescText);

			bool isGoalActive = true;
			Preferences.Set("isgoal", isGoalActive);

			SfCardView cardView = new SfCardView()
			{
				Content = new Label()
				{
					Text = "SfCardView",
					HorizontalTextAlignment = TextAlignment.Center,
					VerticalTextAlignment = TextAlignment.Center
				}
			};
			mainPage.MidStack.Children.Clear();
			mainPage.MidStack.Children.Add(cardView);


			await DismissAsync();
		}

	}

}