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
		EntryGoalDesc.Focus();
	}

	public async void PushDoneButton(object sender, EventArgs e)
	{
		bool decision = await App.Current.MainPage.DisplayAlert
		("Finalize Goal?",
		 "You won't be able to change or cancel goal for 24 hours.", "Accept", "Cancel");

		if (decision)
		{
			string goalKeyValueDescText = EntryGoalDesc.Text;

			Preferences.Set("GoalSaveValue", goalKeyValueDescText);

			bool isGoalActive = true;
			Preferences.Set("isgoal", isGoalActive);
			mainPage.GoalDataChanged();

			await DismissAsync();
		}

	}

}