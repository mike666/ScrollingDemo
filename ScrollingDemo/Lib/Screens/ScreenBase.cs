namespace ScrollingDemo {
  public abstract class ScreenBase : IScreen {
    protected readonly ICanvas _Canvas;
    protected readonly Ibackground _Background;

    public ScreenBase(ICanvas canvas, Ibackground background) {
      _Canvas = canvas;
      _Background = background;
    }

    public virtual void Render() {
      _Background.Render(_Canvas);
    }
  }
}
