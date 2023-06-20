namespace ResponsibilityChain;

public interface IChainOperation<TSubject>
{
    void Next(TSubject subject);
}