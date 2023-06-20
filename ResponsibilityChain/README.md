关于职责链模式的实现，有几种方式：
1. 在Component中暴露next字段
2. 将对职责链的操作，作为方法参数传递到组件中

个人是更欣赏第二种方式，原因是组件的实现只需要关心组件内部执行的操作，而不需要关心职责链的组装。

例如，Java的Filter接口设计：

```java
public interface Filter {

    public void doFilter(ServletRequest request, ServletResponse response,
            FilterChain chain) throws IOException, ServletException;
}
```
因此这里我结合了Builder模式，通过IChainBuilder接口构建职责链，分离了职责链的构造和执行。

而在IChainComponent接口的Execute方法中，则设置了IChainOperation接口，让组件自己决定是否继续执行职责链。

最后，IChainBuilder构造得到IChainHead，即得到了职责链的头部节点，将TSubject传入IChainHead接口触发职责链的执行。
