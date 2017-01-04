namespace ScrollingDemo {
  public class TunnelFrame : Block {
    protected int _Height = 0;
    
    public TunnelFrame(string graphic, int x, int y, int height) : base(graphic, x, y)  {
      _Height = height;
    }

    public int GetHeight() {
      return _Height;
    }
    
  }
}
