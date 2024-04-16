namespace Primary;

public partial class MainPage : ContentPage
{
	string[] words =
	["Objective", "Goal", "Focus", "Mission", "Plan", "Target", "Aim", "Intent", "Motive", "Purpose", "Resolve", "Conviction", "Drive"];

	public MainPage()
	{
		InitializeComponent();
		Random random = new Random();
		int index = random.Next(0, words.Length);
		string randomWord = words[index];
		WordofPowerment.Text = $"You Have No {randomWord}...";
	}

	private void InitGoalButton(object sender, EventArgs e)

	{
		var page = new GoalTune
		{
			HasHandle = true,
			CornerRadius = 10
		};
		page.ShowAsync(Window);
	}


}

