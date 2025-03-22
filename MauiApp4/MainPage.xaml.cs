using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations.Schema;


namespace MauiApp4
{
    public class Habits
    {
        public string Image { get; set; }
        public string NameHabits { get; set; }
        public string Description { get; set; }
        public string Frequency { get; set; }
        public string Data { get; set; }

    }
    public partial class MainPage : ContentPage
    {
        public ObservableCollection<Habits> Habits { get; set; }

        public MainPage()
        {
            InitializeComponent();

            Habits = new ObservableCollection<Habits>
            {
                new Habits { Image = "pp.png", NameHabits = "Правильное питание", Description = "Для сбалансированного пищеварения", Frequency = "Частота - 8", Data= "1 день"},
                new Habits { Image = "prog.png", NameHabits = "Прогулки на свежем воздухе", Description = "Способствует уменьшению стресса и повышению настроения", Frequency = "Частота - 4", Data= "4 дня"},
                new Habits { Image = "son.png", NameHabits = "Здоровый сон", Description = "Сон не менее 7 часов в день" , Frequency = "Частота - 7", Data= "21 деень"},
                new Habits { Image = "zansport.png", NameHabits = "Занятия спортом", Description = "Улучшает физическую выносливость", Frequency = "Частота - 4", Data= "8 дней"},
                new Habits { Image = "radjin.png", NameHabits = "Радоваться жизни", Description = "Помогает наслаждаться жизнью", Frequency = "Частота - 1", Data= "5 дней"},
                new Habits { Image = "ranpod.png", NameHabits = "Ранний подъем", Description = "Улучшает общее самочувствие" , Frequency = "Частота - 2", Data= "16 дней"},
                new Habits { Image = "optnast.png", NameHabits = "Оптимистичный настрой", Description = "Повышает работоспособность...", Frequency = "Частота - 3", Data= "12 дней" }

            };

            BindingContext = this;
        }

        private async void OnDeleteClicked(object sender, EventArgs e)
        {
            if (sender is Button button && button.CommandParameter is Habits habitsToDelete)
            {
                bool answer = await DisplayAlert("Удалить?", $"Вы уверены, что хотите удалить {habitsToDelete.NameHabits}?", "Да", "Нет");
                if (answer)
                {
                    Habits.Remove(habitsToDelete);
                }
            }
        }

        private void OnAddClicked(object sender, EventArgs e)
        {

        }
    }

}
