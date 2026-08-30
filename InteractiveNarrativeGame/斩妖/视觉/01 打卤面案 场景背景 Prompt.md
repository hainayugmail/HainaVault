# （统一画风版）

## 使用说明

背景图和人物立绘的要求不同：

- **不需要透明背景**（背景本身就是铺满整个画面的最底层，直接是不透明的完整场景即可）
- 建议尺寸比例 **16:9**（对应 Ren'Py 默认设计分辨率 1920×1080，不会变形拉伸）
- 画风依然要和人物立绘保持统一——同样加 `NOT a photograph, illustration style` 类的约束，避免出现照片风背景配插画风人物的割裂感

生成后直接保存为 PNG 或 JPG，放进项目 `game/images/` 文件夹，文件名对应下面每个场景标注的变量名（比如 `bg_street.png`）。

---

## 1. 老街 / 招待所外景（bg_street）

```
environment concept art, background illustration for visual novel,
NOT a photograph, digital painting style,
old narrow Chinese city street at dusk, aged residential buildings,
small run-down hostel signage on a basement-level entrance,
worn concrete pavement, hanging laundry lines, old bicycles parked along the wall,
warm dim streetlights beginning to turn on, slightly hazy atmosphere,
Chinese ink-wash influenced illustration style, muted earthy color palette,
nostalgic atmosphere, wide establishing shot, high detail, no people
--ar 16:9
```

## 2. 招待所前台（bg_hostel_front）

```
environment concept art, background illustration for visual novel,
NOT a photograph, digital painting style,
small dim hostel reception area, worn wooden counter,
old registration book, a flickering fluorescent light tube on the ceiling,
faded wallpaper, a wall clock, keys hanging on a board behind the counter,
slightly cluttered but lived-in atmosphere,
Chinese ink-wash influenced illustration style, muted warm-grey color palette,
eye-level indoor shot, high detail, no people
--ar 16:9
```

## 3. 招待所客房内（bg_hostel）

```
environment concept art, background illustration for visual novel,
NOT a photograph, digital painting style,
small dim budget hostel room at night, simple hard bed with neatly folded quilt,
bedside table, cracked ceiling visible, moonlight coming through a thin curtain,
sparse furniture, slightly eerie quiet atmosphere,
Chinese ink-wash influenced illustration style, cool blue-grey nighttime color palette,
eye-level indoor shot, high detail, no people
--ar 16:9
```

## 4. 翠苑小区（bg_community）

```
environment concept art, background illustration for visual novel,
NOT a photograph, digital painting style,
old Chinese residential community courtyard, narrow spacing between apartment buildings,
overgrown climbing vines and shrubs, worn stone benches under a tree,
a community bulletin board with faded notices, morning sunlight filtering through leaves,
peaceful nostalgic everyday atmosphere,
Chinese ink-wash influenced illustration style, warm muted green-grey color palette,
wide establishing shot, high detail, no people
--ar 16:9
```

## 5. 小李出租屋（bg_xiaoli_room）

```
environment concept art, background illustration for visual novel,
NOT a photograph, digital painting style,
small cramped rented apartment room, unpacked cardboard boxes stacked in corner,
a simple bed, a small desk with an unfinished takeout food container,
slightly messy lived-in atmosphere, dim daylight through a small window,
Chinese ink-wash influenced illustration style, muted brownish-grey color palette,
eye-level indoor shot, high detail, no people
--ar 16:9
```

## 6. 视频通话界面（bg_video）

```
abstract background illustration for visual novel,
NOT a photograph, digital painting style,
abstract dark blue-toned backdrop simulating a video call interface,
subtle soft glow effect, minimal geometric UI-like framing elements,
simple non-distracting atmosphere,
clean modern illustration style, cool dark blue color palette,
high detail, no people, no text
--ar 16:9
```

## 7. 刘婆婆家厨房（）——建议做两版

**现实版（第四拍勘验用，冷清氛围）：**

```
environment concept art, background illustration for visual novel,
NOT a photograph, digital painting style,
quiet empty Chinese home kitchen, slightly dusty stove, a clean polished iron wok hanging,
neat but lifeless atmosphere, cool dim lighting,
Chinese ink-wash influenced illustration style, muted grey-blue color palette,
eye-level indoor shot, high detail, no people
--ar 16:9
```

**幻境版（第六拍造梦用，温暖氛围）：**

```
environment concept art, background illustration for visual novel,
NOT a photograph, digital painting style,
warm cozy Chinese home kitchen, steam rising from a pot on the stove,
fresh green scallions being sliced, warm golden light filling the room,
a sense of comfort and life, slightly dreamlike soft glow,
Chinese ink-wash influenced illustration style, warm golden-orange color palette,
eye-level indoor shot, high detail, no people
--ar 16:9
```

如果做两版，建议用两个不同变量名区分，比如：

```
image bg_liu_kitchen_real = "images/bg_liu_kitchen_real.png"
image bg_liu_kitchen_dream = "images/bg_liu_kitchen_dream.png"
```

然后在脚本对应位置分别调用（第四拍用real版，第六拍造梦用dream版），比只有一张图更有戏剧张力。

---

## 生成后检查清单

- [ ]  是插画/绘画质感，不是照片
- [ ]  画面里没有出现人物（背景图不需要人，人物由立绘单独叠加）
- [ ]  宽高比是 16:9，铺满整个画面不留白边
- [ ]  和人物立绘的整体色调、线条风格统一，不违和