using State;

var canvas = new Canvas();

canvas.SetCurrentTool(new BrushTool());
canvas.MouseDown();
canvas.MouseUp();

canvas.SetCurrentTool(new SelectionTool());
canvas.MouseDown();
canvas.MouseUp();

canvas.SetCurrentTool(new EraserTool());
canvas.MouseDown();
canvas.MouseUp();