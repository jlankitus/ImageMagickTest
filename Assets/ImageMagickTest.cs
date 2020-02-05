using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using ImageMagick;

public class ImageMagickTest : MonoBehaviour
{
    void Start()
    {
        CreateWatermark();
    }


    public void CreateWatermark()
    {
        // our image paths
        var sourcePath = Application.dataPath + "/Images/Test1.png";
        var watermarkPath = Application.dataPath + "/Images/Test2.png";

        // Read image that needs a watermark
        using (MagickImage image = new MagickImage(sourcePath))
        {

            // Read the watermark that will be put on top of the image
            using (MagickImage watermark = new MagickImage(watermarkPath))
            {
                // Draw the watermark in the bottom right corner
                image.Composite(watermark, Gravity.Southeast, CompositeOperator.Over);

                // Optionally make the watermark more transparent
                watermark.Evaluate(Channels.Alpha, EvaluateOperator.Divide, 4);

                // Or draw the watermark at a specific location
                image.Composite(watermark, 200, 50, CompositeOperator.Over);
            }

            // Save the result
            image.Write(Application.dataPath + "/Images/" + "success.jpg");
        }
    }
}