# 《西京红衣怨》美术资源生成提示词（现代都市设定版）

统一规范：角色立绘为纯白背景 PNG(白底更利于后期抠图去背)，全身立绘构图(从头到脚完整站姿)，画风为 digital painting，禁止照片写实；NPC默认站右、脸微向左偏，主角默认站左、脸微向右偏，两者视线在画面中间交汇；背景为不透明全图，16:9，禁止出现人物剪影干扰后期贴图。

**本版说明：故事背景是现代都市，所有在世角色的服装、道具、场景均按当代中国城市语境调整（智能手机时代、现代住宅/写字楼、现代警局等），法师保留驱邪法器与符咒作为职业特征，但整体造型偏"都市异闻录"式的现代驱魔人，而非古装术士。**

---

## 一、角色立绘

### 1. 法师（主角）—— 四种门派版本

四个版本共用同一套构图规范：mid-20s，全身立绘构图(从头到脚完整站姿)，脸微向右偏，三视角向右，透明背景 PNG，`digital painting style, NOT a photograph, NOT photorealistic, solid pure white background (#FFFFFF), isolated on plain white background for easy background removal, no ground shadow, --ar 9:16`。表情变体（常态冷静/咬牙硬撑/专注施法/力竭虚脱）四版通用，写法参考文末统一表情追加词。

**道士版：**

```
A young Chinese Taoist exorcist in his mid-20s, modern streetwear aesthetic — dark fitted jacket or hoodie with subtle talisman-embroidered patches on the collar and cuffs, a string of prayer beads or talisman charm bracelet on one wrist, carrying a wooden sword or talisman papers tucked in a modern messenger bag, calm but weary eyes, contemporary short hairstyle, full-body framing, from head to toe, standing full-length pose, face turned slightly to the right, subtle three-quarter view towards right, digital painting style, NOT a photograph, NOT photorealistic, solid pure white background (#FFFFFF), isolated on plain white background for easy background removal, no ground shadow, --ar 9:16
```

**和尚版：**

```
A young Chinese Buddhist monk exorcist in his mid-20s, modern take on monastic attire — a slate grey-blue (灰青色) modern-cut robe layered over a simple dark undershirt, a string of wooden prayer beads wrapped around one wrist, shaved head or very short hair, calm but weary eyes, carrying a small brass bell or a folded sutra scroll tucked under one arm, composed serene demeanor beneath visible fatigue, full-body framing, from head to toe, standing full-length pose, face turned slightly to the right, subtle three-quarter view towards right, digital painting style, NOT a photograph, NOT photorealistic, solid pure white background (#FFFFFF), isolated on plain white background for easy background removal, no ground shadow, --ar 9:16
```

**出马仙版：**

```
A young Chinese folk shaman exorcist in his mid-20s, practicing the Northeastern "Chuma Xian" fox-spirit tradition, modern-rustic clothing — a red cloth sash tied loosely over a plain dark jacket, a small carved fox or weasel talisman pendant around the neck, weathered practical boots, calm but weary eyes, carrying a hand-painted talisman scroll and a small pouch of ritual items, earthy grounded presence distinct from formal temple ritual, full-body framing, from head to toe, standing full-length pose, face turned slightly to the right, subtle three-quarter view towards right, digital painting style, NOT a photograph, NOT photorealistic, solid pure white background (#FFFFFF), isolated on plain white background for easy background removal, no ground shadow, --ar 9:16
```

**教会驱魔师版：**

```
A young Chinese Catholic exorcist in his mid-20s, modern clerical attire — a black button-up shirt with a white clerical collar, sleeves rolled up, a simple wooden or silver cross pendant, a worn leather-bound Bible or a small vial of holy water tucked in a jacket pocket, calm but weary eyes, contemporary short hairstyle, full-body framing, from head to toe, standing full-length pose, face turned slightly to the right, subtle three-quarter view towards right, digital painting style, NOT a photograph, NOT photorealistic, solid pure white background (#FFFFFF), isolated on plain white background for easy background removal, no ground shadow, --ar 9:16
```

**表情变体（在任一版本的基础提示词后追加，四版通用）：**

