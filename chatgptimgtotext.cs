/**using System;
using System.Drawing;
using System.IO;
using ImageProcessor;
using ImageProcessor.Imaging.Formats;

class Program
{
    static void Main()
    {
        string imagePath = @"C:\Users\wiwa2\module_basics_redux_I-Maria\images\map1.png";
        string outputTextFilePath = "output.txt";

        // Load the image
        using (var image = new Bitmap(imagePath))
        {
            // Resize the image to a manageable size
            var resizedImage = new ImageLayer(image);
            resizedImage.Resize(new Size(40, 40));

            // Convert the image to ASCII art with emoji characters
            var asciiArt = ConvertToAscii(resizedImage);

            // Save the ASCII art to a text file
            File.WriteAllText(outputTextFilePath, asciiArt);
        }
    }

    static string ConvertToAscii(ImageLayer image)
    {
        // Emoji characters arranged from darkest to lightest
        string[] emojiChars = { "🏁", "🚗", "□", "■", "🌕", "🔘", "🔲", "⬜", "⬛", " " };

        using (var stream = new MemoryStream())
        {
            image.Save(stream, new JpegFormat());
            stream.Seek(0, SeekOrigin.Begin);

            using (var reader = new StreamReader(stream))
            {
                var asciiArt = "";
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    foreach (var pixel in line)
                    {
                        var intensity = GetIntensity(pixel);
                        var index = (int)(intensity * (emojiChars.Length - 1));
                        asciiArt += emojiChars[index];
                    }
                    asciiArt += Environment.NewLine;
                }
                return asciiArt;
            }
        }
    }

    static float GetIntensity(char pixel)
    {
        // Convert pixel to grayscale intensity (0.0 to 1.0)
        return pixel / 255f;
    }
}*/