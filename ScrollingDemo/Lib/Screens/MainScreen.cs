namespace ScrollingDemo {
  class MainScreen : ScreenBase {
    public MainScreen(ICanvas canvas) : base(canvas) { }

    public override void Render() {
      _Canvas.Clear();

      _Canvas.WriteCenterPosX("Main", 10);
    }
  }
}
