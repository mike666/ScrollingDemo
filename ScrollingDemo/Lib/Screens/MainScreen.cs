namespace ScrollingDemo {
  class MainScreen : ScreenBase {
    private ITunnel _Tunnel;

    public MainScreen(ICanvas canvas, ITunnel tunnel) : base(canvas) {
      _Tunnel = tunnel;
    }

    public override void Render() {
        
      IScroller scroller = new TerrainScroller(_Canvas, _Tunnel);

      scroller.Start();     
    }
  }
}
