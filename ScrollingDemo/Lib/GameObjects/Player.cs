namespace ScrollingDemo {
  public class Player : IObject {
        
    protected string _Graphic = "";
    protected int _X = 0;
    protected int _Y = 0;

    protected string Graphic {
      get { return _Graphic; }
    }

    public Player(int x, int y) {
      _X = x;
      _Y = y;
      SetGraphic("->");
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