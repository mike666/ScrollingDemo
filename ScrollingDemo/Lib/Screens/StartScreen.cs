namespace ScrollingDemo {
  class StartScreen : ScreenBase {
    public StartScreen(ICanvas canvas, Ibackground background) : base(canvas, background) { }

    public override void Render() { 
      base.Render();

      _Canvas.WriteCenterPosX("Start", 10);
    }
  }
}
