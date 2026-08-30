
统一画风版·重新生成

## 使用说明

这一版针对上次"老板娘变成写实照片"的问题，做了三处关键修正：

1. **明确排除照片感**：每条 Prompt 开头都加了 `NOT a photograph, NOT photorealistic, digital painting style`
2. **统一构图范围**：统一用 `upper body to knee-length framing`（上半身到膝盖），避免出现"有的全身有的半身"的比例失调
3. **统一宽高比参数**：全部用 `--ar 2:3`，保证图片比例一致，减少后期代码里调 zoom/size 的麻烦

**如果你的生成工具支持"参考图"功能**（Midjourney 的 `--sref` 或 `--cref`），强烈建议把法师那张满意的图片链接加进每条 Prompt 末尾，比如：

```
--sref [法师图片链接] --sw 100
```

这样能最大程度保证画风统一，比纯文字描述精准得多。

---

## 1. 老板娘（重新生成）

```
character concept art, visual novel game sprite, 2D illustration,
NOT a photograph, NOT photorealistic, digital painting style,
middle-aged Chinese woman, hostel front desk clerk,
tired but sharp expression, world-weary demeanor,
simple worn cardigan over plain shirt, hair in a loose bun,
standing pose, arms crossed or leaning slightly,
three-quarter view, upper body to knee-length framing,
transparent background, PNG cutout style, isolated on transparent background,
no ground shadow, no background scenery, centered composition,
Chinese ink-wash influenced illustration style, muted color palette,
soft lighting, clean line art, high detail, 2D game illustration
--ar 2:3
```

## 2. 王大妈

```
character concept art, visual novel game sprite, 2D illustration,
NOT a photograph, NOT photorealistic, digital painting style,
elderly Chinese woman, grey-haired, warm friendly neighborhood auntie,
holding a handful of corn kernels for feeding pigeons,
standing casual pose, floral cardigan,
warm chatty expression, slightly hunched with age,
three-quarter view, upper body to knee-length framing,
transparent background, PNG cutout style, isolated on transparent background,
no ground shadow, no background scenery, centered composition,
Chinese ink-wash influenced illustration style, warm muted color palette,
soft natural lighting, clean line art, high detail, 2D game illustration
--ar 2:3
```

## 3. 快递员小刘

```
character concept art, visual novel game sprite, 2D illustration,
NOT a photograph, NOT photorealistic, digital painting style,
young male delivery courier, energetic friendly expression,
wearing delivery company uniform vest, cap,
holding a phone or package, casual standing pose,
three-quarter view, upper body to knee-length framing,
transparent background, PNG cutout style, isolated on transparent background,
no ground shadow, no background scenery, centered composition,
Chinese ink-wash influenced illustration style, bright clean color palette,
soft lighting, clean line art, high detail, 2D game illustration
--ar 2:3
```

## 4. 保安老赵

```
character concept art, visual novel game sprite, 2D illustration,
NOT a photograph, NOT photorealistic, digital painting style,
middle-aged Chinese male security guard, calm reserved expression,
grey security uniform, holding a white enamel tea mug,
standing pose, weathered face, observant eyes,
three-quarter view, upper body to knee-length framing,
transparent background, PNG cutout style, isolated on transparent background,
no ground shadow, no background scenery, centered composition,
Chinese ink-wash influenced illustration style, muted color palette,
soft lighting, clean line art, high detail, 2D game illustration
--ar 2:3
```

## 5. 租客小李

```
character concept art, visual novel game sprite, 2D illustration,
NOT a photograph, NOT photorealistic, digital painting style,
young man mid-20s, messy unkempt hair, tired sleep-deprived expression,
casual home clothes, slightly wrinkled t-shirt,
standing hesitant posture,
three-quarter view, upper body to knee-length framing,
transparent background, PNG cutout style, isolated on transparent background,
no ground shadow, no background scenery, centered composition,
Chinese ink-wash influenced illustration style, muted color palette,
soft dim lighting, clean line art, high detail, 2D game illustration
--ar 2:3
```

## 6. 小军（视频通话）

```
character concept art, visual novel game sprite, 2D illustration,
NOT a photograph, NOT photorealistic, digital painting style,
middle-aged Chinese man mid-50s, half-grey hair, tired melancholic expression,
wearing a simple collared shirt,
restrained emotional expression, eyes showing suppressed guilt and love,
front-facing, looking directly at camera/viewer,
upper body to knee-length framing,
transparent background, PNG cutout style, isolated on transparent background,
no ground shadow, no background scenery, centered composition,
Chinese ink-wash influenced illustration style, cool desaturated color palette with warm skin tone,
soft lighting, clean line art, high detail, 2D game illustration
--ar 2:3
```

## 7. 壮汉野鬼

```
character concept art, visual novel game sprite, 2D illustration,
NOT a photograph, NOT photorealistic, digital painting style,
menacing male ghost, burly muscular build, swollen unnatural proportions,
thick black smoky aura swirling around the body,
dead fish-like glazed eyes, hunched aggressive posture, reaching hand,
tattered dark clothing, semi-transparent ghostly texture,
dynamic threatening pose, three-quarter view, upper body to knee-length framing,
transparent background, PNG cutout style, isolated on transparent background,
no ground shadow, no background scenery, centered composition,
Chinese ink-wash influenced dark horror illustration style, black and grey with faint green undertone,
dramatic lighting, clean line art, high detail, 2D game illustration
--ar 2:3
```

## 8. 刘婆婆（幻境中，造梦结局专属）

```
character concept art, visual novel game sprite, 2D illustration,
NOT a photograph, NOT photorealistic, digital painting style,
elderly Chinese woman in her 60s-70s, warm gentle face with fine wrinkles,
wearing a simple apron over modest home clothes, neat grey hair in a bun,
caring nurturing expression, cooking pose,
one of the warmest most peaceful smiles, slightly moist eyes with quiet joy,
three-quarter view, upper body to knee-length framing,
transparent background, PNG cutout style, isolated on transparent background,
no ground shadow, no background scenery, centered composition,
Chinese ink-wash influenced illustration style, warm golden lighting,
soft glowing atmosphere, clean line art, high detail, 2D game illustration
--ar 2:3
```

---

## 生成之后的检查清单

拿到新图后，按这几点快速检查，不合格就重新生成，不要将就：

- [ ]  是插画/绘画质感，不是照片
- [ ]  背景确实透明（不是纯白/纯灰的假透明），用图片查看器打开确认四周是棋盘格
- [ ]  构图是"上半身到膝盖"，人物比例占画布的大部分，没有大片多余留白
- [ ]  和法师那张图的整体色调、线条风格看起来像"同一个系列"，不违和