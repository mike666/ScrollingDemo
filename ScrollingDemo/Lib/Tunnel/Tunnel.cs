using System.Collections.Generic;

namespace ScrollingDemo {
  public class Tunnel {
    private List<TunnelFrame> _TunnelFrames;

    public List<TunnelFrame> TunnelFrames {
      get { return _TunnelFrames; }
    }

    public Tunnel(List<TunnelFrame> tunnelFrames) {
      _TunnelFrames = tunnelFrames;
    }

    public Tunnel() {
      _TunnelFrames = new List<TunnelFrame>();
    }
  }
}
