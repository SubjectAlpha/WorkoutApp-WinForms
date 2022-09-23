namespace WorkoutApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private readonly string[] ArmWorkouts = { "Bench Press", "Barbell Curls", "45° Incline Bench Press", "Dumbell Curls", "Pull Downs", "Reverse Barbell Curl", "Weighted Tricep Extension", "Palms Up Wrist Curl", "Palms Down Wrist Curl" };
        private readonly string[] LegWorkouts = { "Weighted Squats", "Deadlift", "Goblet Squat", "Lunges", "Weighted Lunges", "Hip Thruster", "Leg Extension", "Farmer's Carry", "Incline Treadmill", "Front Squats" };
        private readonly string[] AbsWorkouts = { "Plank", "Russian Twist", "Dips", "Flutter Kick", "Leg Raises", "Mountain Climbers", "Swiss Ball Rollout", "Swiss Ball Crunches", "Swiss Ball V-Up and Pass", "Burpee", "Corkscrew", "Side Plank (both sides)" };
        private readonly string[] CardioWorkout = { "Rowing", "Treadmill", "Elliptical", "Stationary Bike" };

        private void generateWorkoutBtn_Click(object sender, EventArgs e)
        {
            this.dataGridView1.Rows.Clear();

            var rnd = new Random();

            string[] selectedWorkout = null;
            int repCount = 0;
            int amountOfWorkouts = rnd.Next(4, 10);
            string weight = string.Empty;

            if(this.armsBtn.Checked)
            {
                selectedWorkout = ArmWorkouts;
            } 
            else if(this.legsBtn.Checked)
            {
                selectedWorkout = LegWorkouts;
            }
            else if(this.absBtn.Checked)
            {
                selectedWorkout = AbsWorkouts;
            }

            if (selectedWorkout != null && selectedWorkout.Length > 0)
            {
                for (int i = 0; i < amountOfWorkouts; i++)
                {
                    if (this.muscleBtn.Checked)
                    {
                        repCount = rnd.Next(5, 10);
                        weight = "Heavy";
                    }
                    else if (this.toneBtn.Checked)
                    {
                        repCount = rnd.Next(10, 20);
                        weight = "Moderate";
                    }
                    else if (this.cardioBtn.Checked)
                    {
                        var copyOfAbs = AbsWorkouts;
                        selectedWorkout = copyOfAbs.Union(CardioWorkout).ToArray();
                        weight = "None/Light";
                    }

                    string workout = selectedWorkout[rnd.Next(selectedWorkout.Length)] ?? string.Empty;
                    this.dataGridView1.Rows.Insert(i, workout, repCount, weight);
                }
            }
            else
            {
                MessageBox.Show("Please select a workout type");
            }
        }
    }
}