namespace ScrollingDemo {
  public abstract class ScreenBase : IScreen {
    protected readonly ICanvas _Canvas;

    public ScreenBase(ICanvas canvas) {
      _Canvas = canvas;
    }

    public abstract void Render();
  }
}
