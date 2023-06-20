namespace ResponsibilityChain;

public class ChainBuilder<TSubject> : IChainBuilder<TSubject>
{
    private Chain<TSubject> _chain = new Chain<TSubject>();

    public void AddComponent(IChainComponent<TSubject> component)
    {
        _chain.Components.Add(component);
    }

    public IChainHead<TSubject> Build()
    {
        if (_chain.Components.Count == 0)
        {
            throw new ArgumentNullException("no component added");
        }
        return _chain;
    }

}