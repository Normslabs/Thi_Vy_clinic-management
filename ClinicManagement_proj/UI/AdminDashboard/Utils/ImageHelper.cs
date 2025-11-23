using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace ClinicManagement_proj.UI
{
    /// <summary>
    /// Helper class for image operations with caching to improve performance
    /// </summary>
    public static class ImageHelper
    {
        private static readonly Dictionary<string, Image> imageCache = new Dictionary<string, Image>();

        /// <summary>
        /// Resize an image with high quality interpolation and cache the result
        /// </summary>
        public static Image ResizeImage(Image img, int width, int height)
        {
            if (img == null) return null;

            string cacheKey = $"{img.GetHashCode()}_{width}_{height}";

            if (imageCache.ContainsKey(cacheKey))
            {
                return imageCache[cacheKey];
            }

            Bitmap resized = new Bitmap(width, height);
            using (Graphics g = Graphics.FromImage(resized))
            {
                g.InterpolationMode = InterpolationMode.HighQualityBicubic;
                g.SmoothingMode = SmoothingMode.HighQuality;
                g.PixelOffsetMode = PixelOffsetMode.HighQuality;
                g.DrawImage(img, 0, 0, width, height);
            }

            imageCache[cacheKey] = resized;
            return resized;
        }

        /// <summary>
        /// Apply standardized styling to a button with icon
        /// </summary>
        public static void StyleButton(Button button, int imageWidth, int imageHeight)
        {
            if (button.Image != null)
            {
                button.Image = ResizeImage(button.Image, imageWidth, imageHeight);
            }
            button.ImageAlign = ContentAlignment.MiddleLeft;
            button.TextAlign = ContentAlignment.MiddleLeft;
            button.TextImageRelation = TextImageRelation.ImageBeforeText;
        }

        /// <summary>
        /// Clear the image cache to free memory
        /// </summary>
        public static void ClearCache()
        {
            foreach (var img in imageCache.Values)
            {
                img?.Dispose();
            }
            imageCache.Clear();
        }
    }
}
