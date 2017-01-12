namespace ScrollingDemo {
  class MainScreen : ScreenBase {
    private ITunnelScroller _TunnelScroller;

    public MainScreen(ICanvas canvas, Ibackground background, ITunnelScroller tunnelScroller) : base(canvas, background) {
      _TunnelScroller = tunnelScroller;
    }

    public override void Render() {
      base.Render();
           
      _TunnelScroller.Start();     
    }
  }
}
