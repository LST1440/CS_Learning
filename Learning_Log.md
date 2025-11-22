# 📚 Learning Log | 學習歷程紀錄

> 這裡記錄了我學習 C 語言、資料結構與演算法的每日進度與心得。
> Keep coding, keep learning.

---

## 📅 2025/11/22
### 💻 C Programming & Data Structures (C 語言資料結構)

#### 1. Selection Sort (選擇排序法)
* Implemented the basic sorting algorithm.

#### 2. Horner's Rule (霍納演算法)
* **Reflection:** The mathematical concept is simple, but translating it into code immediately was challenging.
* **Action:** Realized the need for more practice to improve coding intuition and "muscle memory."
* **心得：** 數學表達雖然簡單，但當下無法馬上反應成程式碼。將抽象邏輯具象化為程式碼的過程，需要更大量的練習來累積手感。

#### 3. Fibonacci Sequence (費式數列)
* **Insight on Time Complexity:** Experienced the drastic performance difference between `n=40` and `n=60`.
* **Takeaway:** A practical realization of how recursive algorithms can grow exponentially without optimization.
* **心得：** 對於「時間複雜度」有了深刻體會。僅僅是從 n=40 增加到 n=60，執行時間的差距竟然如此巨大。

#### 4. Tower of Hanoi (河內塔)
* **Mental Shift:** Initially struggled with moving disks one by one. The breakthrough came when I stopped focusing on individual steps and started treating the previous stack as a **single block**.
* **Recursion Logic:**
    * Trust the computer to handle the sub-problems (the "n-1" stack) that have already been solved.
    * **Key Insight:** Do not obsess over "How does disk 1 move? How does disk 2 move?". Instead, treat `N=4` as moving a known block of 3.
* **Example Logic:**
    * **N=3 (7 steps):** A->C, A->B, C->B, A->C, B->A, B->C, A->C.
    * **N=4 (Abstraction):**
        1.  Move 1~3 (Block) from **A -> B** (Takes 7 steps).
        2.  Move 4th disk from **A -> C** (Takes 1 step).
        3.  Move 1~3 (Block) from **B -> C** (Takes 7 steps).
* **心得：**
    * 不再糾結於「第 1 個盤子怎麼搬、第 2 個盤子怎麼動」這種瑣碎細節。
    * **頓悟：** 每新增一個盤子，其實只要關注「前一項的數量 (n-1)」與「最底層的盤子」。
    * **核心觀念：** 記住你正在學習遞迴 (Recursion)，要善用「已知」的知識去解決問題，而不是憑空想像每一步。

---

## ⚙️ Environment & Tools (環境與工具)

### 1. Fixed CMD Encoding Issue (解決 CMD 中文亂碼)
* **Problem:** C programs outputting garbled text in Windows CMD.
* **Solution:** Changed System Locale settings to UTF-8.
    * *Path:* `Control Panel` -> `Region` -> `Administrative` -> `Change system locale...` -> Check **"Beta: Use Unicode UTF-8 for worldwide language support"**.
* **Goal:** Solved the root cause for all future development.
* **解決方案：** 從系統管理變更地區設定，勾選 Beta 版 Unicode UTF-8 支援，希望能一勞永逸解決根本問題。

### 2. GitHub Structure Refactor (GitHub 目錄重構)
* Organized the repository with a structured directory system for better learning management.
* 針對 GitHub 資料夾進行了更有結構的分類，方便未來的學習與檢索。