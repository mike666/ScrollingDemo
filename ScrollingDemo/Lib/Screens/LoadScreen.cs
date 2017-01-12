namespace ScrollingDemo {
  class LoadScreen : ScreenBase {
    public LoadScreen(ICanvas canvas, Ibackground background) : base(canvas, background) { }

    public override void Render() {
      base.Render();

      _Canvas.WriteCenterPosX("Loading...", 10);
    }
  }
}
