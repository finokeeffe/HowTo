# How to Create a GitHub Repo and Upload Your Project Files (HowTo)

This guide is for the documentation repo used to support technical setup and workflows.

Repository:
https://github.com/finokeeffe/HowTo

---

# 1. Purpose

This repo is used for:
- technical notes
- setup instructions
- Git workflow documentation
- learning resources

---

# 2. Prerequisites

## Install Git
Git is required for command line usage.

Download:
https://git-scm.com/downloads

Check:
```bash
git --version
Optional tools
GitHub Desktop: https://desktop.github.com/
VS Code: https://code.visualstudio.com/
3. Local Folder Location

This repo is stored here:

c:\pgs\dev\repos\Fin\HowTo
Navigate to folder (Command Line)
cd c:\pgs\dev\repos\Fin\HowTo
4. Clone Repository
git clone https://github.com/finokeeffe/HowTo.git
cd c:\pgs\dev\repos\Fin\HowTo
GitHub Desktop
Clone repository
Set location:
c:\pgs\dev\repos\Fin\HowTo
5. Add Files

Drag files into:

c:\pgs\dev\repos\Fin\HowTo

Make sure .gitignore is included.

6. Stage Changes
git add .

VS Code:

Source Control → “Stage All”

GitHub Desktop:

automatic
7. Commit
git commit -m "Initial commit"
8. Push
git push origin main
9. .gitignore

If needed:

git rm -r --cached .
git add .
git commit -m "Fix gitignore"
Summary
Documentation repo for learning + workflows
Safe place for Git instructions

---

---

# 📄 FILE 2 — AstralAnomalies (Game Repo)

```md
# Astral Anomalies — GitHub Project Setup Guide

⚠️ IMPORTANT:
This repository is sensitive to build artifacts and must NOT include generated engine files.

Repository:
https://github.com/finokeeffe/AstralAnomalies

---

# 1. Purpose

This repo contains:
- game source files
- assets
- scripts
- engine project structure

DO NOT commit:
- build folders
- cache folders
- temporary engine files

---

# 2. Prerequisites

## Install Git
https://git-scm.com/downloads

Check:
```bash
git --version
Optional tools
GitHub Desktop: https://desktop.github.com/
VS Code: https://code.visualstudio.com/
3. Local Folder Location
c:\pgs\dev\repos\Fin\AstralAnomalies
Navigate to folder
cd c:\pgs\dev\repos\Fin\AstralAnomalies
4. Clone Repository
git clone https://github.com/finokeeffe/AstralAnomalies.git
cd c:\pgs\dev\repos\Fin\AstralAnomalies
GitHub Desktop
Clone repository
Set location:
c:\pgs\dev\repos\Fin\AstralAnomalies
5. .gitignore (CRITICAL)

This project must exclude:

build output
engine cache
temporary/generated folders

Only commit:

source code
assets
configuration files
6. Stage Changes
git add .

VS Code:

Source Control → Stage All

GitHub Desktop:

automatic
7. Commit
git commit -m "Initial commit"
8. Push
git push origin main
9. Fix if wrong files were added
git rm -r --cached .
git add .
git commit -m "Fix gitignore"
Summary
Game repo must be carefully managed
Avoid committing generated files
GitHub Desktop is safer for beginners but still uses Git underneath

---

If you want next upgrade, I can:
- :contentReference[oaicite:0]{index=0}
- or :contentReference[oaicite:1]{index=1}