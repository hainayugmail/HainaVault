

🔴 Priority 1 — Core Mechanic (Fix First)

1. Fix beetle push collider — Replace Mesh Collider with Capsule Collider on beetle body, verify push input restores ball movement
2. Slope physics — Detect ground normal via Raycast, apply gravity component along slope to ball (accelerate downhill, resist uphill)
3. Beetle + ball speed coupling — Push force adds to/subtracts from slope-modified speed, not independent of it
4. Ball size progression — Every 1/3 collection threshold triggers scale increase, mass increases proportionally so control gets harder
5. Uphill crush mechanic — If ball rolls back and velocity exceeds threshold, trigger beetle death/stun

🟡 Priority 2 — Feel & Feedback

1. Growth VFX — Replace current effect with burst particle + screen shake on size increase
2. Ball weight feel — Increase drag and angular drag as ball grows, so steering becomes sluggish
3. Downhill chase tension — Add camera lag/zoom out slightly when ball exceeds beetle speed threshold
4. Beetle animation states — Idle / pushing / running / crushed

🟠 Priority 3 — Environment

1. Terrain normals — Ensure beetle and ball tilt to match ground surface normal
2. HDRI skybox — Replace default lighting with warm African savanna HDRI
3. Grass and foliage — Use Unity terrain grass tools with wind zone, not static meshes
4. Path dressing — Dirt track texture with normal map, tyre/ball trail marks

🟢 Priority 4 — Season & Weather System

1. Season manager — Timer-based state machine: Spring → Summer → Autumn → Winter, cycle every 15 minutes
2. Winter snow — Particle system + terrain shader blend to white
3. Summer rain — Particle system + puddle shader on ground
4. Spring/Autumn wind — Wind Zone component affecting grass and particles
5. Foliage color swap — Swap tree/grass material colors per season (green → orange → white → green)

⚪ Priority 5 — Polish

1. Beetle model upgrade — Source cartoon beetle from Sketchfab/Asset Store with rig and walk animation
2. Ball texture — Procedural or hand-painted dirt/dung texture with normal map bump detail
3. UI polish — Size indicator, speed gauge, season indicator

Start with task 1 — paste your push code and I’ll fix it directly.