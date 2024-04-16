namespace Primary;
public partial class GoalTune
{
	public GoalTune()
	{
		InitializeComponent();
		Loaded += TargetGoalEntry;


	}

	private void GoalInput(object sender, EventArgs e)
	{


	}

	private void TargetGoalEntry(object sender, EventArgs e)
	{
		EntryGoal.Focus();
	}






}