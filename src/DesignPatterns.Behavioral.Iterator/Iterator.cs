namespace DesignPatterns.Behavioral.Iterator
{
    public interface Iterator
    {
        // return bool
	bool HasNext();
	// return object
        object Next();
  }
}
