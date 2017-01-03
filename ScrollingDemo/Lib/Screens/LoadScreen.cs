namespace ScrollingDemo {
  class LoadScreen : ScreenBase {
    public LoadScreen(ICanvas canvas) : base(canvas) { }

    public override void Render() {
      _Canvas.Clear();

      _Canvas.WriteCenterPosX("Loading...", 10);
    }
  }
}
