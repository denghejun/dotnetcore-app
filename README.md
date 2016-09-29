### .NET Core App Demo
* 该Demo主要展示了.NET Core项目之间相互依赖方式
* project.json文件所在的文件夹目录即为一个Project，名字就是文件夹的名字
* global.json文件中`"projects":["contract1","implement"]`则定义了所有的Project（文件夹名字，与project.json文件中的name无关）
* project.json中` "name":"contract2"`,可以定义程序集名字（contract2.dll）
* 项目之间的依赖,只与global.json中定义的projects相关
```
"dependencies": {
    "Microsoft.NETCore.App": {
      "version": "1.0.1"
    },
    "contract": "1.0.0"
```