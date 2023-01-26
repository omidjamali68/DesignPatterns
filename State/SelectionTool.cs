namespace State
{
    public class SelectionTool : Tool
    {
        public void MouseDown()
        {
            Console.WriteLine("Show Selection Icon.");
        }

        public void MouseUp()
        {
            Console.WriteLine("Draw Dashed rectangle.");
        }
    }
}