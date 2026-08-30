一、Demo 重新定义

Demo 名称

《诡战：觉醒试炼》

Demo 章节结构

Chapter 0：现实引子

- 搬家
- 栅栏松鼠
- 夜晚入梦

Chapter 1：教学楼前 · 松鼠大战

- 新手教学
- 第一次生成武器
- 第一次死亡压迫
- 学会基础近战

Chapter 2：黑林入口 · 巨型蜈蚣

- 进入树林
- 学会位移、绕后、躲地形攻击
- 学会“错误武器不可靠”

Chapter 3：林中空地 · 九婴

- 多头 Boss
- 学会观察攻击前摇
- 学会打弱点 / 阶段变化 / 绝杀

Epilogue：现实回响

- 商场异象 or 清晨异常
- 留钩子

二、项目 solution skeleton

我先给你一个适合 Unity + C# 的 solution / 目录骨架。

思路是：

先小而清楚，后面能扩。

GuiZhan/

├─ Assets/

│  ├─ Art/

│  │  ├─ Characters/

│  │  ├─ Enemies/

│  │  ├─ Environments/

│  │  ├─ UI/

│  │  └─ VFX/

│  │

│  ├─ Audio/

│  │  ├─ BGM/

│  │  ├─ SFX/

│  │  └─ Voice/

│  │

│  ├─ Animations/

│  │  ├─ Player/

│  │  ├─ Enemies/

│  │  └─ Cutscenes/

│  │

│  ├─ Prefabs/

│  │  ├─ Characters/

│  │  ├─ Enemies/

│  │  ├─ Weapons/

│  │  ├─ UI/

│  │  └─ Environment/

│  │

│  ├─ Scenes/

│  │  ├─ Boot/

│  │  ├─ MainMenu/

│  │  ├─ Demo_Prologue/

│  │  ├─ Demo_SquirrelArena/

│  │  ├─ Demo_Forest_Centipede/

│  │  ├─ Demo_Forest_Jiuying/

│  │  └─ Demo_Epilogue/

│  │

│  ├─ ScriptableObjects/

│  │  ├─ Characters/

│  │  ├─ Abilities/

│  │  ├─ Weapons/

│  │  ├─ Enemies/

│  │  ├─ Bosses/

│  │  ├─ Levels/

│  │  └─ Story/

│  │

│  └─ Scripts/

│     ├─ Core/

│     ├─ Gameplay/

│     ├─ Combat/

│     ├─ Characters/

│     ├─ AI/

│     ├─ Story/

│     ├─ UI/

│     ├─ Data/

│     ├─ Save/

│     ├─ Audio/

│     ├─ DebugTools/

│     └─ Network/        // 先预留，Demo 可空

│

├─ Packages/

├─ ProjectSettings/

└─ README.md

三、按真正开发可用的模块拆分

下面这个拆法，核心是：

先做单机可跑通，

但代码结构从第一天就能容纳：

- 多角色
- Boss
- 副本
- 联机
- Bot

1. Core 模块

负责全局基础设施。

功能列表

- 游戏启动与场景切换
- 输入系统封装
- 时间控制
- 全局事件总线
- 配置读取
- Service Locator / 简易 DI
- 调试开关
- 统一日志

关键类

GameBootstrapper

SceneFlowController

GameEventBus

InputRouter

GameTimeService

GameConfig

DebugConsoleService

说明

这一层尽量不碰具体剧情和具体角色。

它是你的地基。

2. Gameplay 模块

负责关卡循环和玩家交互。

功能列表

- 章节进入/退出
- 关卡目标
- Checkpoint
- 死亡与重试
- 交互触发器
- 主线解锁
- 副本解锁

关键类

LevelDirector

LevelFlowController

ObjectiveTracker

CheckpointController

RespawnController

InteractionTrigger

UnlockProgressService

3. Character 模块

负责玩家角色、NPC、Bot 的统一抽象。

功能列表

- 角色基础属性
- 移动
- 朝向
- 动作状态
- 受击 / 死亡
- 异能槽
- 武器挂点
- AI / 玩家输入切换

关键类

CharacterBase

PlayerCharacter

NpcCharacter

BotCharacter

CharacterStats

CharacterMotor

CharacterAnimatorBridge

CharacterHealth

CharacterStamina

CharacterAbilityController

CharacterWeaponController

CharacterBrain

4. Combat 模块

这是你的核心模块之一。

功能列表

- 普攻
- 轻重击
- 蓄力
- 闪避
- 跳跃攻击
- 命中判定
- 伤害结算
- 护具减伤
- 战斗值 / 感情值接口预留
- 武器伤害叠加
- 异能武器生成

