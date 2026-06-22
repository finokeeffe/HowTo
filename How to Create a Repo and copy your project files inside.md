# GitHub Repo Setup Guide (Two Projects: HowTo + AstralAnomalies)

This document explains how to set up and upload two repositories using:
- Command Line (Git)
- GitHub Desktop (GUI)
- VS Code (optional)

GitHub Desktop and VS Code are just visual layers — they still run Git commands underneath.

---

# 1. Install Requirements

## Install Git (required for command line)
Git is the system that tracks changes in your project.

Download:
https://git-scm.com/downloads

Check installation:
git --version

---

## Optional tools
- GitHub Desktop: https://desktop.github.com/
- VS Code: https://code.visualstudio.com/

---

# 2. GitHub Repositories

You are working with two repositories:

## Documentation repo
https://github.com/finokeeffe/HowTo

Local path:
c:\pgs\dev\repos\Fin\HowTo

---

## Game repo (sensitive build system)
https://github.com/finokeeffe/AstralAnomalies

Local path:
c:\pgs\dev\repos\Fin\AstralAnomalies

IMPORTANT:
AstralAnomalies must NEVER include build or engine-generated files.

---

# 3. Navigate to Local Folder (Command Line)

Open Command Prompt / PowerShell.

HowTo:
cd c:\pgs\dev\repos\Fin\HowTo

AstralAnomalies:
cd c:\pgs\dev\repos\Fin\AstralAnomalies

Useful commands:
dir   (list files)
cd .. (go back folder)

---

# 4. Clone Repositories

## Command Line

HowTo:
git clone https://github.com/finokeeffe/HowTo.git
cd c:\pgs\dev\repos\Fin\HowTo

AstralAnomalies:
git clone https://github.com/finokeeffe/AstralAnomalies.git
cd c:\pgs\dev\repos\Fin\AstralAnomalies

---

## GitHub Desktop

1. Open GitHub Desktop
2. Click "Clone Repository"
3. Paste repo URL
4. Choose correct folder:

HowTo:
c:\pgs\dev\repos\Fin\HowTo

AstralAnomalies:
c:\pgs\dev\repos\Fin\AstralAnomalies

---

# 5. Add Project Files

Place files into the correct folder:

HowTo:
c:\pgs\dev\repos\Fin\HowTo

AstralAnomalies:
c:\pgs\dev\repos\Fin\AstralAnomalies

IMPORTANT:
Make sure .gitignore is present in both repositories.

For AstralAnomalies:
DO NOT include:
- build folders
- cache folders
- engine-generated files
- temporary files

Only include:
- source code
- assets
- configuration files

---

# 6. Stage Files (Prepare commit)

Staging = selecting what will be saved.

Command Line:
git add .

VS Code:
- Click Source Control icon
- Click "Stage All Changes"

GitHub Desktop:
- Automatic staging (no manual step)

---

# 7. Commit Changes

Command Line:
git commit -m "Initial commit"

VS Code:
- Type message
- Click Commit

GitHub Desktop:
- Enter message
- Click Commit to main

---

# 8. Push to GitHub

Command Line:
git push origin main

If needed:
git push origin master

VS Code:
Click Sync Changes or Push

GitHub Desktop:
Click Push origin

---

# 9. .gitignore (VERY IMPORTANT)

.gitignore controls what files are NOT uploaded.

Rules:
- Must be in repo root
- Must be committed like normal file
- Only works for untracked files

If bad files were already added:

git rm -r --cached .
git add .
git commit -m "Fix gitignore"

---

# 10. Summary

Git:
- tracks changes locally

GitHub:
- stores repositories online

GitHub Desktop / VS Code:
- visual interfaces for Git

All methods ultimately run Git commands behind the scenes.

---

# Key Reminder

AstralAnomalies is a sensitive project:
Always ensure build/cache files are ignored before committing.