- 常态冷静：`, calm composed expression, steady gaze`
- 咬牙硬撑（喷血受创）：`, blood at the corner of mouth, pained grimace, staggering slightly, clothing slightly disheveled`
- 专注施法（起卦/结印/祈祷）：`, focused intense expression, hands forming a ritual gesture, faint glowing light around fingers`
- 力竭虚脱：`, exhausted pale expression, sweat on forehead, drained posture, eyes half-closed`

---

### 2. 紫苏（红衣女鬼）—— 凄美哀婉基调，避免恐怖化

**风格总则：** 紫苏的呈现方向是"凄美的、令人心疼的怨魂"，不是"狰狞恐怖的厉鬼"。血泪要处理得像精致的胭脂泪痕，不要溃烂、扭曲五官；红色服装要飘逸华美、剪裁现代，不要破烂血污；整体基调参考"都市夜色里的红衣孤魂"，而不是恐怖片女鬼。她生前是现代都市女性，衣着应带有当代时装感（例如剪裁利落的红色风衣或现代改良旗袍连衣裙），而非古装。

**基础提示词：**

```
An ethereal ghost woman in a flowing modern crimson coat or fitted red dress with contemporary tailoring, pale and beautiful face, long black hair drifting weightlessly as if underwater, two thin trails of red tears like delicate rouge lines down her cheeks, elegant sorrowful expression, hands folded gracefully, feet fading into mist instead of standing on ground, moonlit urban night atmosphere with faint city lights blurred in the background glow, tragic beauty aesthetic, modern ghost-beauty painting style, soft glowing outline, NOT grotesque, NOT horror-movie style, digital painting style, NOT a photograph, NOT photorealistic, solid pure white background (#FFFFFF), isolated on plain white background for easy background removal, no ground shadow, face turned slightly to the left, subtle three-quarter view towards left, --ar 9:16
```

**表情变体：**

- 初显（血泪·哀伤，非疯狂）：`, sorrowful despairing expression, eyes filled with deep grief rather than rage, faint red tear tracks, hair drifting gently in a windless room`
- 幻境中的平静圆满：`, serene gentle smile, soft warm lighting, holding a bowl of sweet soup, relaxed graceful posture, no tears, casual modern resort outfit`
- 识破谎言瞬间（震惊转冷）：`, expression shifting from shock to cold detachment, eyes wide then narrowing, faint blue-white light of shattering illusion around her`
- 结局对视（彻底的凉意）：`, quiet cold composed expression, no anger, distant melancholic gaze, faint sad smile`
- 消散离场（半透明）：`, translucent fading silhouette, dissolving into smoke-like wisps, only faint outline remains, soft desaturated colors`
- 闻声骤变（听到婉婉呼喊，身形骤然放大发亮）：`, sudden burst of radiant light engulfing her figure, body growing larger and taller as if surging with overwhelming spiritual energy, coat billowing violently outward, hair rising and glowing at the tips, intense bright white-gold aura mixed with crimson, awe-inspiring and sorrowful rather than menacing, tragic overwhelming grief transformed into radiant power, still beautiful and elegant despite the intensity, NOT grotesque, NOT monstrous, dynamic dramatic pose with arms slightly outstretched, digital painting style, NOT a photograph, NOT photorealistic, solid pure white background (#FFFFFF), isolated on plain white background for easy background removal, no ground shadow, --ar 9:16`

---

### 3. 婉婉（亡友）

**基础提示词：**

```
A gentle young Chinese woman in a soft pastel-colored modern casual outfit (knit sweater or simple dress), kind warm face, hair styled in a contemporary manner, translucent ghostly quality suggesting she is a memory or spirit fragment, soft blue-white glow around the edges, digital painting style, NOT a photograph, NOT photorealistic, solid pure white background (#FFFFFF), isolated on plain white background for easy background removal, no ground shadow, face turned slightly to the left, --ar 9:16
```

**表情变体：**

- 记忆闪回·温柔平静：`, warm gentle smile, soft nostalgic lighting, fully translucent memory-fragment quality`
- 残魂哭喊·恐惧警示：`, wide frightened eyes, mouth open mid-shout, faint blue flame flickering around hair strands, urgent desperate expression, semi-transparent with light distortion`

---

### 4. 林耀（三少爷 / 真凶）

**基础提示词：**

