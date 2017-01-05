namespace ScrollingDemo {
  class StartScreen : ScreenBase {
    public StartScreen(ICanvas canvas) : base(canvas) { }

    public override void Render(Ibackground background) {
      base.Render(background);

      _Canvas.WriteCenterPosX("Start", 10);
    }
  }
}
