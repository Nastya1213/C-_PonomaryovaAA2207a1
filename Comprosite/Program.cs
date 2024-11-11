using System;
namespace CompositePattern{
class Program
{
    static void Main()
    {
        // Создаем параграфы
        Paragraph paragraph1 = new Paragraph("This is the first paragraph.");
        Paragraph paragraph2 = new Paragraph("This is the second paragraph.");

        // Создаем разделы
        Section section1 = new Section("Section 1");
        Section section2 = new Section("Section 2");

        // Добавляем параграфы в разделы
        section1.Add(paragraph1);
        section2.Add(paragraph2);

        // Создаем документ
        Document document = new Document();

        // Добавляем разделы в документ
        document.AddSection(section1);
        document.AddSection(section2);

        // Отображаем структуру документа
        document.Display();
    }
}
}