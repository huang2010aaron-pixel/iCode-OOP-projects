namespace NotetakingApp
{
    public partial class MainPage : ContentPage
    {

        private List<Note> _notes;
        private string _selectedColor;
        public MainPage()
        {
            InitializeComponent();

            _notes = new List<Note>();
            _selectedColor = Note.AvailableColors[0];

            BuildColorPicker();
        }

        private void BuildColorPicker()
        {
            foreach (string color in Note.AvailableColors)
            {
                string capturedColor = color;

                Border swatch = new Border
                {
                    BackgroundColor = Color.FromArgb(color),
                    StrokeShape = new Microsoft.Maui.Controls.Shapes.Ellipse(),
                    WidthRequest = 32,
                    HeightRequest = 32,
                    Stroke = color == _selectedColor
                        ? Colors.White
                        : Colors.Transparent,
                    StrokeThickness = 3
                };

                TapGestureRecognizer tap = new TapGestureRecognizer();
                tap.Tapped += (s, e) => OnColorSelected(capturedColor);
                swatch.GestureRecognizers.Add(tap);

                ColorPickerRow.Children.Add(swatch);
            }
        }

        private void OnColorSelected(string color)
        {
            _selectedColor = color;

            for ( int i = 0; i < Note.AvailableColors.Length; i++ )
            {
                if (ColorPickerRow.Children[i] is Border swatch)
                {
                    swatch.Stroke = Note.AvailableColors[i] == _selectedColor
                           ? Colors.White
                           : Colors.Transparent;
                }
            }
        }
        private void OnAddNoteClicked(object? sender, EventArgs e)
        {
            string text = NoteEditor.Text?.Trim() ?? string.Empty;

            if (string.IsNullOrEmpty(text))
                return;

            Note note = new Note(text, _selectedColor);
            _notes.Add(note);

            NoteEditor.Text = string.Empty;
            
            RenderNotes();
        }

        private void OndDeleteNoteClicked(Note note)
        {
            _notes.Remove(note);
            RenderNotes();
        }

        private void RenderNotes()
        {
            NotesContainer.Children.Clear();

            EmptyLabel.IsVisible = _notes.Count == 0;

            foreach (Note note in _notes)
            {
                NotesContainer.Children.Add(BuildNoteCard(note));
            }
        }

        private View BuildNoteCard(Note note)
        {
            Border card = new Border
            {
                BackgroundColor = Color.FromArgb(note.Color),
                StrokeShape = new Microsoft.Maui.Controls.Shapes.RoundRectangle { CornerRadius = 12 },
                Stroke = Colors.Transparent,
                Padding = new Thickness(16)
            };

            Button deleteBtn = new Button
            {
                Text = "x",
                FontSize = 14,
                TextColor = Colors.White,
                BackgroundColor = Colors.Transparent,
                WidthRequest = 36,
                HeightRequest = 36,
                Padding = 0,
                HorizontalOptions = LayoutOptions.End,
                VerticalOptions = LayoutOptions.Start
            };

            Note capturedNote = note;
            deleteBtn.Clicked += (s, e) => OndDeleteNoteClicked(capturedNote);

            Label textLabel = new Label
            {
                Text = note.Text,
                FontSize = 15,
                TextColor = Colors.White,
                LineBreakMode = LineBreakMode.WordWrap
            };

            Label dateLabel = new Label
            {
                Text = note.CreatedAtFormatted,
                FontSize = 11,
                TextColor = Color.FromArgb("#999999"),
                Margin = new Thickness(0, 0, 0, 0)
            };

            Grid cardGrid = new Grid
            {
                ColumnDefinitions =
                {
                    new ColumnDefinition { Width = GridLength.Star },
                    new ColumnDefinition { Width = GridLength.Auto }
                },
                RowDefinitions =
                {
                    new RowDefinition {Height = GridLength.Auto },
                    new RowDefinition {Height= GridLength.Auto }
                }
            };

            Grid.SetColumn(textLabel, 0);
            Grid.SetRow(textLabel, 0);

            Grid.SetColumn(deleteBtn, 1);
            Grid.SetRow(deleteBtn, 0);

            Grid.SetColumn(textLabel, 0);
            Grid.SetRow(textLabel, 0);

            Grid.SetColumn(dateLabel, 0);
            Grid.SetRow(dateLabel, 1);
            Grid.SetColumnSpan(dateLabel, 2);

            cardGrid.Children.Add(textLabel);
            cardGrid.Children.Add(deleteBtn); 
            cardGrid.Children.Add(dateLabel);

            card.Content = cardGrid;
            return card;
        }
    }
}
