using System.Windows.Forms;

namespace hy_image_resizer._classes.Extensions.Controls_Extensions
{
    public static partial class API
    {
        public static void SetDataSource(this ComboBox comboBox, object dataSource,
            string displayMemeber, string valueMemeber)
        {
            comboBox.DataSource = dataSource;
            comboBox.DisplayMember = displayMemeber;
            comboBox.ValueMember = valueMemeber;
        }
    }
}
