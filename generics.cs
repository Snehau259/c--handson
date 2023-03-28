class GenericDatabase<T>
{
public List<T> genericList=new List<T>();
public void Create(T element)
{
genericList.Add(element);
}
public void Delete(T element)
{
genericList.Remove(element);
}
public void display()
{
foreach (T item in genericList)
{
    Console.WriteLine(item+" ");
}
}
}