关键类

CombatResolver

Hitbox

Hurtbox

DamageContext

DamageCalculator

AttackDefinition

AttackSequence

WeaponInstance

WeaponDefinition

GuardDefinition

KnockbackHandler

先不要做太复杂的

Demo 先实现：

- 普攻
- 轻击连段
- 上刺
- 下刺
- 跳击
- 闪避
- 命中硬直
- Boss 前摇判定

5. Ability 模块

这是《诡战》的灵魂模块。

功能列表

- 异能触发
- 异能失败
- 异能过载
- 异能冷却
- 异能 UI 提示
- 角色专属异能逻辑

关键类

AbilityBase

AbilityContext

AbilityResult

AbilityCooldown

AbilityFailureRule

AbilityOverloadRule

AbilityTargetingService

Demo 先实现的能力

林晓：需而生刃

- 根据场景和需求生成武器
- 有概率生成错误或脆弱物品
- 在指定剧情节点强制生成树枝

以后扩展

- 近战树枝
- 断裂短刺
- 弯弓
- 稀有武器
- 融合武器

6. Enemy / Boss AI 模块

用于松鼠、蜈蚣、九婴，后面可以长到所有 Boss。

功能列表

- 巡逻
- 发现玩家
- 追击
- 近战攻击
- 远程攻击
- 特殊技能
- 阶段切换
- 狂暴
- 弱点系统
- 死亡演出

关键类

EnemyBase

BossBase

EnemyPerception

EnemyMotor

EnemyCombatController

EnemyStateMachine

BossPhaseController

BossWeakPointController

BossPatternSelector

7. Story 模块

把剧情和玩法解耦。

功能列表

- 过场
- 对话
- 条件触发
- 章节流程
- 分支结局
- 演出与玩法联动
- 现实回响钩子

关键类

StoryDirector

StoryNode

DialogueController

CutsceneTrigger

BranchCondition

EndingResolver

StoryFlagService

核心建议

不要把剧情写死在 MonoBehaviour 里。

用配置驱动，否则你后面会非常难改。

8. UI 模块

负责所有玩家看到的信息。

功能列表

- HUD
- 血条
- 武器状态
- 异能触发提示
- 教学提示
- Boss 血条
- 失败提示
- 快速重开
- 剧情字幕
- 章节标题

关键类

HudController

PlayerStatusPanel

BossHealthBar

AbilityPromptPanel

TutorialPromptPanel

InteractionPromptPanel

DeathScreenController

ChapterTitleController

DialoguePanel

9. Data 模块

用 ScriptableObject + JSON 双层数据化。

功能列表

- 角色定义
- 武器定义
- 异能定义
- 敌人定义
- Boss 阶段定义
- 章节定义
- 掉落定义（后期）
- 副本变体（后期）

关键类

CharacterDefinition

WeaponDefinition

AbilityDefinition

EnemyDefinition

BossDefinition

BossPhaseDefinition

LevelDefinition

StoryChapterDefinition

10. Save / Progress 模块

现在不复杂，但必须预留。

功能列表

- 主线进度
- Boss 是否击败
- 解锁副本
- 死亡次数
- 绝杀次数
- 当前章节

关键类

SaveGameData

SaveService

ProgressSnapshot

ChapterProgress

UnlockState

四、功能列表：按 Demo 范围精确拆解

下面我按你现在的 Demo 来列。

A. 基础功能

必做

- 角色移动
- 奔跑
- 跳跃
- 锁定目标
- 普攻
- 上刺 / 下刺
- 闪避
- 受击
- 死亡
- 重试

可延后

- 连招评分
- 体力槽
- 感情值
- 护具系统
- 复杂装备栏

B. 林晓异能功能

必做

- 异能按钮触发
- 武器生成判定
- 树枝生成
- 树枝断裂
- 短刺生成
- 异能失败提示

可延后

- 多武器池
- 稀有武器
- 情绪波动影响生成权重
- 融合武器

C. 松鼠 Boss 功能

必做

- 发现玩家
- 扑击
- 站立压迫
- 追击
- 近身拍击
- 死亡演出
- 绝杀判定

可延后

- 狂暴状态
- 多段扑杀
- 假动作

D. 巨型蜈蚣 Boss 功能

设计定位

它是“第二老师”。

教什么

- 躲横扫
- 绕背
- 观察尾刺
- 利用位移
- 学会近远距离判断

必做技能

- 地面突刺
- 横向扫尾
- 直线冲刺
- 毒液喷吐
- 身体节段受击反馈

战斗特色

- 不是一个巨大血条木桩
- 要逼玩家学会“走位比乱砍重要”

