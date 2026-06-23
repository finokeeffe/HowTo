# How to Connect a Unity Project to a GitHub Repository

## Recommended Method (Clone with GitHub Desktop First)

This method gives you full control over where the repository is stored.

### Why We Recommend This

If you clone through Unity Hub, Unity Hub automatically places the repository inside your user profile, for example:

```text
C:\Users\William\AstralAnomalies
```

This can quickly become messy if you prefer to keep all repositories in a dedicated location such as:

```text
C:\Repos
```

Using GitHub Desktop first allows you to choose the exact folder location.

---

## Method 1: Clone with GitHub Desktop (Recommended)

### Step 1 - Clone the Repository

1. Open **GitHub Desktop**.
2. Click **File**.
3. Click **Clone Repository...**
4. Select the repository.
5. In **Local Path**, choose where you want the project stored.

Example:

```text
C:\Repos\AstralAnomalies
```

6. Click **Clone**.

---

### Step 2 - Open the Project in Unity Hub

1. Open **Unity Hub**.
2. Click **Add**.
3. Click **Add Project from Disk**.
4. Browse to your cloned repository folder.
5. Select the folder that contains:

```text
Assets
Packages
ProjectSettings
```

6. Click **Open**.
7. Unity Hub will now list the project.
8. Click the project to open it.

---

### Result

Your repository stays neatly organised:

```text
C:\Repos
└── AstralAnomalies
```

and Unity Hub simply points to that location.

---

## Method 2: Clone Through Unity Hub

### Step 1 - Clone the Repository

1. Open **Unity Hub**.
2. Click **Projects**.
3. Click **Add**.
4. Click **Add project from repository**.
5. Paste the GitHub repository URL.
6. Click **Clone**.

---

### What Happens

Unity Hub automatically clones the repository into your user profile.

Example:

```text
C:\Users\William\AstralAnomalies
```

---

### Pitfall

You cannot easily choose a custom repository location during the clone process.

This means your repositories may end up scattered under your user profile instead of being stored in a dedicated repository folder.

Example:

```text
C:\Users\William\Project1
C:\Users\William\Project2
C:\Users\William\Project3
```

instead of:

```text
C:\Repos\Project1
C:\Repos\Project2
C:\Repos\Project3
```

---

## Comparison

| Method                     | Choose Clone Location? | Recommended?                       |
| -------------------------- | ---------------------- | ---------------------------------- |
| GitHub Desktop → Unity Hub | ✅ Yes                  | ✅ Yes                              |
| Unity Hub Clone            | ❌ No                   | ⚠️ Only if location doesn't matter |

---

## Quick Flowchart

```mermaid
flowchart TD

    A[Need Unity Project] --> B{How will you clone?}

    B --> C[GitHub Desktop]
    B --> D[Unity Hub]

    C --> E[Choose custom folder e.g. C:\Repos\AstralAnomalies]
    E --> F[Open Unity Hub]
    F --> G[Add Project from Disk]
    G --> H[Select cloned folder]
    H --> I[Open Project]

    D --> J[Add Project from Repository]
    J --> K[Unity Hub Clones Repo]
    K --> L[Repo Stored Under User Profile]
    L --> M[C:\Users\Username\ProjectName]

    I --> N[Project Ready]
    M --> N
```

## Recommendation

For team projects, always:

1. Clone using **GitHub Desktop**.
2. Store repositories in a dedicated folder such as:

```text
C:\Repos
```

3. Use **Unity Hub → Add Project from Disk** to open the project.

This keeps all repositories organised and avoids Unity Hub's default cloning location.
