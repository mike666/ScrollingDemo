using System;
using System.Collections.Generic;
using System.Threading;

namespace ScrollingDemo {
  class MainScreen : ScreenBase {
    public MainScreen(ICanvas canvas) : base(canvas) { }

    public override void Render() {
      _Canvas.Clear();

      _Canvas.Fill('#');
           
      List<int> commands = new List<int> { 0, 0, 0, 1, 1, 1, 1, 2, 2, 2, 2, 3, 3, 3, 3, 4, 4, 4, 4, 4, 4, 5, 5, 5, 5, 4, 4, 4, 4, 3, 3, 3, 3, 2, 2, 2, 2, 1, 1, 1, 1, 1, 1, 2, 2, 2, 2, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 2, 2, 2, 2, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };

      List<IObject> toScroll = new List<IObject>();

      int scrollIndex = 0;
      
      foreach (int command in commands) {
        
        toScroll.Add(new Block(" ", scrollIndex, 10 + command, 2));
          
        scrollIndex++;
      }


      foreach (IObject obj in toScroll) {
        if (obj.GetX() == _Canvas.CanvasWidth() - 1) {
          break;
        }

        _Canvas.RenderObj(obj);
      }

      Thread scrollLoop = new Thread(new ThreadStart(() => {

        while (true) {
          for (int i = 0; i <= _Canvas.CanvasWidth() - 1; i++) {
            if (i == _Canvas.CanvasWidth() - 1) {
              break;
            }

            if (i < toScroll.Count) {
              toScroll[i].SetPos(i, toScroll[i].GetY());

             _Canvas.RenderObj(toScroll[i]);
            }
          }

          Thread.Sleep(40);
          toScroll = Slide(toScroll);

        }
      }));

      scrollLoop.Start();
    }

    private List<IObject> Slide(List<IObject> items) {
      List<IObject> toReturn = new List<IObject>();

      toReturn = items.GetRange(1, items.Count - 1);
      toReturn.Add(items[0]);

      return toReturn;
    }

  }
}
