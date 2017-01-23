using System;
using System.Threading;

namespace ScrollingDemo {
  /// <summary>
  ///
  /// </summary>
  public class PlayerController : IObjectController {
    private ICanvas _Canvas = null;
    private Player _Player = null;
    private Thread _ObjThread = null;

    public PlayerController(ICanvas canvas, Player player) {
      _Canvas = canvas;
      _Player = player;
    }

    public IObject GetObject() {
      return _Player;
    }

    public void Start() {
      _ObjThread = new Thread(new ThreadStart(() => {
        _Canvas.RenderObj(_Player);

        ConsoleKeyInfo keyInfo;
        while ((keyInfo = Console.ReadKey(true)).Key != ConsoleKey.Escape) {
          switch (keyInfo.Key) {
            case ConsoleKey.UpArrow:
              _Canvas.MoveObj(_Player, 0, -1);
              break;

            case ConsoleKey.RightArrow:
              _Canvas.MoveObj(_Player, 1, 0);
              break;

            case ConsoleKey.DownArrow:
              _Canvas.MoveObj(_Player, 0, 1);
              break;

            case ConsoleKey.LeftArrow:
              _Canvas.MoveObj(_Player, -1, 0);
              break;
          }
        }
      }));

      _ObjThread.Start();
    }

    public void Stop() {
      _ObjThread.Abort();
    }
  }
}
