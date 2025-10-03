# ❄️ CramponFix (The Long Dark Bug Fix)

A lightweight mod for The Long Dark that **fixes long-standing bugs** related to the stat application for both **Improvised Crampons** and **Crampons**. This mod ensures both items apply their **intended** stat bonuses to the player.

### 🐛 The Bugs Fixed

The base game (as of TLD v2.44) currently applies incorrect stat reductions. This mod corrects them to the presumed vanilla values:

| Item | Stat | Bugged Value (What the game *applies*) | **Intended Value** (What the mod *corrects* it to) |
| :--- | :--- | :--- | :--- |
| **Improvised Crampons** | Sprain Chance | $\mathbf{70\%}$ Reduction ($\mathbf{30}$ Value) | $\mathbf{30\%}$ Reduction ($\mathbf{70}$ Value) |
| **Improvised Crampons** | Stamina Drain | $\mathbf{60\%}$ Reduction ($\mathbf{40}$ Value) | $\mathbf{40\%}$ Reduction ($\mathbf{60}$ Value) |
| **Crampons** | Sprain Chance | $\mathbf{50\%}$ Reduction ($\mathbf{50}$ Value) | $\mathbf{50\%}$ Reduction ($\mathbf{50}$ Value) |
| **Crampons** | Stamina Drain | $\mathbf{40\%}$ Reduction ($\mathbf{60}$ Value) | $\mathbf{60\%}$ Reduction ($\mathbf{40}$ Value) |

### ✨ Summary of Corrected Stats

The mod ensures the following correct, intended values are applied:

| Item | Sprain Roll Odds Modifier ($\downarrow$ is Better) | Stamina Per Second Modifier ($\downarrow$ is Better) |
| :--- | :--- | :--- |
| **Improvised Crampons** | $\mathbf{70}$ (30% Sprain Reduction) | $\mathbf{60}$ (40% Stamina Reduction) |
| **Crampons** | $\mathbf{50}$ (50% Sprain Reduction) | $\mathbf{40}$ (60% Stamina Reduction) |

> **Note:** These numbers represent the percentage of the original value that remains. For example, a Stamina Modifier of $\mathbf{40}$ means $40\%$ of the original stamina drain remains, which is a $\mathbf{60\%}$ reduction.

### 🛠️ Installation

This mod requires **MelonLoader** to run.

For detailed instructions on how to install mods for The Long Dark (including installing MelonLoader), please refer to the comprehensive guide:

**[The Long Dark Modlist - How to install mods for The Long Dark (TLD)](https://tldmods.com/install.html)**

Once you have MelonLoader installed:
1.  Download the **`CramponFix.dll`** file from the [latest release page](LINK_TO_YOUR_GITHUB_RELEASES).
2.  Place the **`CramponFix.dll`** file into the **`Mods`** folder in your TLD installation directory.
3.  Launch the game!

### 📄 License

This project is licensed under the MIT License.