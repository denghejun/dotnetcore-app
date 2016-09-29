### .NET Core App Demo
* 该Demo主要展示了.NET Core项目之间相互依赖方式
* project.json文件所在的文件夹目录即为一个Project，名字就是文件夹的名字
* project.json中` "name":""`,可以定义程序集名字（contract2.dll），但不推荐这么做，保持约定，少出错。
* 项目之间的依赖
```
"dependencies": {
    "Microsoft.NETCore.App": {
      "version": "1.0.1"
    },
    "contract": "1.0.0"
```