```
A well-dressed young Chinese heir in his late 20s, modern tailored suit or smart-casual designer outfit, expensive wristwatch, neatly styled hair, refined confident posture, full-body framing, from head to toe, standing full-length pose, digital painting style, NOT a photograph, NOT photorealistic, solid pure white background (#FFFFFF), isolated on plain white background for easy background removal, no ground shadow, face turned slightly to the left, --ar 9:16
```

**表情变体：**

- 表面温文尔雅：`, polite gentle smile, soft courteous expression, relaxed elegant posture`
- 真实残忍暴戾（幻境揭露）：`, cold cruel smirk, sharp cold eyes, subtle menacing shadow across face`
- 幻境重置后如常漫不经心：`, indifferent bored expression, casual dismissive posture, faint smug smile, phone loosely in hand`

---

### 5. 管家老严

**基础提示词：**

```
A thin Chinese household manager in his 50s, neatly combed gray hair, deep wrinkles around the eyes, modern formal black suit with a small earpiece, composed reserved posture, full-body framing, from head to toe, standing full-length pose, digital painting style, NOT a photograph, NOT photorealistic, solid pure white background (#FFFFFF), isolated on plain white background for easy background removal, no ground shadow, face turned slightly to the left, --ar 9:16
```

**表情变体：**

- 恭敬客套：`, polite respectful smile that does not reach the eyes, slightly bowed posture`
- 不动声色（隐瞒时）：`, neutral unreadable expression, still composed face, calculating eyes`
- 摊牌后的沉默松动：`, subtle crack in composure, tired resigned expression, eyes slightly downcast`

---

### 6. 老司机

**基础提示词：**

```
A middle-aged Chinese chauffeur, haggard tired face, dark circles under bloodshot eyes from chronic insomnia, modern black chauffeur uniform (white shirt, dark vest, no tie), full-body framing, from head to toe, standing full-length pose, digital painting style, NOT a photograph, NOT photorealistic, solid pure white background (#FFFFFF), isolated on plain white background for easy background removal, no ground shadow, face turned slightly to the left, --ar 9:16
```

**表情变体：**

- 抗拒防备：`, defensive wary expression, arms slightly crossed, avoiding eye contact`
- 崩溃憔悴：`, exhausted haunted expression, unkempt hair, slumped shoulders, uniform partly unbuttoned`
- 哭诉招供：`, tearful breaking-down expression, trembling hands, head lowered in guilt`

---

### 7. 女佣小翠

**基础提示词：**

```
A young Chinese domestic worker in a simple modern worn cotton jacket or plain uniform, thin frame, timid posture, full-body framing, from head to toe, standing full-length pose, digital painting style, NOT a photograph, NOT photorealistic, solid pure white background (#FFFFFF), isolated on plain white background for easy background removal, no ground shadow, face turned slightly to the left, --ar 9:16
```

**表情变体：**

- 惊恐防备：`, frightened wary expression, shrinking posture, clutching a paper cup of tea tightly`
- 信任后落泪：`, tearful relieved expression, eyes reddened, gently offering a small cloth-wrapped notebook`

---

### 8. 园丁老刘（可选立绘）

```
An elderly Chinese gardener in his 60s, weathered tan skin, simple modern work vest and gloves, holding garden shears, cautious watchful expression, full-body framing, from head to toe, standing full-length pose, digital painting style, NOT a photograph, NOT photorealistic, solid pure white background (#FFFFFF), isolated on plain white background for easy background removal, no ground shadow, face turned slightly to the left, --ar 9:16
```

表情变体：`, lowered voice recalling fear, glancing sideways nervously`

---

### 9. 古玩店老方（可选立绘）

```
An elderly Chinese antique shop owner, reading glasses pushed down his nose, calm unhurried demeanor, simple modern button-up shirt or cardigan, sitting posture implied, full-body framing, from head to toe, standing full-length pose, digital painting style, NOT a photograph, NOT photorealistic, solid pure white background (#FFFFFF), isolated on plain white background for easy background removal, no ground shadow, face turned slightly to the left, --ar 9:16
```

表情变体：`, gentle reminiscent expression` / `, soft sigh, wistful expression`

---

### 10. 婉婉的孩子（可选，幻境场景用）

