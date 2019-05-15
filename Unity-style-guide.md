# Unity中C#的代码格式规范

## 介绍

***该文档主要是用于Unity开发中C#代码格式的规范和项目结构规范***

## 目录

- [命令格式](#命名格式)
   + [命名空间](#命名空间)
   + [类名&接口](#类名和接口)
   + [函数](#函数)
   + [变量](#变量)
   + [参数](#参数)
   + [委托](#delegates-委托)
   + [事件](#events-事件)
   + [其他补充](#其他补充)
- [声明](#声明)
   + [访问修饰符](#访问修饰符)
   + [属性](#属性)
   + [类](#类)
   + [接口](#接口)
- [间距](#间距)
   + [缩进](#缩进)
      * [代码块的缩进](#代码块的缩进)
      * [自动换行](#自动换行)
      * [行长度](#行长度)
   + [垂直间距](#垂直间距)
- [括号规范](#括号规范)
- [Switch 语句](#switch-语句)
- [语言](#语言)
- [Unity项目开发规范](#unity项目开发规范)
   + [Assets目录结构](#assets目录结构)
   + [C#脚本编辑规范](#脚本编辑规范)
   + [优化建议(需持续更新)](#优化建议)
   + [ChangeLog 文件](#日志文件)


## 命名格式

以C#默认命名方式为基础

### 命名空间
全部采用 **PascalCase** 命名方式,多个字母连在一起的时候不使用 (-)或(_);另外如果使用的单词首字母缩写,可以使用全大写，例如:GUI或HUD之类, **尽量不用缩写**

**错误写法:**

```csharp
com.raywenderlich.fpsgame.hud.healthbar
```

**正确写法:**

```csharp
RayWenderlich.FPSGame.HUD.Healthbar
```

### 类名和接口

全部采用 **PascalCase** 命名方式,例如:`RadialSlider`

### 函数

全部采用 **PascalCase** 命名方式,例如:`DoSomething()`

### 变量

所有非静态的都使用 **camelCase** 命名方式,静态变量要使用 **PascalCase**命名方式

**错误写法:**

```csharp
private int _myPrivate;
public static readonly testNumber = 3;
```

**正确写法:**

```csharp
private int myPrivate;
public static readonly TestNumber = 3;
```

### 参数

函数参数均采用 **camelCase**命名方式

**错误写法:**

```csharp
void DoSomething(Vector3 Location)
```

**正确写法:**

```csharp
void DoSomething(Vector3 location)
```

### Delegates 委托

委托都采用 **PascalCase** 命名方式

当声明用于事件类型的委托时,需要在名称添加 **EventHandler** 后缀
当声明用于非事件类型的委托时,需要添加 **Callback** 后缀

**错误写法:**

```csharp
public delegate void Click();
public delegate void Render();
```

**正确写法:**

```csharp
public delegate void ClickEventHandler();
public delegate void RenderCallback();
```

### Events 事件

事件都采用 **PascalCase** 命名方式
永远都不要在事件名称前面加上 **On** 的前缀

**错误写法:**

```csharp
public static event CloseCallback OnClose;
```

**正确写法:**

```csharp
public static event CloseCallback Close;
```

### 其他补充

+ 不要乱用首写字母缩写

**错误写法:**

```csharp
XMLHTTPRequest
String URL
findPostByID
```  

**正确写法:**

```csharp
XmlHttpRequest
String url
findPostById
```

## 声明

### 访问修饰符

所有的类,方法和成员变量都需要显示指定访问修饰符

### 属性

- 每一行只声明一个属性变量

**错误写法:**

```csharp
string username, twitterHandle;
```

**正确写法:**

```csharp
string username;
string twitterHandle;
```
- 尽量使用private类型变量,避免使用public类型的变量;
  如果是需要在 **Inspector** 中显示的变量,请添加 **[SerializeField]**

**错误写法:**

```csharp
public Text logoText;
```

**正确写法:**

```csharp
[SerializeField]
private Text logoText;
```

### 类

Unity中创建和使用的类必须使用固定格式的注释

**模板写法:**

```csharp
/**
 * Copyright(C) 2019 by hiscene
 * All rights reserved.
 * FileName:     GPSDataController.cs
 * Author:       yic
 * UnityVersion：2018.3.0f2
 * Date:         2019-04-09
 * Description:  该脚本为GPS数据触发和控制脚本
 *               1) 读取应用目录下的触发文件
 *               2) 利用原生平台的GPS数据进行触发控制
 *               3) 当触发GPS数据后,利用delegate传递消息给UI控制脚本 
*/
[RequireComponent(typeof(TriggerDataFile))]
public class GPSDataController : MonoBehaviour
```

### 接口

所有的接口都需要添加 **I** 的前缀

**错误写法:**

```csharp
public interface RadialSlider
```

**正确写法:**

```csharp
public interface IRadialSlider
```

## 间距

间距对于代码非常重要,请按照以下规范设定间距

### 缩进

缩进请使用 **spaces** ,不要使用 **Tab**

#### 代码块的缩进

请使用4个 **spaces**,或者设置编辑器**Tab**为4个 **spaces**

**错误写法:**

```csharp
for (int i = 0; i < 10; i++) 
{
  Debug.Log("index=" + i);
}
```

**正确写法:**

```csharp
for (int i = 0; i < 10; i++) 
{
    Debug.Log("index=" + i);
}
```

#### 自动换行

换行后的缩进也使用4个 **spaces**,有些编辑器默认为8个

**错误写法:**

```csharp
CoolUiWidget widget =
        someIncrediblyLongExpression(that, reallyWouldNotFit, on, aSingle, line);
```

**正确写法:**

```csharp
CoolUiWidget widget =
    someIncrediblyLongExpression(that, reallyWouldNotFit, on, aSingle, line);
```

### 行长度

每一行的字符长度不能超过 **100**

### 垂直间距

- 每个函数之间都要保持一行空白(也不要超过)
- 函数中有一行空白表示分隔的功能
- 如果函数中代码块过多应该重构为多个函数
- 如果某一个代码块有超过两个函数调用，需要将该代码块重构为函数

## 括号规范

所有的大括号{}都要有自己的行

**错误写法:**

```csharp
class MyClass {
    void DoSomething() {
        if (someTest) {
          // ...
        } else {
          // ...
        }
    }
}
```

**正确写法:**

```csharp
class MyClass
{
    void DoSomething()
    {
        if (someTest)
        {
          // ...
        }
        else
        {
          // ...
        }
    }
}
```

条件语句都要用大括号包括起来,只有一行也需要


**错误写法:**

```csharp
if (someTest)
    doSomething();  

if (someTest) doSomethingElse();
```

**正确写法:**

```csharp
if (someTest) 
{
    DoSomething();
}  

if (someTest)
{
    DoSomethingElse();
}
```

## Switch 语句

**switch** 语句中默认创建生成 **default**,如果没有使用该情况,保证删除 **default**

**DEFAULT GETS USED:**  
  
```csharp
switch (variable) 
{
    case 1:
        break;
    case 2:
        break;
    default:
        break;
}
```

**DEFAULT DOESN'T GET USED:**  
  
```csharp
switch (variable) 
{
    case 1:
        break;
    case 2:
        break;
}
```

## 语言

请使用美式英语的拼写,某些国内品牌的国际通用写法如`taobao`,`Alibaba`等可以直接使用拼音,其余都需要使用英文拼写, **不能随意使用首字母缩写**

## Unity项目开发规范

### Assets目录结构
不管是资源或者脚本文件,一个文件夹下面不能拥有超过 **10** 个文件,超过后要创建文件夹进行分类处理,一个文件夹下的文件必须是同一种类型
![Assets目录结构](https://raw.githubusercontent.com/yichang666/UnityTemplate/master/UnityProjectTemplate/Assets/02.UI/ScreenShot/AssetStructure.jpg "目录结构")

#### 01.Scenes

主要存放为不同Scene文件

#### 02.UI

主要存放为设计提供的UI文件,包含第三方字体库等

#### 03.Scripts

主要存放为当前项目创建的脚本文件

#### 04.Materials

主要存放为自定义的材质文件, **模型导出的材质文件请放在Model文件夹中对应的目录中**

#### 05.Shaders

主要存放为自定义的Shader文件

#### 06.Media

主要存放为媒体文件,包含音频文件,视频文件以及特效文件

#### 07.Model

主要存放为模型文件,每个模型都需要创建对应的文件夹
![模型文件结构](https://raw.githubusercontent.com/yichang666/UnityTemplate/master/UnityProjectTemplate/Assets/02.UI/ScreenShot/ModelStructure.jpg "模型文件目录")
以上三个目录只是常用的,还可以添加其他与当前模型相关的目录

#### 08.Prefabs

主要存放为场景里的预制体

#### 09.3rd-Party

主要存放为第三方插件,每个插件应该拥有独立的目录


#### Editor

存放窗口编辑脚本和默认的文件注释生成脚本

#### Plugins

存放为各个发布平台的库文件

#### Resources 

只有当使用Resource.Load动态加载资源的时候,需要将对应资源放入该目录中

#### StreamingAssets

一般用于需要进行拷贝的文件的存放

#### Test

一般用于编写单元测试的目录


### 脚本编辑规范

* 建议使用 **VS Code** 进行脚本文件编辑,建议添加插件Debugger for Unity,Unity Tools,Unity Snippets,ShaderlabVSCode(Free),ShaderLabFormatter,C#,Beautify
* 首先所有的脚本创建的时候都必须用于对应的注释,参见[脚本注释](#类)
* 每一个成员变量和函数都需要有注释,使用 **///** 自动添加,注释内容和 **///** 空一格
* 函数内部添加注释使用 **//** ,注释内容和 **//** 空一格
* 代码量较大的脚本使用 `#region`和`#endregion` 将代码分区域注释
* 需要显示绑定GameObject的脚本中的变量需要添加Header或ToolTip,保证在Inspector界面能直接看到变量的解释内容
* 核心的脚本文件请使用CustomEditor自定义编辑界面

### 

### 优化建议

- 使用 `gameObject.CompareTag` 代替 `gameObject.tag`
- 使用该方式获取一个随机的布尔值
```csharp 
bool trueOrFalse = (Random.value > 0.5f);
```
- 如果数据结构只是保存了几个有限的变量,使用 `struct` 代替 `Class`
- 使用ScriptableObjects来管理数据
- 项目中Shader请使用Unity官方提供的内置Shader重新编辑生成,便于修改
- 使用对象池,避免反复的使用`Instantiate`和`Destory`
- 将常用的`C#`脚本文件生成`dll`文件使用
- 避免在Update中进行耗时操作

### 日志文件

每个项目都需要添加一个对应的ChangeLog文件,每次发布版本,都需要在ChangeLog文件进行记录更新

















