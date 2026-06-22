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

Used to exclude files from Git.

If needed:

git rm -r --cached .
git add .
git commit -m "Fix gitignore"