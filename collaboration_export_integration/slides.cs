using Microsoft.Office.Interop.PowerPoint;
using Microsoft.Office.Core;

class SlidesExample
{
    static void Main(string[] args)
    {
        // Создаем экземпляр PowerPoint
        Application pptApplication = new Application();
        Presentation presentation = pptApplication.Presentations.Add(MsoTriState.msoTrue);

        // Добавляем слайд
        Slide slide1 = presentation.Slides.Add(1, PpSlideLayout.ppLayoutText);
        slide1.Shapes[1].TextFrame.TextRange.Text = "Заголовок слайда";
        slide1.Shapes[2].TextFrame.TextRange.Text = "Это пример текста на слайде.";

        // Добавляем второй слайд
        Slide slide2 = presentation.Slides.Add(2, PpSlideLayout.ppLayoutBlank);
        slide2.Shapes.AddTextbox(MsoTextOrientation.msoTextOrientationHorizontal, 100, 100, 500, 100).TextFrame.TextRange.Text = "Второй слайд";

        // Сохраняем презентацию
        presentation.SaveAs(@"C:\example_presentation.pptx");

        // Закрываем PowerPoint
        presentation.Close();
        pptApplication.Quit();

        Console.WriteLine("Презентация создана успешно!");
    }
}