```
A small Chinese child around four years old, simple modern soft-colored casual clothing, innocent joyful expression, running pose or standing pose, digital painting style, NOT a photograph, NOT photorealistic, solid pure white background (#FFFFFF), isolated on plain white background for easy background removal, no ground shadow, --ar 9:16
```

说明：多用于幻境南洋小镇场景中的背影或侧影，不需要精细五官特写。

---

### 11. 幻境·局外人（法师捏造的救场者，剪影处理）

```
A backlit silhouette of an ordinary young Chinese man in plain modern casual clothing (simple jacket, jeans), average build, nothing heroic or larger-than-life about his stature, indistinct facial features obscured by shadow and backlight, one hand raised and clearly wearing a metal knuckle duster, calm unremarkable stance despite the weapon, deliberately mundane and understated presence rather than dramatic, digital painting style, NOT a photograph, NOT photorealistic, solid pure white background (#FFFFFF), isolated on plain white background for easy background removal, no ground shadow, --ar 9:16
```

说明：故意不刻画正脸、不做高大英雄化的姿态，只是个普通年轻男人的剪影——他"不属于任何因果链"的神秘感恰恰来自这种毫不起眼，手上的指虎才是唯一能确认他"来者不善"的细节。

---

### 12. 幕后死士指使者（剪影/侧影处理）

```
A cold, hardened middle-aged Chinese man in profile silhouette, wearing a flat cap pulled low over his eyes, sharp angular jawline barely visible in the shadow, a chilling menacing aura, expensive but understated dark modern coat, face mostly obscured beneath the cap's brim with only a cold hint of expression showing, stern rigid posture radiating quiet threat, digital painting style, NOT a photograph, NOT photorealistic, solid pure white background (#FFFFFF), isolated on plain white background for easy background removal, no ground shadow, --ar 9:16
```

说明：鸭舌帽压得很低，只露出下颌线和一点冷硬的表情，不需要完整正脸——这种"看不清但压迫感很足"的处理，比露脸更适合他"藏在林家背后"的身份。


### 林太太（`lin_taitai_normal.png`）

依据原文"气度雍容的妇人"、说话"落座就没停"、笑意不达眼底这几处细节，设计成一位精明克制、外表和善内里算计的家族女主人：

```
Chinese digital illustration character portrait, an elegant wealthy woman in her late 50s,
refined and composed demeanor, neat updo hairstyle with a few streaks of grey,
wearing a tasteful deep jade-green silk blouse with subtle embroidery and a delicate pearl necklace,
faint polite smile that does not quite reach her eyes, calm and subtly calculating expression,
modern contemporary setting, half-body to knee-length framing,
face turned slightly to the left, subtle three-quarter view towards left,
solid pure white background (#FFFFFF), isolated on plain white background for easy background removal,
no ground shadow, NOT a photograph, NOT photorealistic, digital painting style,
detailed line art, soft cel shading --ar 2:3
```

如果之后想让她"紫苏很喜欢孩子"那句关键台词更有戏剧张力，可以再单独生成一张"别有深意的浅笑"表情差分，眼神稍微更锐利一点，其余描述保持不变即可，方便复用同一套服装设定。

### 孙秘书（需要两张：`sun_mishu_normal.png` + `sun_mishu_dream_twisted.png`）

他是幻境专属角色，需要撑住"体贴→狰狞"这一次反转，所以做成同一底子的两张表情差分，方便代码里用 `show expression` 直接切换：

**基础/温柔状态**

```
Chinese digital illustration character portrait, a young corporate secretary in his late 20s,
slender build, neat short hairstyle, wire-framed glasses, wearing a fitted dark navy suit with a plain tie,
gentle earnest expression with a warm shy smile, slightly nervous and caring demeanor,
modern contemporary office setting, half-body to knee-length framing,
face turned slightly to the left, subtle three-quarter view towards left,
solid pure white background (#FFFFFF), isolated on plain white background for easy background removal,
no ground shadow, NOT a photograph, NOT photorealistic, digital painting style,
detailed line art, soft cel shading --ar 2:3
```

**幻境黑化/狰狞状态**（同一人物，破防瞬间）

