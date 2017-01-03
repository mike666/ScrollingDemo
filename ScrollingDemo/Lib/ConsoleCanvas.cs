using System;

namespace ScrollingDemo {
  class ConsoleCanvas : ICanvas {

    public ConsoleCanvas() {
      Console.BackgroundColor = ConsoleColor.White;
      Console.ForegroundColor = ConsoleColor.Black;
      Clear();
    }

    public void RenderObj(IObject obj) {
      RemovePos(obj.GetGraphic(), obj.GetX(), obj.GetY());
      WritePos(obj.GetGraphic(), obj.GetX(), obj.GetY());
    }

    public void MoveObj(IObject obj, int incrX, int incrY) {

      if (ObjCanMove(obj, incrX, incrY)) {
        RemovePos(obj.GetGraphic(), obj.GetX(), obj.GetY());

        int newX = obj.GetX() + incrX;
        int newY = obj.GetY() + incrY;

        obj.SetPos(newX, newY);

        WritePos(obj.GetGraphic(), newX, newY);
      }
    }

    /// <summary>
    /// Overpaint the old hero
    /// </summary>
    public void RemovePos(string graphic, int x, int y) {
      if (!CheckCanvasBoundries(x, y)) {
        return;
      }

      Console.SetCursorPosition(x, y);
      Console.Write(new string(' ', graphic.Length + 2));
    }


    /// <summary>
    /// Overpaint the old hero
    /// </summary>
    public void WritePos(string graphic, int x, int y) {
      Console.SetCursorPosition(x, y);
      Console.Write(graphic);
    }

    /// <summary>
    /// Overpaint the old hero
    /// </summary>
    public void WriteCenterPosX(string graphic, int y) {
      int centerX = (CanvasWidth() / 2) - (graphic.Length / 2);

      Console.SetCursorPosition(centerX, y);
      Console.Write(graphic);
    }

    public void ClearObj(IObject obj) {
      if (!CheckCanvasBoundries(obj.GetX(), obj.GetY())) {
        return;
      }

      Console.SetCursorPosition(obj.GetX(), obj.GetY());
      Console.Write(new string(' ', obj.GetGraphic().Length + 2));
    }

    public bool ObjCanMove(IObject obj, int incrX, int incrY) {
      int newX = obj.GetX() + incrX;
      int newY = obj.GetY() + incrY;

      return CheckCanvasBoundries(newX, newY);
    }

    private bool CheckCanvasBoundries(int x, int y) {
      if (x < 0 || x >= CanvasWidth()) {
        return false;
      }

      if (y < 2 || y >= CanvasHeight()) {
        return false;
      }

      return true;
    }

    public void Clear() {
      Console.Clear();
    }

    public int CanvasWidth() {
      return Console.WindowWidth;
    }

    public int CanvasHeight() {
      return Console.WindowHeight;
    }
  }
}
