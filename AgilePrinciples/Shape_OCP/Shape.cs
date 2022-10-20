namespace AgilePrinciples.Shape_OCP; 

public interface Shape{
    void Draw();
}

public class Square : Shape {
    public void Draw() {
        // Draw a square
    }
}

public class Circle : Shape {
    public void Draw() {
        // Draw a circle
    }
}