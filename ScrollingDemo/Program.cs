namespace ScrollingDemo {
  class Program {
    static void Main(string[] args) {
      ICanvas canvas = new ConsoleCanvas();
      ITunnelScroller tunnelScroller = new TunnelScroller(canvas, BuildTunnel());

      Game game = new Game(canvas, new ScreenFactory(canvas, tunnelScroller));

      game.Start();
    }

    private static ITunnel BuildTunnel() {
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