```
Chinese digital illustration character portrait, the same young corporate secretary as before,
now with a twisted cruel sneer, cold contemptuous eyes, tie loosened and collar slightly disheveled,
calculating and vicious expression, sudden menacing shift in demeanor,
modern contemporary setting, half-body to knee-length framing,
face turned slightly to the left, subtle three-quarter view towards left,
solid pure white background (#FFFFFF), isolated on plain white background for easy background removal,
no ground shadow, NOT a photograph, NOT photorealistic, digital painting style,
detailed line art, soft cel shading --ar 2:3
```

两组提示词的服装、发型描述特意保持一致（同一件西装、同一副眼镜），这样生成出来的两张图更容易被认成"同一个人的两种状态"，而不是两个长得像的不同角色。

---

## 二、背景美术提示词

统一追加：`no people, digital painting style, NOT a photograph, NOT photorealistic, --ar 16:9`

### 1. 林家宅邸外观（日间远景）

```
A grand modern luxury villa halfway up a lush green mountainside, white walls, large glass windows, and dark tiled roofing blending contemporary and traditional Chinese architecture, meandering driveway and manicured gardens, seen from below looking up, sunny daytime atmosphere, elegant but slightly imposing, no people, digital painting style, NOT a photograph, NOT photorealistic, --ar 16:9
```

### 2. 林家正厅——诡异停电版（第1-2拍核心场景）

```
Interior of a luxurious modern mansion's main living room, ornate crystal chandelier with cracks spreading across its glass, sleek modern furniture barely visible in the dark, sudden darkness with only faint moonlight from floor-to-ceiling windows, oppressive eerie atmosphere, cold blue-gray tones, no people, digital painting style, NOT a photograph, NOT photorealistic, --ar 16:9
```

### 3. 林家正厅——日常恢复版（结局对比用）

```
Same luxurious modern mansion's main living room, chandelier intact and glowing warmly, sunlight streaming through large windows, peaceful ordinary domestic atmosphere with modern furniture, warm tones, no people, digital painting style, NOT a photograph, NOT photorealistic, --ar 16:9
```

### 4. 半山旅馆房间 / 法坛

**基础版（道教）：**

```
A small simple modern budget hotel room on a mountainside, a wooden desk with a lamp, later cluttered with a makeshift talisman altar, incense burner, and scattered talisman papers next to a laptop and phone charger, dim warm lighting, humble but focused workspace atmosphere, no people, digital painting style, NOT a photograph, NOT photorealistic, --ar 16:9
```

**佛教版：**

```
A small simple modern budget hotel room on a mountainside, converted into a makeshift Buddhist shrine — a small brass Buddha statue on the desk, a coiled incense burner with thin smoke rising, strings of wooden prayer beads, a folded saffron-colored cloth, a worn sutra scroll or booklet, candles flanking the statue, warm golden dim lighting, serene yet solemn atmosphere, no people, digital painting style, NOT a photograph, NOT photorealistic, --ar 16:9
```

**出马仙版（东北民俗仙家信仰）：**

```
A small simple modern budget hotel room on a mountainside, converted into a rustic folk shamanic shrine typical of Northeastern Chinese "Chuma Xian" fox-spirit worship — a red cloth draped over a makeshift altar, small wooden spirit tablets, a fox-shaped or weasel-shaped carved figurine, offerings of fruit and rice wine in small bowls, thick red candles burning unevenly, a rough hand-painted talisman scroll pinned to the wall, earthy folk-superstition atmosphere distinct from formal Taoist ritual, dim flickering candlelight, no people, digital painting style, NOT a photograph, NOT photorealistic, --ar 16:9
```

**教会版：**

```
A small simple modern budget hotel room on a mountainside, converted into a modest makeshift Christian prayer space — a plain wooden cross propped against the wall, a worn leather-bound Bible open on the desk, a rosary draped over the lamp, a small bottle of holy water, a few white candles, minimalist and quiet devotional atmosphere, soft cool-toned lighting, no people, digital painting style, NOT a photograph, NOT photorealistic, --ar 16:9
```

### 5. 林家围墙外小路

```
A quiet mountain path outside a modern villa's stone wall, neatly trimmed hedges, morning mist, tranquil suburban greenery, no people, digital painting style, NOT a photograph, NOT photorealistic, --ar 16:9
```

### 6. 寒山茶室

```
A dim cozy modern Chinese teahouse interior, worn wooden tables, a faded neon or painted signboard visible through the doorway, dusty afternoon light filtering in, quiet melancholic atmosphere, no people, digital painting style, NOT a photograph, NOT photorealistic, --ar 16:9
```

