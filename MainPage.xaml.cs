
namespace CheckListDeFerramentas;


public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
        Entry entry = new Entry { Placeholder = "Enter text here" };
        entry.Keyboard = Keyboard.Create(KeyboardFlags.Suggestions | KeyboardFlags.CapitalizeSentence);

        
    }


}