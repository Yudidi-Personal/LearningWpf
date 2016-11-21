/// <summary>
/// 绑定集合: http://blog.csdn.net/fantasiax/article/details/2749292
/// </summary>

# 集合绑定的组成部分

1. Source:   实现IEnumerable接口的类,比如集合； 源属性必须是依赖属性
1. Path: Source有很多属性,通过Path指定特定的属性名
1. Target: 一个ItemsControl,作为数据的接受者,被驱动者.
1. Binding:
1. Set Binding:



# Skills
集合绑定选中某项显示详细信息也可以在xaml中直接设置,而不用使用code behind


# ListBox 重要属性
1. listBox1.DisplayMemberPath~ (ItemsControl.DisplayMemberPath)


# FAQ
## 1.　Q: 为什么Source是一个listbox控件
```
 this.lb.SelectedValuePath = "StuNum";
 Binding binding = new Binding() { Source = lb, Path = new PropertyPath("SelectedValue") };
```
需要设置Source+Path+SelectedValuePath才能确定源属性.

A:属于控件绑定到控件这一类.

##　2.　Q: listbox.Items不是依赖属性,但是ItemsSource是依赖属性
A: 因为依赖属性才有'变更通知'的功能,所以把元