### 7. 古玩店

```
A cluttered modern antique shop interior, densely packed shelves with porcelain vases, silk boxes, scroll paintings, a small cash register on the counter, dust particles visible in slanted sunlight, warm sepia tones, nostalgic quiet atmosphere, no people, digital painting style, NOT a photograph, NOT photorealistic, --ar 16:9
```

### 8. 老司机山腰小屋

```
A cramped disheveled small staff room on a hillside, empty liquor bottles on a table, a messily rolled blanket on the bed, muddy shoes in the corner, a dim bare lightbulb, an old television in the corner, oppressive claustrophobic atmosphere, no people, digital painting style, NOT a photograph, NOT photorealistic, --ar 16:9
```

### 9. 后山枯井

```
An abandoned well on a dark hillside behind a villa, rusted iron cover slightly askew, overgrown weeds around the stone rim, ominous night atmosphere, cold moonlight, no people, digital painting style, NOT a photograph, NOT photorealistic, --ar 16:9
```

### 10. 幻境·婚仪红绸 / 偏院走廊（绝路一）

```
Split mood scene: festive red silk wedding decor and scattered celebration confetti in a modern banquet hall on one side, transitioning into a cold locked courtyard corridor with a shut door on the other, contrast between celebration and isolation, dreamlike illusion quality, no people, digital painting style, NOT a photograph, NOT photorealistic, --ar 16:9
```

### 11. 幻境·新房喜酒（绝路二）

```
A modern wedding suite interior, red decorative lighting glowing, a wine glass on a table with liquid slightly too dark in color, subtle unsettling undertone beneath festive decor, no people, digital painting style, NOT a photograph, NOT photorealistic, --ar 16:9
```

### 12. 幻境·山路夜车与大火（绝路三）

```
A mountain road at night with a stopped modern black sedan, a fallen tree or roadblock blocking the path, distant flames casting a red glow onto the car window, dramatic dangerous atmosphere, no people, digital painting style, NOT a photograph, NOT photorealistic, --ar 16:9
```

### 13. 幻境·雷雨夜正厅（局外人斩杀林耀）

```
A grand modern living room interior during a thunderstorm night, glass doors blown open by wind, lights flickering off and on, dramatic strobing light, tense confrontational atmosphere, no people, digital painting style, NOT a photograph, NOT photorealistic, --ar 16:9
```

### 14. 幻境·南洋小镇（假圆满结局）

```
A warm humid Southeast Asian coastal town, coconut palm trees casting shadows in a courtyard, a modern ferry or cruise ship deck with ocean breeze in the background, golden afternoon sunlight, peaceful idyllic atmosphere, no people, digital painting style, NOT a photograph, NOT photorealistic, --ar 16:9
```

### 15. 往生门

```
An ancient minimalist doorway floating at the edge of a dreamlike void, gentle non-blinding light glowing from behind the door, inviting yet mysterious atmosphere, soft ethereal color palette, no people, digital painting style, NOT a photograph, NOT photorealistic, --ar 16:9
```

### 16. 库房（地下室·新锁贴符）

```
A dim modern basement storage room door, a newly installed digital or heavy metal lock with fresh scratch marks, four talisman papers with fresh dark ink sealed at each corner of the doorframe, faint ominous energy implied through subtle color distortion around the seals, no people, digital painting style, NOT a photograph, NOT photorealistic, --ar 16:9
```

### 17. 分屏结局背景（报警支线专用，需拼接为一张分屏图）

**左半——警局门口（日间，台式风格）：**

```
Exterior entrance of a modern police station with Taiwanese-style architecture — pastel-toned facade, clean modern signage reading "西京市公安局" in bold Chinese characters above the glass front doors, bright daytime sunlight casting long shadows on the entrance steps, a police officer's silhouette visible behind a side window, hunched and furtive posture, phone held up to his ear mid-conversation, glancing around nervously as if trying not to be seen, shifty and suspicious body language contrasting with the bright calm exterior, no other people, digital painting style, NOT a photograph, NOT photorealistic, --ar 9:16
```

**右半——林家书房暗处（同一时刻）：**

