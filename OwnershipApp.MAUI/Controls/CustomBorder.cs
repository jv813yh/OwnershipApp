using Microsoft.Maui.Controls.Shapes;

namespace OwnershipApp.MAUI.Controls
{
    public class CustomBorder : Border
    {
        private List<int> CornerValues { get; }

        public CustomBorder()
        {
            CornerValues = new List<int> { 10, 40, 70, 100 };

            TranslationX = new Random().Next(-500, 500);
            Rotation = Math.Max(TranslationX, 100);

            AddCornerValues();

            Loaded += CustomBorder_Loaded;
        }

        private void CustomBorder_Loaded(object? sender, EventArgs e)
        {
            this.TranslateTo(0, 0, 3000, Easing.CubicInOut);
            this.RotateTo(0,  3000, Easing.CubicInOut);
        }

        private void AddCornerValues()
        {
            int randomValue = new Random().Next(4);

            StrokeShape = new RoundRectangle
            {
                CornerRadius = new CornerRadius(CornerValues[randomValue])
            };
        }
    }
}
