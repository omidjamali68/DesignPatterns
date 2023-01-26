namespace State
{
    public class BrushTool : Tool
    {
        public void MouseDown()
        {
            Console.WriteLine("Show Brush Icon.");
        }

        public void MouseUp()
        {
            Console.WriteLine("Draw a line.");
        }
    }
}