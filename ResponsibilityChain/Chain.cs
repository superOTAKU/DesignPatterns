namespace ResponsibilityChain;

public class Chain<TSubject> : IChainHead<TSubject>, IChainOperation<TSubject>
{
    public List<IChainComponent<TSubject>> Components { get; } = new List<IChainComponent<TSubject>>();

    private int _index;

    public void Execute(TSubject subject)
    {
        Components[_index++].Execute(subject, this);
    }

    public void Next(TSubject subject)
    {
        if (_index < Components.Count)
        {
            Components[_index++].Execute(subject, this);
        }
    }

}