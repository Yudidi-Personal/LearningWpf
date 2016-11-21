/// <summary>
///  深入浅出WPF（9）——数据的绿色通道，Binding（下）: http://blog.csdn.net/fantasiax/article/details/2749292
/// </summary>

# 解决的问题: 
1. 当前窗体的很多控件绑定到同一个数据源上. binding代码有较多重复的地方
2. 某个UI控件只能有一个Soure,但是要求先后绑定2个数据源时,怎么实现

# 代码表现上比较特殊的地方
```
1. {Binding="Path=ID"} //Binding只指明Path //当一个绑定没有显示的源对象时，WPF会遍历整个逻辑树，直到找到一个非空的DataContext属性为止
1. {Binding}           //Source和Path都不指明,则会搜索DataContext并且表示绑定整个DataContext对象
```


# FAQ
Q:什么叫遍历逻辑树
A1:在Wpf中,用户界面由一棵对象树构成,叫Logic Tree. 
Logic tree的根节点总是Window
A2:http://www.cnblogs.com/chenxizhang/archive/2010/01/16/1649043.html
相当于遍历了所有的控件.
```
WpfApplication1.Window1
  System.Windows.Controls.Grid
    System.Windows.Controls.TextBox
    System.Windows.Controls.Label
    System.Windows.Controls.Button: Button
      Button
    System.Windows.Controls.Button: Button
      Button
    WpfApplication1.UserControl1
      System.Windows.Controls.Grid
        System.Windows.Controls.TextBox: Hello,World
          Hello,World
```
A3: