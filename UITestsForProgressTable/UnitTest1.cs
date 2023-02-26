using Avalonia.Controls;
using Avalonia.Markup.Xaml.Templates;
using Avalonia.Media;
using Avalonia.VisualTree;

namespace UITestsForProgressTable
{
	public class UnitTest1
	{
		[Fact]
		public void Test1()
		{
			var app = AvaloniaApp.GetApp();
			var mainWindow = AvaloniaApp.GetMainWindow();
			//string t;
			//string testI = "I";

			var listBox = mainWindow.GetVisualDescendants().OfType<ListBox>().First();
			var listBoxForCount = listBox.GetVisualDescendants().OfType<ListBoxItem>();
			var grid = mainWindow.GetVisualDescendants().OfType<Grid>().First(x => (x.Name != null) && x.Name.Equals("Grid"));
			var border = listBox.GetVisualDescendants().OfType<Border>().First(x => (x.Name != null) && x.Name.Equals("Border"));
			var name = listBox.GetVisualDescendants().OfType<TextBlock>().First(x => (x.Name != null) && x.Name.Equals("Name")).Text;
			var text = listBox.GetVisualDescendants().OfType<TextBlock>().First(x => (x.Name != null) && x.Name.Equals("Text")).Text;
			var buttonAdd = mainWindow.GetVisualDescendants().OfType<Button>().First(x => x.Name == "Add");
			var buttonRemove = mainWindow.GetVisualDescendants().OfType<Button>().First(x => x.Name == "Remove");
			var buttonSave = mainWindow.GetVisualDescendants().OfType<Button>().First(x => x.Name == "Save");
			var buttonLoad = mainWindow.GetVisualDescendants().OfType<Button>().First(x => x.Name == "Load");
			var textbox = mainWindow.GetVisualDescendants().OfType<TextBox>().First(x => x.Name == "TextBoxName");
			var color = (border.Background as SolidColorBrush).Color;

			Assert.True(color.Equals(Colors.Green));
			Assert.True(name.Equals("Shalashov Kirill"));
			Assert.True(text.Equals("2"));

			textbox.Text = "qwe";
			buttonAdd.Command.Execute(buttonAdd.CommandParameter);

			Assert.True(listBoxForCount.Count() == 2);

			listBox.SelectedIndex = 0;
			buttonRemove.Command.Execute(buttonRemove.CommandParameter);

            Assert.True(listBoxForCount.Count() == 1);
        }
	}
}