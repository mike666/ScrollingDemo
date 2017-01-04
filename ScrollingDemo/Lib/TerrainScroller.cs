using System.Collections.Generic;
using System.Threading;

namespace ScrollingDemo {
  public class TerrainScroller : IScroller {
    private ICanvas _Canvas;
    private Thread _ScrollLoop;

    public TerrainScroller(ICanvas canvas) {
      _Canvas = canvas;
    }

    public void Start() {
      List<int> commands = new List<int> { 0, 0, 0, 1, 1, 1, 1, 2, 2, 2, 2, 3, 3, 3, 3, 4, 4, 4, 4, 4, 4, 5, 5, 5, 5, 4, 4, 4, 4, 3, 3, 3, 3, 2, 2, 2, 2, 1, 1, 1, 1, 1, 1, 2, 2, 2, 2, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 2, 2, 2, 2, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };

      List<IObject> terrainObjects = BuildTerrainObjects(commands, 2, 10);

      RenderTerrain(_Canvas, terrainObjects);
     
      _ScrollLoop = new Thread(new ThreadStart(() => {

        while (true) {
          for (int i = 0; i <= _Canvas.CanvasWidth() - 1; i++) {
            if (i == _Canvas.CanvasWidth() - 1) {
              break;
            }

            if (i < terrainObjects.Count) {
              terrainObjects[i].SetPos(i, terrainObjects[i].GetY());

             _Canvas.RenderObj(terrainObjects[i]);
            }
          }

          Thread.Sleep(40);
          terrainObjects = SlideItems(terrainObjects);

        }
      }));

      _ScrollLoop.Start();
    }
        
    protected List<IObject> BuildTerrainObjects(List<int> commands, int objHeight, int upperBoundY) {
      List<IObject> terrainObjects = new List<IObject>();

      int xPos = 0;

      foreach (int command in commands) {
        int yPos = upperBoundY + command;

        terrainObjects.Add(new Block(" ", xPos, yPos, objHeight));

        xPos++;
      }

      return terrainObjects;
    }

    private void RenderTerrain(ICanvas canvas, List<IObject> terrainObjects) {
      canvas.Clear();
      canvas.Fill('#');

      foreach (IObject obj in terrainObjects) {
        if (obj.GetX() == canvas.CanvasWidth() - 1) {
          break;
        }

        canvas.RenderObj(obj);
      }
    }

    private List<IObject> SlideItems(List<IObject> items) {
      List<IObject> toReturn = new List<IObject>();

      toReturn = items.GetRange(1, items.Count - 1);
      toReturn.Add(items[0]);

      return toReturn;
    }

  }
}
