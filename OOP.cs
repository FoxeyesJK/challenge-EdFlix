
public enum Color { Red, Blue }

public interface IShape
{

}

public interface IRed
{

}

public interface IBlue
{

}


public abstract class Shape 
{
	protected Color color;

	public Shape() 
	{

	}
	
	public Color GetColor()
	{
		Console.WriteLine($"Color: {color}");
		return color;
	}
}

public class Circle : Shape
{
		
	public Circle()
	{

	}
	
}

public class Square : Shape
{

	public Square()
	{

	}
}

public class Triangle : Shape
{

	public Triangle()
	{

	}
}


public class RedTriangle : Triangle, IShape, IRed
{
	
	public RedTriangle()
	{
		color = Color.Red;
	}
	
}

public class RedCircle : Circle, IShape, IRed
{
	public RedCircle()
	{
		color = Color.Red;
	}

}

public class BlueSquare : Square, IShape, IBlue
{
	public BlueSquare()
	{
		color = Color.Blue;
	}
}

public class ShapeBucket<T>
{
	protected List<IShape> buckets;
	protected Type type;

	public ShapeBucket()
	{
		buckets = new List<IShape>();
		type = typeof(T);
	}
	
	public void AddShape(IShape shape)
	{
		if(type.IsAssignableFrom(shape.GetType()))
		{
			buckets.Add(shape);
			Console.WriteLine($"Shape has been added: {shape}");
		} else
		{
			//Throw Exception if a correct shape has not been inherited.
			Console.WriteLine($"Fail to add shape: {shape}");
		}
	}
	
	public void ShowBuckets()
	{
		foreach(var item in buckets)
		{
			Console.WriteLine(item.ToString());
		}
	}
}
public class Program
{
    public static void Main()
    {
		var sb = new ShapeBucket<IRed>();

		sb.AddShape(new RedTriangle());
		sb.AddShape(new RedCircle());
		sb.AddShape(new BlueSquare());
		
		sb.ShowBuckets();
	}
}