E. 九婴 Boss 功能

设计定位

它是 Demo 的真正高潮 Boss。

教什么

- 弱点识别
- 多阶段
- 多头攻击前摇识别
- 不同头不同属性
- 绝杀时机判断

必做技能

- 左右咬击
- 喷火
- 喷毒
- 头部轮替攻击
- 阶段切换
- 弱点暴露
- 最终绝杀

建议

Demo 不要真做 9 个完全独立 AI 头。

先做：

- 3 个活跃头 + 6 个演出头  
    这样视觉上还是九婴，但开发量可控。

五、状态机设计

这是最关键的开发骨架之一。

1. 玩家状态机

Idle

├─ Move

│  ├─ Run

│  └─ Turn

├─ Jump

│  ├─ JumpRise

│  ├─ Airborne

│  └─ Land

├─ CombatReady

│  ├─ AttackLight

│  ├─ AttackHeavy

│  ├─ UpStab

│  ├─ DownStab

│  └─ JumpAttack

├─ Dodge

├─ HitReact

├─ AbilityCast

├─ Interact

├─ Dead

└─ CutsceneLocked

C# skeleton

public enum PlayerStateType

{

    Idle,

    Move,

    Run,

    JumpRise,

    Airborne,

    Land,

    CombatReady,

    AttackLight,

    AttackHeavy,

    UpStab,

    DownStab,

    JumpAttack,

    Dodge,

    HitReact,

    AbilityCast,

    Interact,

    Dead,

    CutsceneLocked

}

2. 松鼠 Boss 状态机

Dormant

├─ Observe

├─ Threaten

├─ Chase

├─ LungeAttack

├─ SwipeAttack

├─ Recover

├─ Stagger

├─ FinisherWindow

└─ Dead

说明

松鼠要有“恐吓”和“拖延即死”的状态。

这不是普通怪，是你的第一场压力课。

3. 蜈蚣 Boss 状态机

IdleBurrow

├─ Surface

├─ TrackPlayer

├─ TailSweep

├─ PoisonSpit

├─ Charge

├─ BurrowEscape

├─ ExposedWeakSegment

├─ Stagger

└─ Dead

4. 九婴 Boss 状态机

Dormant

├─ IntroRoar

├─ MultiHeadPattern

│  ├─ BitePattern

│  ├─ FlamePattern

│  ├─ VenomPattern

│  └─ ComboPattern

├─ WeakPointExpose

├─ RagePhase

├─ FinisherWindow

└─ Dead

六、UI 设计 skeleton

你的 UI 不该做成传统 MMO 面板，

而要偏：

梦境压迫 + 简洁 + 高信息优先级

1. 主 HUD

左下

- 玩家血条
- 当前武器图标
- 武器耐久/状态
- 异能可用状态

右下

- 操作提示
- 上刺 / 下刺 / 闪避 / 异能键提示

屏幕中上

- Boss 名称
- Boss 血条
- 阶段提示

屏幕中央动态

- 异能失败提示
- 绝杀窗口提示
- 警告提示

2. 教学 UI

松鼠战教学

- WASD / 左摇杆移动
- Shift 奔跑
- Space 跳跃
- 鼠标左键 / X 轻击
- 鼠标右键 / Y 上刺
- Ctrl / B 下刺
- Q 异能触发

UI 风格建议

不要做太现代科技蓝。

更适合：

- 发灰
- 微泛白
- 像从雾里浮出来

3. 异能 UI

林晓的异能必须有“失控感”。

表现建议

- 按下触发键时，屏幕边缘轻微模糊
- 武器轮廓先闪现，再实体化
- 失败时出现错误轮廓
- 成功时伴随心跳/耳鸣减弱

文案风格

- “你需要武器。”
- “它回应了。”
- “回应错了。”
- “它快碎了。”

4. Boss UI

松鼠

- 不要一开始就显示完整血条
- 先压迫，再显出“可杀”

蜈蚣

- 显示节段受损

九婴

- 主血条 + 活跃头状态提示

七、C# 类结构 skeleton

下面给你一个更接近“真能开始写代码”的骨架。

1. Character 基础

public abstract class CharacterBase : MonoBehaviour

{

    public CharacterStats Stats { get; protected set; }

    public CharacterHealth Health { get; protected set; }

    public CharacterMotor Motor { get; protected set; }

    public CharacterAbilityController AbilityController { get; protected set; }

    public CharacterWeaponController WeaponController { get; protected set; }

    public virtual void Initialize() { }

    public virtual void Tick(float deltaTime) { }

    public virtual void ReceiveDamage(DamageContext context) { }

