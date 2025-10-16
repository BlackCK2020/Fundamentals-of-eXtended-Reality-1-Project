# Dinosaur Skeleton Museum – Unity Project

## Team Members
- **[Zhang Peiwen]** – Environment design & lighting setup  
- **[Tang Bill]** – Audio implementation & UI development  
- **[Cossard Keryan]** – 3D model research & dinosaur interaction system

---

## Project Description
This project is a **virtual museum** developed in **Unity**, showcasing interactive **dinosaur skeleton**.  
Users can explore the environment, interact with buttons, and experience dynamic features such as lighting effects, background music, and realistic animations.

---

## Features Implemented
-  **Interactive Dinosaur Skeleton** – A button triggers gravity on the skeleton, causing each bone to fall naturally using Unity’s physics system.  
-  **Light Activation Button** – Allows users to turn exhibit lights on or off, enhancing the visual atmosphere.  
-  **Background Music** – Ambient sound adds immersion to the museum experience.  
-  **Museum Environment** – A detailed 3D environment simulating a realistic exhibition space.  

---

## Mechanism of the Application
1. **User Interface (UI):**  
   - The scene contains multiple interactive buttons:
     - *Light Button* → toggles the main lighting in the scene.  
     - *Gravity Button* → activates physics on the dinosaur skeleton, making bones fall.  

2. **Physics System:**  
   - Each dinosaur bone has a **Rigidbody** and **MeshCollider** component.  
   - When gravity is enabled, Unity’s physics engine simulates realistic bone movement this allows the dinosaur's bones fall down.  

3. **3D Models:**  
   - Museum environment and dinosaur skeletons were sourced from online 3D models.  

