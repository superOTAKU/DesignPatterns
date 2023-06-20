// See https://aka.ms/new-console-template for more information
using ResponsibilityChain;
using System.Text;

//组装一个StringBuilder Chain
ChainBuilder<StringBuilder> builder = new ChainBuilder<StringBuilder>();
builder.AddComponent(new TrimStringComponent());
builder.AddComponent(new AppendStringComponent());
IChainHead<StringBuilder> head = builder.Build();
StringBuilder sb = new StringBuilder("  I don't know you  ");
head.Execute(sb);
Console.WriteLine(sb.ToString());

class TrimStringComponent : IChainComponent<StringBuilder>
{
    public void Execute(StringBuilder subject, IChainOperation<StringBuilder> chainOperation)
    {
       var str = subject.ToString().Trim();
        subject.Clear();
        subject.Append(str);
        chainOperation.Next(subject);
    }
}

class AppendStringComponent : IChainComponent<StringBuilder>
{
    public void Execute(StringBuilder subject, IChainOperation<StringBuilder> chainOperation)
    {
        subject.Append(" Hello");
        chainOperation.Next(subject);
    }
}