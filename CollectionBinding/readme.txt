/// <summary>
/// 绑定集合: http://blog.csdn.net/fantasiax/article/details/2749292
/// </summary>

# 集合绑定的组成部分
1. 集合
2. Binding

## 对集合有要求
* 实现IEnumerable接口 -- 实现该接口



# Q: 为什么Source是一个listbox控件
```
 Binding binding = new Binding() { Source = lb, Path = new PropertyPath("SelectedValue") };
```
A: