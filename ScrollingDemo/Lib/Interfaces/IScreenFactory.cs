namespace ScrollingDemo {
  public interface IScreenFactory {
    IScreen Create(Enumerations.Screen screenType);
  }
}
