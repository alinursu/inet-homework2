namespace DryFusion
{
    public interface IObjectCreator<T>
    {
         T CreateObjectFromLine(string line);
    }
}