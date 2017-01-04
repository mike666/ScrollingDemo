using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace ScrollingDemo {
  public class TerrainScroller : IScroller {
    private ICanvas _Canvas;
    private Thread _ScrollLoop;

    public TerrainScroller(ICanvas canvas) {
      _Canvas = canvas;
    }

    public void Start() {
      TunnelBuilder tunnelBuilder = new TunnelBuilder();
      Tunnel tunnel = tunnelBuilder.GetTunnel();
      List<TunnelFrame> tunnelFrames = tunnel.TunnelFrames;     

      RenderTerrain(_Canvas, tunnel);
     
      _ScrollLoop = new Thread(new ThreadStart(() => {

        while (true) {
          for (int i = 0; i <= _Canvas.CanvasWidth() - 1; i++) {
            if (i == _Canvas.CanvasWidth() - 1) {
              break;
            }

            if (i < tunnelFrames.Count) {
              tunnelFrames[i].SetPos(i, tunnelFrames[i].GetY());

              RenderTunnelFrame(_Canvas, tunnelFrames[i]);
            }
          }

          Thread.Sleep(40);
          tunnelFrames = SlideFrames(tunnelFrames);

        }
      }));

      _ScrollLoop.Start();
    }
    
    private void RenderTerrain(ICanvas canvas, Tunnel tunnel) {
      canvas.Clear();
      canvas.Fill('#');

      foreach (TunnelFrame obj in tunnel.TunnelFrames) {
        if (obj.GetX() == canvas.CanvasWidth() - 1) {
          break;
        }

        RenderTunnelFrame(_Canvas, obj);
      }
    }

    private List<TunnelFrame> SlideFrames(List<TunnelFrame> items) {
      List<TunnelFrame> toReturn = new List<TunnelFrame>();

      toReturn = items.GetRange(1, items.Count - 1);
      toReturn.Add(items[0]);

      return toReturn;
    }

    public void RenderTunnelFrame(ICanvas canvas, TunnelFrame obj) {
      int lowerBound = 10;
      int upperBound = 20;

      for (int i = lowerBound; i <= upperBound; i++) {
        if (i < obj.GetY() || i > obj.GetY() + obj.GetHeight()) {
          canvas.WritePos("#", obj.GetX(), i);
        } else {
          canvas.WritePos(obj.GetGraphic(), obj.GetX(), obj.GetY());
        }
      }

      for (int i = 0; i <= obj.GetHeight(); i++) {
        canvas.WritePos(obj.GetGraphic(), obj.GetX(), obj.GetY() + i);
      }
    }
  }
}
