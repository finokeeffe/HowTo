# 🚀 Git Fundamentals – Quick Cheat Sheet

## 📌 What is Git & Why is it used?

Git is a version control system that tracks changes in code over time.

### Why developers use it:
- Keeps history of changes
- Lets multiple people work together
- Allows rollback to previous versions
- Manages different features safely

---

## 🧠 Core Idea (Visual Flow)

```mermaid
flowchart TD
A[Write Code] --> B[Stage Changes]
B --> C[Commit Snapshot]
C --> D[Push to Remote Repo]
D --> E[Shared with Team]
```

---

## 📁 What is a Repository (Repo)?

A repo is a project folder tracked by Git.

It contains:
- Code files
- History of changes
- Branches
- Settings

```mermaid
flowchart LR
R[Repository] --> C1[Code Files]
R --> H[History]
R --> B[Branches]
R --> S[Settings]
```

---

## 🌿 What is `main`?

`main` is the default branch of a repo.

- Stable version of the project
- Usually production-ready code
- Updated after review/testing

```mermaid
gitGraph
   commit
   commit
   branch feature
   checkout feature
   commit
   commit
   checkout main
   merge feature
   commit
```

---

## 🌱 What are branches?

Branches are separate copies of your project for working safely.

### Why use them:
- Work on features without breaking main
- Multiple people work in parallel
- Easy experimentation

```mermaid
gitGraph
   commit
   branch feature-login
   checkout feature-login
   commit
   commit
   checkout main
   commit
```

---

## 🧾 How to commit code (VS Code + CLI)

### Flow:

```mermaid
flowchart TD
A[Edit Files] --> B[git status]
B --> C[git add .]
C --> D[git commit -m message]
D --> E[git push origin main]
```

### Commands:

```bash
git status        # check changes
git add .         # stage changes
git commit -m "message"   # save snapshot
git push origin main      # upload to GitHub
```

---

## 🧑‍💻 VS Code flow

```mermaid
flowchart LR
A[Edit Code] --> B[Source Control]
B --> C[Stage Changes +]
C --> D[Write Commit Message]
D --> E[Commit]
E --> F[Push]
```

---

## 🔥 Summary

- Git = version tracking system
- Repo = project storage
- main = stable branch
- branch = safe workspace
- commit = saved change snapshot
```
