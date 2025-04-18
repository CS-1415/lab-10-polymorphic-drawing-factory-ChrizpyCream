namespace Lab10;

// Represents a graphical element (i.e. a shape) that can be printed to the
// console.
public interface IGraphic2D
{
    // draws the graphic on the screen; return true if successful
    bool Display();
}