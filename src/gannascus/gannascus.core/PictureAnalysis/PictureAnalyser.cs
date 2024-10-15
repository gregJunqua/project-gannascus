using System.Drawing;
using Tesseract;

namespace gannascus.core.PictureAnalysis;

public record Localisation(string Zone);

public class PictureAnalyser
{
    public Localisation Analyse(string path)
    {
        using var fullImage = new Bitmap(path);
        var cropRect = new Rectangle(fullImage.Width/2,0,fullImage.Width/2,fullImage.Height/2);
        using var croppedImage = fullImage.Clone(cropRect, fullImage.PixelFormat);
        using var img = PixConverter.ToPix(croppedImage);
        using var ocrEngine = new TesseractEngine(@"./PictureAnalysis/tessdata", "eng", EngineMode.Default);
        using var page = ocrEngine.Process(img);
        return new Localisation(page.GetText().Trim());
    }
}