namespace ScrollingDemo {
  public interface ICanvas {
    void RenderObj(IObject obj);
    bool ObjCanMove(IObject obj, int incrX, int incrY);
    void Clear();
    void ClearObj(IObject obj);
    void WritePos(string graphic, int x, int y);
    void WriteCenterPosX(string graphic, int y);
    void RemovePos(string graphic, int x, int y);
    int CanvasWidth();
    int CanvasHeight();
    void Fill(char graphic);
  }
}
