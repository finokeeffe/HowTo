# How to Create a GitHub Repo and Upload Your Project Files

This guide shows how to create a GitHub repository and upload a project using:
- Command Line (Git)
- GitHub Desktop (GUI)
- VS Code (optional visual Git tools)

All methods do the same thing — the GUI tools just run Git commands in the background.

---

# 1. Prerequisites

## Install Git (required for command line)
Git is what tracks changes in your project.

Download:
https://git-scm.com/downloads

Check installation:
```bash
git --version
Optional tools
GitHub Desktop: https://desktop.github.com/
VS Code: https://code.visualstudio.com/
2. Create a GitHub Repository
Go to https://github.com
Click + (top right) → New repository
Set:
Name: HowTo
Public or Private
IMPORTANT:
Do NOT tick “Add README”
Click Create repository
3. Open Terminal and Navigate

Open Command Prompt / Terminal.

Move into your folder:

cd Desktop
cd YourProjectFolder

Useful commands:

dir   # Windows
ls    # Mac/Linux
cd .. # go back one folder
4. Clone the Repository
Command Line
git clone https://github.com/finokeeffe/HowTo.git
cd HowTo
GitHub Desktop
Open GitHub Desktop
File → Clone Repository
Paste:
https://github.com/finokeeffe/HowTo
Click Clone
5. Add Project Files

Drag and drop your project files into the HowTo folder.

Make sure .gitignore is included:

HowTo/.gitignore
6. Stage Files

Staging = choosing what to save in the next commit.

Command Line
git add .
VS Code
Open folder in VS Code
Click Source Control icon
Click + Stage All Changes
GitHub Desktop
Files appear automatically
Nothing to stage manually
7. Commit Changes

Commit = saving a snapshot of your project.

Command Line
git commit -m "Initial commit"
VS Code
Type message in Source Control
Click Commit
GitHub Desktop
Write message
Click Commit to main
8. Push to GitHub
Command Line
git push origin main

If needed:

git push origin master
VS Code

Click Sync Changes or Push

GitHub Desktop

Click Push origin

9. .gitignore (IMPORTANT)

.gitignore controls what files are NOT uploaded.

Rules:

Must be inside repo
Must be committed like normal file
Only affects files not already tracked
If ignored files were already tracked:
git rm -r --cached .
git add .
git commit -m "Fix .gitignore"
Summary
Git = version control system
GitHub = online hosting for repos
GitHub Desktop / VS Code = visual tools for Git
All methods do the same thing under the hood
Done

Your project is:

Created on GitHub
Connected locally
Files staged
Committed
.gitignore applied
Pushed online
i want one single mark down file you have stopped before Optional tools down to done i need all of this in the mark down
# How to Create a GitHub Repo and Upload Your Project Files

This guide shows how to create a GitHub repository and upload a project using:
- Command Line (Git)
- GitHub Desktop (GUI)
- VS Code (optional visual Git tools)

All methods do the same thing — GUI tools just run Git commands in the background.

---

# 1. Prerequisites

## Install Git (required for command line)
Git is what tracks changes in your project.

Download:
https://git-scm.com/downloads

Check installation:
```bash
git --version
Optional tools
GitHub Desktop: https://desktop.github.com/
VS Code: https://code.visualstudio.com/
2. Create a GitHub Repository
Go to https://github.com
Click + (top right) → New repository
Set:
Name: HowTo
Public or Private
IMPORTANT:
Do NOT tick “Add README”
Click Create repository
3. Open Terminal and Navigate

Open Command Prompt / Terminal.

Move into your folder:

cd Desktop
cd YourProjectFolder

Useful commands:

dir   # Windows
ls    # Mac/Linux
cd .. # go back one folder
4. Clone the Repository
Command Line
git clone https://github.com/finokeeffe/HowTo.git
cd HowTo
GitHub Desktop
Open GitHub Desktop
File → Clone Repository
Paste:
https://github.com/finokeeffe/HowTo
Click Clone
5. Add Project Files

Drag and drop your project files into the HowTo folder.

Make sure .gitignore is included:

HowTo/.gitignore
6. Stage Files

Staging = choosing what changes to include in the next save (commit).

Command Line
git add .
VS Code
Open folder in VS Code
Click Source Control icon
Click + Stage All Changes
GitHub Desktop
Changes appear automatically
No manual staging needed
7. Commit Changes

Commit = saving a snapshot of your project.

Command Line
git commit -m "Initial commit"
VS Code
Type message in Source Control
Click Commit
GitHub Desktop
Write message
Click Commit to main
8. Push to GitHub

Upload your project online.

Command Line
git push origin main

If needed:

git push origin master
VS Code

Click Sync Changes or Push

GitHub Desktop

Click Push origin

9. .gitignore (IMPORTANT)

.gitignore controls what files are NOT uploaded.

Rules:

Must be inside repo folder
Must be committed like normal file
Only works for files not already tracked
If ignored files were already tracked:
git rm -r --cached .
git add .
git commit -m "Fix .gitignore"
Summary
Git = version control system
GitHub = online hosting for repositories
GitHub Desktop / VS Code = visual tools for Git
All methods do the same thing underneath
Done

Your project is now:

Created on GitHub
Connected locally
Files staged
Committed
.gitignore applied correctly
Pushed online