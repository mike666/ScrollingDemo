using System.Threading;

namespace ScrollingDemo {
  class Game {
    private ICanvas _Canvas;

    public Game(ICanvas canvas) {
      _Canvas = canvas;
    }

    public void Start() {
      IScreen screen = new LoadScreen(_Canvas);

      screen.Render();
        
      Thread gameLoop = new Thread(new ThreadStart(() => {
        Thread.Sleep(50);

        screen = new MainScreen(_Canvas, GetTunnel());
        screen.Render();

        while (true) {
        
        }
      }));

      gameLoop.Start();
    }

    private ITunnel GetTunnel() {
      TunnelBuilder tunnelBuilder = new TunnelBuilder();

      tunnelBuilder.Forward(10);
      tunnelBuilder.Down();
      tunnelBuilder.Forward(5);
      tunnelBuilder.Down();
      tunnelBuilder.Forward(10);
      tunnelBuilder.Up();
      tunnelBuilder.Forward(10);
      tunnelBuilder.Down();
      tunnelBuilder.Forward(2);
      tunnelBuilder.Down();
      tunnelBuilder.Forward(20);
      tunnelBuilder.Up();
      tunnelBuilder.Forward(20);
      tunnelBuilder.Up();
      tunnelBuilder.Forward(20);

      return tunnelBuilder.GetTunnel();
    }
  }
}