    public virtual void Die() { }

}

2. PlayerCharacter

public sealed class PlayerCharacter : CharacterBase

{

    private PlayerStateMachine _stateMachine;

    private PlayerInputContext _input;

    public override void Initialize()

    {

        _stateMachine = new PlayerStateMachine(this);

    }

    public override void Tick(float deltaTime)

    {

        _stateMachine.Update(deltaTime);

    }

    public void HandleInput(PlayerInputContext input)

    {

        _input = input;

    }

}

3. BossBase

public abstract class BossBase : CharacterBase

{

    protected BossPhaseController PhaseController;

    protected BossStateMachine StateMachine;

    public abstract void EnterBossFight();

    public abstract void ExitBossFight();

    public abstract void OnPhaseChanged(int phaseIndex);

}

4. 林晓异能

public sealed class WeaponManifestationAbility : AbilityBase

{

    private readonly IWeaponFactory _weaponFactory;

    private readonly IManifestationRuleService _ruleService;

    public WeaponManifestationAbility(

        IWeaponFactory weaponFactory,

        IManifestationRuleService ruleService)

    {

        _weaponFactory = weaponFactory;

        _ruleService = ruleService;

    }

    public override AbilityResult TryCast(AbilityContext context)

    {

        var result = _ruleService.Resolve(context);

        if (!result.Success)

        {

            return AbilityResult.Failed(result.FailureReason);

        }

        var weapon = _weaponFactory.Create(result.WeaponId, context.SpawnPoint);

        return AbilityResult.Success(weapon);

    }

}

5. Boss 阶段定义

[CreateAssetMenu(menuName = "GuiZhan/Boss Phase Definition")]

public sealed class BossPhaseDefinition : ScriptableObject

{

    public string PhaseName;

    public float HealthThreshold;

    public List<AttackDefinition> AvailableAttacks;

    public bool EnableWeakPoint;

    public bool IsRagePhase;

}

6. 章节定义

[CreateAssetMenu(menuName = "GuiZhan/Story Chapter Definition")]

public sealed class StoryChapterDefinition : ScriptableObject

{

    public string ChapterId;

    public string DisplayName;

    public string SceneName;

    public List<string> RequiredFlags;

    public List<string> UnlockFlags;

    public string IntroCutsceneId;

    public string OutroCutsceneId;

}

八、版本范围建议

这个最重要。

我帮你分成 V0 / V1 / V2 / V3。

V0：战斗灰盒验证版

目标：证明“好不好玩”

内容

- 一个简单场景
- 林晓移动
- 树枝武器
- 松鼠攻击
- 命中 / 受击 / 死亡 / 重来

不做

- 剧情
- 演出
- UI 美化
- 蜈蚣
- 九婴

V1：松鼠大战可玩版

目标：证明第一章成立

内容

- 搬家短过场
- 松鼠梦境登场
- 教学
- 松鼠 Boss
- 多结局
- 简单 HUD
- 商场尾钩

可交付

- 第一支试玩视频
- 第一轮用户测试

V2：觉醒试炼 Demo

目标：让玩家觉得“值回票价”

内容

- 松鼠
- 蜈蚣
- 九婴
- 森林过渡探索
- 章节标题
- Boss 战演出
- 快速重开
- 通关记录

可交付

- Steam Demo / itch.io Demo
- 正式放宣传片

V3：Demo+成长预留版

目标：为后续章节铺路

内容

- 主线解锁记录
- 副本入口占位
- 异能成长入口占位
- 第二角色占位
- Bot 接口占位
- 联机层预留

注意

V3 不等于马上做联机。

只是保证结构不堵死。

九、我对“松鼠 + 蜈蚣 + 九婴”的建议

这个组合是成立的，但要明确它们三只怪分别在教什么。

松鼠

教：恐惧 + 逃命 + 第一次近战

蜈蚣

教：移动 + 走位 + 节奏

九婴

教：观察 + 多阶段 + 弱点

这样玩家会觉得：

不是在重复打怪，

而是在完成一场觉醒试炼。

如果三只怪都只是“大血条 + 攻击更强”，那就没意思了。

十、你下一步最该做什么

按最务实顺序：

Step 1

先写一页：

《觉醒试炼 Demo Scope》

只写：

- 场景
- 角色
- Boss
- 核心功能
- 不做什么

Step 2

先搭 V0 灰盒

- 一个白盒场景
- 一个胶囊人
- 一个松鼠替代怪
- 一把树枝
- 能打能死

Step 3

验证手感

先别管剧情。

先问自己：

移动、攻击、闪避、受击，有没有“搏命感”？

Step 4

再往上加演出和剧情