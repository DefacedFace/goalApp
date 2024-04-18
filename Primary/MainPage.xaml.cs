namespace Primary;

public partial class MainPage : ContentPage
{
	string[] words = ["Objective", "Goal", "Focus", "Mission", "Plan",
	"Aim", "Intent", "Motive", "Purpose", "Resolve", "Conviction", "Drive", "Direction"];

	public StackLayout MidStack => midStack;

	bool isActiveGoal = false;

	private void Motivatator()
	{
		Random random = new Random();
		int index = random.Next(0, words.Length);
		string randomWord = words[index];
		WordofPowerment.Text = $"You Have No {randomWord}...";
		ActionSubText.Text = "Add a goal to complete within 24 hrs";
	}

	public MainPage()
	{
		InitializeComponent();

		if (!isActiveGoal)
		{
			Motivatator();
		}

	}

	private void InitGoalButton(object sender, EventArgs e)

	{
		GoalSheet goalSheet = new GoalSheet(this)
		{
			HasHandle = true,
			CornerRadius = 10
		};
		goalSheet.ShowAsync(Window);

	}

}
