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
        while (true) {
          System.Threading.Thread.Sleep(2000);

          screen = new MainScreen(_Canvas);
          screen.Render();
        }
      }));

      gameLoop.Start();
    }
  }
}
