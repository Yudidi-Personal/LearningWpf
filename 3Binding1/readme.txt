/// <summary>
///深入浅出WPF（7）——数据的绿色通道，Binding（上）http://blog.csdn.net/fantasiax/article/details/2577239
/// </summary>


# Data Binding的几个关键概念了——

1. 数据源（Data Source，简称Source）：顾名思义，它是保有数据的实体、是数据的来源、源头。把谁当作数据源完全由程序员来决定——只要你想把它当做数据核心来使用。它可以是一个UI元素、某个类的实例，也可以是一个集合（关于对集合的绑定，非常重要，专门用一篇文章来讨论之）。
2. 路径（Path）：数据源作为一个实体可能保有着很多数据，你具体关注它的哪个数值呢？这个数值就是Path。就上面的例子而言，slider1是Source，它拥有很多数据——除了Value之外，还有Width、Height等，但都不是我们所关心的——所以，我们把Path设为Value。
3. 目标（Target）：数据将传送到哪里去？这就是数据的目标了。上面这个例子中，textBox1是数据的Target。有一点需要格外注意：Target一定是数据的接收者、被驱动者，但它不一定是数据的显示者——也许它只是数据联动中的一环——后面我们给出了例子。
4. 关联（Binding）：数据源与目标之间的通道。正是这个通道，使Source与Target之间关联了起来、使数据能够（直接或间接地）驱动界面！
5. 设定关联（Set Binding）：为Target指定Binding，并将Binding指向Target的一个属性，完成数据的“端对端”传输。


# 图解Data Binding的组成