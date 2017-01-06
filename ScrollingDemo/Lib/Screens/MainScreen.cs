namespace ScrollingDemo {
  class MainScreen : ScreenBase {
    private ITunnelScroller _TunnelScroller;

    public MainScreen(ICanvas canvas, ITunnelScroller tunnelScroller) : base(canvas) {
      _TunnelScroller = tunnelScroller;
    }

    public override void Render(Ibackground background) {
      base.Render(background);
           
      _TunnelScroller.Start();     
    }
  }
}
