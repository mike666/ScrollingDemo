namespace ScrollingDemo {
    public interface IObject {
        int GetX();
        int GetY();
        int GetHeight();  
      
        void SetPos(int x, int y);
        void SetGraphic(string graphic);
        string GetGraphic();
    }
}