```
A dim modern study room interior at night, single desk lamp casting shadows over a laptop and bookshelves, a half-open door suggesting someone just entered, tense secretive atmosphere, no people, digital painting style, NOT a photograph, NOT photorealistic, --ar 9:16
```

管家办公室
A wealthy household manager's private office inside a luxurious modern Chinese mansion, dark wood-paneled walls, a heavy antique desk with neatly stacked ledgers and an old-fashioned rotary phone, a single green-shaded banker's lamp casting a warm pool of light against otherwise dim, shadowy corners, tall curtained windows with the curtains drawn, a wall safe partially hidden behind a landscape scroll painting, oppressive and secretive atmosphere, no people, empty room, digital painting style, NOT a photograph, NOT photorealistic, moody cinematic lighting, --ar 16:9


拼接说明：两张分别以 9:16 竖版生成后左右拼接成一张 16:9 分屏图，中缝可用一条细窄的渐变过渡处理，避免生硬对接线过于突兀。

---

## 三、使用提醒

- 所有立绘生成后，请确认背景确实是纯白色（`#FFFFFF`）且没有渐变、阴影残留或颜色噪点，否则抠图时容易在边缘留白边或误抠。若角色服装本身有白色/浅色部分（例如小翠的浅色衣领、老方的浅色衬衫），抠图前建议先用色阶/魔术棒工具局部检查，避免把服装误判为背景一并抠掉。
- 紫苏的立绘请重点把关：若生成结果偏向"惊悚厉鬼"而非"哀婉美人"，可以在提示词中追加 `graceful, mournful beauty, NOT scary, NOT grotesque, soft melancholic elegance` 等强化词，并适当降低"血泪""怨气"相关词汇的比重。
- 若生成工具把角色画成古装（尤其是紫苏、林耀），可以在提示词开头追加 `contemporary modern setting, NOT traditional Chinese period clothing, NOT ancient costume` 来强制纠偏。
- 同一角色的不同表情变体，建议使用同一批次、同一 `--ar` 参数连续生成，避免不同表情之间比例不一致。

**四位师父立绘（半身到及膝，白底）**

统一底层设定：`solid pure white background (#FFFFFF), isolated on plain white background for easy background removal, no ground shadow, half-body to knee-length framing, NOT a photograph, NOT photorealistic, digital painting style, face turned slightly to the left, subtle three-quarter view towards left --ar 2:3`

- 玄机（道士一脉）：  
    `Elderly Chinese Daoist master, long grey-white beard, hair tied in a traditional topknot secured with a wooden hairpin, wearing a dark ink-blue traditional Daoist robe embroidered with faint cloud and bagua patterns, holding a wooden token in one hand, weathered face with sharp piercing eyes suggesting deep cultivation, calm and composed expression, [统一底层设定]`
- 净尘（和尚一脉）：  
    `Elderly Chinese Buddhist monk, shaved head, wearing a traditional grey and saffron monk robe (kasaya), a string of wooden prayer beads wrapped around one wrist, kind weathered face with a serene compassionate expression, hands folded together, [统一底层设定]`
- 青崖（出马仙一脉）：  
    `Middle-aged Northeastern Chinese folk shaman (出马仙/仙家传人), wearing a dark red and black traditional ceremonial robe with folk embroidery patterns, holding a round hand-held spirit drum (神鼓) with red tassels, weathered intense face with sharp watchful eyes, an aura of folk mysticism, [统一底层设定]`
- 安东尼神父（驱魔师一脉）：  
    `Elderly Catholic priest, wearing a black cassock with a white clerical collar, a silver crucifix pendant visible on his chest, holding a worn leather-bound Bible in one hand, kind but resolute weathered face, calm authoritative expression, [统一底层设定]`

雷雨夜的别墅
A  mansion with white walls and black tile roof (白墙黛瓦), built against a mountainside, dense green trees surrounding the estate, viewed from a wide low angle showing the full building and courtyard, heavy dark storm clouds gathering low and oppressive directly above the mansion, thick roiling grey-black clouds pressing down, a faint eerie greenish-grey tint in the air, dim ambient light with no sun visible, distant city skyline barely visible below the mountain in the background, ominous ominous foreboding atmosphere, no people, digital painting style, cinematic wide establishing shot, highly detailed environment art --ar 16:9