namespace ResponsibilityChain;

public interface IChainComponent<TSubject>
{

    void Execute(TSubject subject, IChainOperation<TSubject> chainOperation);

}