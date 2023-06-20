namespace ResponsibilityChain;

public interface IChainBuilder<TSubject>
{
    void AddComponent(IChainComponent<TSubject> component);

    IChainHead<TSubject> Build();

}