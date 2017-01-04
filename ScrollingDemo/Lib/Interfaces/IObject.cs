namespace ScrollingDemo {
    public interface IObject {
        int GetX();
        int GetY();
      
        void SetPos(int x, int y);
        void SetGraphic(string graphic);
        string GetGraphic();
    }
}
