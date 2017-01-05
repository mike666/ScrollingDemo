namespace ScrollingDemo {
  class TerrainBackground : Ibackground {
    public void Render(ICanvas canvas) {
      canvas.Clear();
      canvas.Fill('#');
    }
  }
}
