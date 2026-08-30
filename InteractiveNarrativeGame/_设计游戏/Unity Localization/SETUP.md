# Unity Localization 接入步骤

以下是必须在 Editor 里手动做一次的设置(无法用代码代替),做完之后上面几个脚本才能正常工作。

## 1. 安装包
`Window > Package Manager > Unity Registry` 搜索 `Localization`,安装 `com.unity.localization`。

## 2. 创建 Locale 资源
`Edit > Project Settings > Localization`
- 点 `Locale Generator`,勾选 `Chinese (Simplified)` 和 `English`,一键生成两个 Locale 资源。
- 在 `Project Settings > Localization` 里把这两个加进 `Available Locales`,并指定一个作为 `Default`。

## 3. 创建 String Table Collection(按案子拆分,对应之前设计文档里的目录结构)
`Window > Asset Management > Localization Tables`
- 点 `New Table Collection`,类型选 `String Table Collection`
- 名字对应案子,例如 `Case01_Cuojia`、`UI_Common`、`System_Values`
- 选中你在第2步创建的两个 Locale
- 会自动生成两张表(`Case01_Cuojia_zh-Hans.asset`、`Case01_Cuojia_en.asset`),共享同一套 key,列对应语言 —— 这就是你想要的"key相同、每个语言一列值"的结构。

## 4. 填表(两种方式)
- **直接在 Table Collection 窗口里手填**(适合系统文案、量少的表)
- **CSV 导入导出**(适合案子里大量的对话文案,方便甩给译者用 Excel/Google Sheet 协作,填完再导回来):
  Table Collection 窗口右上角 `⋮` 菜单 → `Export CSV` / `Import CSV`

## 5. 给 TMP_Text 绑定本地化
选中 UI 上的 TMP_Text 物体 → `Add Component > Localize String Event`
- 把 `String Reference` 指向对应的 Table + Key
- 静态文案(比如按钮上的"开始")这样绑好就完事,不用写代码

## 6. 动态台词(需要插参数/由对话系统驱动)走代码路径
用上面的 `LocalizedDialogueLine.SetLine(...)` 或直接 `LocalizationHelper.Get(...)`。

## 7. 生成 key 常量类
菜单栏 `Tools > Localization > Generate Key Constants`(对应 `L10nKeyGenerator.cs`,记得放在 `Editor/` 文件夹下)。
每次在表里加/改/删 key 之后重新跑一次这个菜单命令,生成的 `L10nKeys.cs` 会自动更新。

## 8. 语言切换
把 `LanguageToggle.cs` 挂在设置菜单的按钮上即可,切换后所有绑定了 `LocalizeStringEvent` 的 UI 会自动刷新,不用手动遍历刷新每个组件。

---

**打包提示**:IL2CPP 打包(iOS 必须、Android 建议)时,Unity Localization 官方包已经处理好了 AOT/裁剪兼容问题,不需要像纯手写 `.resx` + `ResourceManager` 那样担心反射被裁掉——这是选官方包而不是照搬 WPF 模式的主要原因。
