# Flappy Bird Game Setup Instructions

Here is a step-by-step guide to set up your Flappy Bird game in the Unity Editor.

### Scripts Created:

1.  **`FlappyBird.cs`**: Attached to the player object. It handles jumping when the player presses the space key or clicks the mouse. It also calls the `GameOver` method in the `GameManager` when it collides with something.
2.  **`GameManager.cs`**: A singleton that manages the game's state, including score and lives. It has methods for adding points, losing a life, and ending the game.
3.  **`PipeSpawner.cs`**: Spawns pipe prefabs at a regular interval. You can adjust the `spawnRate` and `heightOffset` in the inspector.
4.  **`PipeMovement.cs`**: Attached to the pipe prefabs. It moves the pipes to the left at a constant speed.
5.  **`UIManager.cs`**: A singleton that updates the UI with the current score and lives.
6.  **`ScoreTrigger.cs`**: This script should be attached to a trigger collider placed between the pipes. When the player passes through it, it adds a point to the score.

### How to set up your scene in Unity:

**1. Bird:**
*   Create a `Sprite` for your bird and add it to the scene.
*   Add a `Rigidbody2D` component for physics.
*   Add a `CircleCollider2D` component.
*   Attach the `FlappyBird.cs` script to it.
*   Set the tag of the bird object to "Player".

**2. Pipes:**
*   Create a prefab for your pipes. A simple way is to have an empty `GameObject` as the parent with two `Sprite` children for the top and bottom pipes.
*   Add `BoxCollider2D` components to the top and bottom pipe sprites.
*   Attach the `PipeMovement.cs` script to the parent `GameObject` of the pipe prefab.
*   Add another `BoxCollider2D` to the parent `GameObject`, resize it to cover the gap between the pipes, and check **"Is Trigger"**.
*   Attach the `ScoreTrigger.cs` script to this trigger `GameObject`.

**3. Pipe Spawner:**
*   Create an empty `GameObject` in your scene and name it "Pipe Spawner".
*   Attach the `PipeSpawner.cs` script to it.
*   Drag your pipe prefab from the Project view to the `Pipe Prefab` field in the `PipeSpawner` component in the Inspector.

**4. GameManager:**
*   Create an empty `GameObject` and name it "GameManager".
*   Attach the `GameManager.cs` script to it.

**5. UI:**
*   Right-click in the Hierarchy and go to `UI -> Canvas` to create a UI canvas.
*   Inside the Canvas, create two `UI -> Text` objects. Name one "ScoreText" and the other "LivesText".
*   Create an empty `GameObject`, name it "UIManager", and attach the `UIManager.cs` script.
*   In the `UIManager` component, drag the "ScoreText" object to the `Score Text` field and the "LivesText" object to the `Lives Text` field.

Now you should have a basic but functional Flappy Bird game. You can tweak the public variables in the inspector to adjust the difficulty and feel of the game.
