namespace ScrollingDemo {
  class StartScreen : ScreenBase {
    public StartScreen(ICanvas canvas) : base(canvas) { }

    public override void Render() {
      _Canvas.Clear();

      _Canvas.WriteCenterPosX("Start", 10);
    }
  }
}
