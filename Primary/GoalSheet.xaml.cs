using System.Windows.Input;

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
			// string poop = Preferences.Get("GoalSaveValue", "Null");
			mainPage.MidStack.Clear();
			await DismissAsync();
		}

	}

}