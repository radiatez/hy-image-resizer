using System.Windows.Forms;

namespace hy_image_resizer._classes.Extensions
{
    public static partial class API
    {
        public static void AllowFiles(this DragEventArgs e)
        {
            e.Effect = e.Data.GetDataPresent(DataFormats.FileDrop)
                ? DragDropEffects.Copy : DragDropEffects.None;
        }

        public static string[] GetPaths(this DragEventArgs e)
        {
            return e.Data.GetData(DataFormats.FileDrop) as string[];
        }
    }
}
