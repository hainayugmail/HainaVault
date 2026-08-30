**Layer 4: Ren'Py Script**(可运行层)

```renpy
label chapter9_beat3_letter:
    scene bg yushufang
    show changan normal at truecenter

    "案头那盏宫灯的光斜斜切过一角信纸……"
    "\"穆皇后\"三个字底下压着一个\"废\"字，墨迹还新。"

    menu:
        "看清楚内容" if personality_score["实用主义者"] >= personality_score["理想主义者"]:
            $ inner_demon_value += 1
            $ persona_action_log.append("看信_实用")
            jump beat3_read_letter

        "犹豫要不要看" if personality_score["理想主义者"] > 0:
            $ dowager_alert_value += 0  # 犹豫不产生额外警觉
            jump beat3_hesitate

        "假装没看见":
            $ dowager_alert_value += 1
            jump beat3_ignore

label beat3_read_letter:
    show yuanhuai normal at truecenter with dissolve
    "帝心值" (emperor_favor -= 2)
    $ flag_hid_letter = True
    jump chapter9_beat4
```

这一层只关心"能不能跑、变量对不对、分支跳转有没有漏",完全不需要文学性——甚至可以让台词先占位("案头那盏宫灯的光斜斜切过……")直接从 prose 复制过来,重点是变量赋值和 menu 分支的逻辑正确。
