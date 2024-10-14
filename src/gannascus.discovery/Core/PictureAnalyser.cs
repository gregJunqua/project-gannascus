using System.Drawing;
using Tesseract;

namespace gannascus.discovery.Core;

public record Localisation(string Zone);

public class PictureAnalyser
{
    public Localisation Analyse(string path)
    {
        using var ocrEngine = new TesseractEngine(@"./Core/tessdata", "eng", EngineMode.Default);
        using var img = Pix.LoadFromFile(path);
        using var page = ocrEngine.Process(img);
        return new Localisation(page.GetText().Trim());
    }
}