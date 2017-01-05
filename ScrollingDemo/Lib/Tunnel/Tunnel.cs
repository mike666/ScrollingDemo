using System.Collections.Generic;

namespace ScrollingDemo {
  public class Tunnel : ITunnel {

    public List<TunnelFrame> TunnelFrames { get; private set; }

    public Tunnel(List<TunnelFrame> tunnelFrames) {
      TunnelFrames = tunnelFrames;
    }
  }
}
