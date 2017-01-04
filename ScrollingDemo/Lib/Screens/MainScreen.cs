namespace ScrollingDemo {
  class MainScreen : ScreenBase {
    public MainScreen(ICanvas canvas) : base(canvas) { }

    public override void Render() {
      IScroller scroller = new TerrainScroller(_Canvas);

      scroller.Start();     
    }
  }
}
