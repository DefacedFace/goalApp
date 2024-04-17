namespace Primary;

public partial class GoalTune
{

	public GoalTune()
	{
		InitializeComponent();
		Loaded += TargetGoalEntry;

	}

	private void GoalInput(object sender, TextChangedEventArgs e)
	{

	}

	private void TargetGoalEntry(object sender, EventArgs e)
	{
		EntryGoal.Focus();
	}

	private async void PushDoneButton(object sender, EventArgs e)

	{
		bool decision = await App.Current.MainPage.DisplayAlert
		("Finalize Goal?", "You won't be able to change or cancel goal for 24 hours.", "Accept", "Cancel");

		if (decision)

		{

		}

	}

}