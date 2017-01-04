using System.Collections.Generic;

namespace ScrollingDemo {
  public class TunnelBuilder {
    
    public Tunnel GetTunnel() {
      List<int> commands = new List<int> { 0, 0, 0, 1, 1, 1, 1, 2, 2, 2, 2, 3, 3, 3, 3, 4, 4, 4, 4, 4, 4, 5, 5, 5, 5, 4, 4, 4, 4, 3, 3, 3, 3, 2, 2, 2, 2, 1, 1, 1, 1, 1, 1, 2, 2, 2, 2, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 2, 2, 2, 2, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };

      return new Tunnel(BuildTunnelFrames(commands, 2, 10));
    }

    protected List<TunnelFrame> BuildTunnelFrames(List<int> commands, int objHeight, int upperBoundY) {
      List<TunnelFrame> tunnelFrames = new List<TunnelFrame>();

      int xPos = 0;

      foreach (int command in commands) {
        int yPos = upperBoundY + command;

        tunnelFrames.Add(new TunnelFrame(" ", xPos, yPos, objHeight));

        xPos++;
      }

      return tunnelFrames;
    }
  }
}
