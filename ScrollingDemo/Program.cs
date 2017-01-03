namespace ScrollingDemo {
  class Program {
    static void Main(string[] args) {
      Game game = new Game(new ConsoleCanvas());

      game.Start();
    }
  }
}
