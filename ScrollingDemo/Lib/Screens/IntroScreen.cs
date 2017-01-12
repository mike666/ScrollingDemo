namespace ScrollingDemo {
  class IntroScreen : ScreenBase {
    public IntroScreen(ICanvas canvas, Ibackground background) : base(canvas, background) { }

    public override void Render() {
      base.Render();

      _Canvas.WriteCenterPosX("Welcome to scrolling game demo! Press Enter to continue", 10);
    }
  }
}
