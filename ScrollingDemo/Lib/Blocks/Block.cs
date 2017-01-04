namespace ScrollingDemo {
  public class Block : IObject {

    protected string _Graphic = "";
    protected int _X = 0;
    protected int _Y = 0;

    public Block(string graphic, int x, int y) {
      SetGraphic(graphic);
      _X = x;
      _Y = y;
    }

    public void SetGraphic(string graphic) {
      _Graphic = graphic;
    }

    public string GetGraphic() {
      return _Graphic;
    }

    public int GetX() {
      return _X;
    }

    public int GetY() {
      return _Y;
    }

    public void SetPos(int x, int y) {
      _X = x;
      _Y = y;
    }
  }
}
