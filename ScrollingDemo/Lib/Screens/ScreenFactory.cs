using System.ComponentModel;

namespace ScrollingDemo {
  public class ScreenFactory : IScreenFactory {
    private ICanvas _Canvas;
    private ITunnelScroller _TunnelScroller;

    public ScreenFactory(ICanvas canvas, ITunnelScroller tunnelScroller) {
      _Canvas = canvas;
      _TunnelScroller = tunnelScroller;
    }

    public IScreen Create(Enumerations.Screen screenType) {
      switch (screenType) {
        case Enumerations.Screen.Intro:
          return new IntroScreen(_Canvas, new PlainBackground());
         case Enumerations.Screen.Load:
          return new LoadScreen(_Canvas, new PlainBackground());
        case Enumerations.Screen.Main:
          return new MainScreen(_Canvas, new TerrainBackground(), _TunnelScroller);
        default:
          throw new InvalidEnumArgumentException("Unrecognized screen type.");
      }
    }
  }
}
