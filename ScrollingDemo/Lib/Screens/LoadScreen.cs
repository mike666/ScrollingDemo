namespace ScrollingDemo {
  class LoadScreen : ScreenBase {
    public LoadScreen(ICanvas canvas) : base(canvas) { }

    public override void Render(Ibackground background) {
      base.Render(background);

      _Canvas.WriteCenterPosX("Loading...", 10);
    }
  }
}
