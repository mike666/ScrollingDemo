using System;
using System.Threading;

namespace ScrollingDemo {
  class Game {
    private ConsoleKeyInfo keyInfo;

    private ICanvas _Canvas;
    private IScreenFactory _ScreenFactory;

    public Game(ICanvas canvas, IScreenFactory screenFactory) {
      _Canvas = canvas;
      _ScreenFactory = screenFactory;
    }

    public void Start(){
      IScreen screen = _ScreenFactory.Create(Enumerations.Screen.Intro);
      
      screen.Render();

      while ((keyInfo = Console.ReadKey(true)).Key != ConsoleKey.Escape) {
        if (keyInfo.Key == ConsoleKey.Enter) {
          break;
        }
      }

      screen = _ScreenFactory.Create(Enumerations.Screen.Load);
      screen.Render();

      Thread gameLoop = new Thread(new ThreadStart(() => {
        Thread.Sleep(1000);

        screen = _ScreenFactory.Create(Enumerations.Screen.Main);
        screen.Render();

        while (true) {
        
        }
      }));

      gameLoop.Start();
    }
  }
}
