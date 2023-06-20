namespace ResponsibilityChain;

public interface IChainHead<TSubject>
{
    void Execute(TSubject subject);
}