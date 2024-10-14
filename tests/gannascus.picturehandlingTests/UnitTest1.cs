using FluentAssertions;
using gannascus.discovery.Core;

namespace gannascus.picturehandlingTests;

public class Tests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void reading_area_validation_dark_background()
    {
        var path = Directory.GetCurrentDirectory(); 
        var pictureAnalyser = new PictureAnalyser();
        var localisation = pictureAnalyser.Analyse(path+"/assets/testPicture1.jpg");
        localisation.Should().Be("OOC_Stanton_3_Arcorp");
    }
    
    [Test]
    public void reading_area_validation_lighted_background()
    {
        var path = Directory.GetCurrentDirectory(); 
        var pictureAnalyser = new PictureAnalyser();
        var localisation = pictureAnalyser.Analyse(path+"assets/testPicture1.jpg");
        localisation.Should().Be("OOC_Stanton_3_Arcorp");
    }
}