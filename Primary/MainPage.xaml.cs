namespace Primary;

public partial class MainPage : ContentPage
{
	string[] words = ["Objective", "Goal", "Focus", "Mission", "Plan",
	"Aim", "Intent", "Motive", "Purpose", "Resolve", "Conviction", "Drive", "Direction"];

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
		GoalSheet goalSheet = new GoalSheet()
		{
			HasHandle = true,
			CornerRadius = 10
		};
		goalSheet.ShowAsync(Window);


	}



}
