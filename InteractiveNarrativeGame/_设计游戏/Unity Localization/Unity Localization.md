好,我把这套最小可运行示例整理成几个文件,你可以直接复制进Unity项目里。核心逻辑跟你描述的模型完全对应:表结构里"key相同、每个Locale一列值",代码里只需要按key取值。

Created 5 files, read a file

Created 5 files, read a file

5个文件,先看`SETUP.md`——里面是Editor里必须手动做一次的步骤(装包、建Locale、建表),做完之后剩下4个脚本直接复制进项目对应目录就能跑:

- **`LocalizationHelper.cs`**:异步取值+切语言的核心封装
- **`Editor/L10nKeyGenerator.cs`**:一键扫描所有表生成`L10nKeys`强类型常量类(记得放在`Editor/`文件夹,不然会被打进正式build报错)
- **`LocalizedDialogueLine.cs`**:对话系统调用的示例,支持插入NPC名字这种动态参数
- **`LanguageToggle.cs`**:设置菜单里挂一个按钮就能切中英文,所有绑定过的UI自动刷新

跑通的验证方式很简单:建好一张`UI_Common`表,填一条`gameTitle`(英文"Daemon Hunter",中文"猎魔人"),跑一次`Tools > Localization > Generate Key Constants`,应该会看到生成出`L10nKeys.UI_Common.GameTitle`这个常量,然后随便挂个TMP_Text测试`LocalizationHelper.Get(L10nKeys.UI_Common.TableName, L10nKeys.UI_Common.GameTitle)`能不能正确输出。