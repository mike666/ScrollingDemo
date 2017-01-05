namespace ScrollingDemo {
  public abstract class ScreenBase : IScreen {
    protected readonly ICanvas _Canvas;
    
    public ScreenBase(ICanvas canvas) {
      _Canvas = canvas;
    }

    public virtual void Render(Ibackground background) {
      background.Render(_Canvas);
    }
  }
}
