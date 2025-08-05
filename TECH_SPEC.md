**Technical Specification for New Adam: The Sentient Robot**

---

## 📁 Overview
This document outlines the **technical architecture, components, tools, and milestones** required to build the first working prototype of "New Adam" — a virtual being with simulated perception, memory, emotion, and learning within a fully interactive 3D environment.

---

## 🏗️ Architecture Summary

### 1. 3D Engine Layer (Visual World)
- **Engine:** Unity (C#) or Unreal Engine 5 (Blueprints + C++)
- **Scene:** One room (Prototype)
  - Lighting system
  - Audio zones / speakers
  - Interactive objects (e.g., cube, fan, food plate, door)
  - Temperature zones (e.g., heater corner, cold wall)

### 2. AI Layer (Mind of New Adam)
- **Model:** LLM (Open-source e.g., LLaMA 3, Mistral 7B, or GPT-4 local proxy)
- **Host:** Local GPU server or cloud (Hugging Face Spaces, Replicate, etc.)
- **Interaction:** WebSocket or REST API
- **Memory Management:**
  - Vector DB (Weaviate / Milvus)
  - Short-term (last N events)
  - Long-term (semantic memory)

### 3. Sensory Simulation Layer
- **Vision:** Raycasting + camera snapshot from Unity
- **Sound:** Spatial audio engine (Unity Audio Mixer / FMOD)
- **Touch:** Collider feedback
- **Smell/Taste:** Placeholder tags mapped to objects (e.g., `apple -> sweet`, `garbage -> foul`)

### 4. Brain & Behavior Layer
- **Framework:** Node.js / Python (FastAPI)
- **Learning:**
  - Reinforcement Learning (optional)
  - Behavior Tree + Symbolic logic
- **State Manager:**
  - Keeps internal state (e.g., curiosity, fear, comfort)
  - Decides next action based on input + memory

### 5. UI + Observation
- **VR/Screen Mode:** Observer sees New Adam's world
- **Chat Interface:** Optional text view of inner thoughts
- **Debug Panel:** Show sensory inputs, memory highlights, decisions

---

## 🔁 Data Flow Example

```
[Unity Scene] ---> [Camera Snapshot + Audio + Touch Event] ---> [API Server (Python/Node)] ---> [LLM Decision Engine] ---> [Memory Update + Action Chosen] ---> [Unity Animation / Movement / Dialog]
```

---

## 🧪 Milestone Checklist

### ✅ Phase 1: Minimal Viable Prototype
- [ ] Unity scene with camera & 3D room
- [ ] Raycasting to detect object
- [ ] Send frame data to LLM
- [ ] Response from LLM: name object, describe surroundings

### ⏩ Phase 2: Sensory Reactions
- [ ] Sound Zones + Object manipulation
- [ ] AI chooses action (e.g., "touch", "walk to X")
- [ ] Reactions stored to memory

### 🔁 Phase 3: Feedback Loop
- [ ] AI adapts to past events
- [ ] Adds emotional state to decisions

---

## 📦 Tools & Dependencies

- **Unity / Unreal**
- **Python** / Node.js
- **LLM (Ollama / OpenRouter / HF Transformers)**
- **Vector DB**: Weaviate, Qdrant, Milvus
- **API Layer**: FastAPI / Express.js

---

## 🔐 Contribution Guide
- Fork the repo
- Add module in `/modules/` or `/world/`
- Describe functionality in PR

---

## 🧠 Final Note
This document is live. Updates will evolve as the prototype matures.  
Join us in building a new form of intelligence.
