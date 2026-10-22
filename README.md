# 💻 C# Learning

<p align="center">
  <img src="https://img.shields.io/badge/Language-C%23-68217A?style=flat-square&logo=csharp&logoColor=white" alt="C#" />
  <img src="https://img.shields.io/badge/Platform-.NET-512BD4?style=flat-square&logo=dotnet&logoColor=white" alt=".NET" />
  <img src="https://img.shields.io/badge/Documentation-Markdown-083FA1?style=flat-square&logo=markdown&logoColor=white" alt="Markdown" />
  <img src="https://img.shields.io/badge/Version_Control-Git-F05032?style=flat-square&logo=git&logoColor=white" alt="Git" />
</p>

<p align="center">
  <strong>Hệ thống hóa kiến thức · Thực hành · Ôn tập · Phát triển</strong>
</p>

<p align="center">
  Kho lưu trữ kiến thức và bài tập thực hành C#, được xây dựng nhằm chuẩn hóa tài liệu học tập, củng cố nền tảng lập trình và chuẩn bị cho quá trình phát triển ứng dụng với .NET.
</p>

---

## 🧭 Mục lục

<table>
  <tr>
    <td align="center" width="50%">
      <a href="#muc-tieu">🎯<br/><strong>01. Mục tiêu</strong></a>
    </td>
    <td align="center" width="50%">
      <a href="#cau-truc-thu-muc">📂<br/><strong>02. Cấu trúc thư mục</strong></a>
    </td>
  </tr>
  <tr>
    <td align="center" width="50%">
      <a href="#dat-ten">📝<br/><strong>03. Quy tắc đặt tên</strong></a>
    </td>
    <td align="center" width="50%">
      <a href="#commit-convention">🔀<br/><strong>04. Commit Convention</strong></a>
    </td>
  </tr>
  <tr>
    <td align="center" width="50%">
      <a href="#tai-lieu-tham-khao">📚<br/><strong>05. Tài liệu tham khảo</strong></a>
    </td>
    <td align="center" width="50%">
      <a href="#lo-trinh-phat-trien">🚀<br/><strong>Lộ trình phát triển</strong></a>
    </td>
  </tr>
</table>

---

<a id="muc-tieu"></a>

## 🎯 1. Mục tiêu của kho lưu trữ

Repository `CSharp-Learning` được xây dựng để trở thành kho kiến thức cá nhân phục vụ quá trình học tập, thực hành và ôn tập lập trình C# lâu dài.

<table>
&#x20; <tr>
&#x20;   <td width="50%">
&#x20;     <h3>📚 Hệ thống hóa kiến thức </h3>
&#x20;     Tổng hợp và sắp xếp kiến thức C# theo từng chủ đề, từ cơ bản đến nâng cao.
&#x20;   </td>
&#x20;   <td width="50%">
&#x20;     <h3>📝 Chuẩn hóa ghi chép </h3>
&#x20;     Xây dựng quy tắc ghi chép nhất quán, giúp nội dung dễ đọc, dễ tìm kiếm và dễ ôn tập.
&#x20;   </td>
&#x20; </tr>
&#x20; <tr>
&#x20;   <td>
&#x20;     <h3>💻 Kết hợp lý thuyết và thực hành </h3>
&#x20;     Lưu trữ tài liệu, hình ảnh minh họa, ví dụ mã nguồn và bài tập theo từng chủ đề.
&#x20;   </td>
&#x20;   <td>
&#x20;     <h3>🔎 Tổng hợp nhiều nguồn học tập </h3>
&#x20;     Chọn lọc kiến thức từ tài liệu chính thức, khóa học trực tuyến và video hướng dẫn.
&#x20;   </td>
&#x20; </tr>
&#x20; <tr>
&#x20;   <td colspan="2">
&#x20;     <h3>🚀 Chuẩn bị cho các dự án .NET </h3>
&#x20;     Củng cố nền tảng C# để tiếp tục học tập và phát triển ứng dụng với .NET, ASP.NET Core và Web API.
&#x20;   </td>
&#x20; </tr>
</table>

---

<a id="cau-truc-thu-muc"></a>

## 📂 2. Cấu trúc thư mục

```text
CSharp-Learning/
├── README.md
│
├── Basic/
│   ├── 01-Variables/
│   ├── 02-Data-Types/
│   ├── 03-Operators/
│   ├── 04-Conditional-Statements/
│   ├── 05-Loops/
│   └── 06-Methods/
│
├── BaiTap_Basic/
│   ├── Exercise-01/
│   ├── Exercise-02/
│   └── ...
│
├── OOP/
│   ├── 01-Classes-and-Objects/
│   ├── 02-Encapsulation/
│   ├── 03-Inheritance/
│   ├── 04-Polymorphism/
│   └── 05-Abstraction/
│
├── BaiTap_OOP/
│   ├── Exercise-01/
│   ├── Exercise-02/
│   └── ...
│
└── Document/
    ├── Learning-Resources.md
    ├── CSharp-Roadmap.md
    └── General-Notes.md
```

### 📁 2.1. Chức năng các thư mục

| Thư mục            | Chức năng                                                                               |
| :----------------- | :-------------------------------------------------------------------------------------- |
| 📘 `Basic/`        | Lý thuyết và ví dụ minh họa về kiến thức C# cơ bản.                                     |
| 🧩 `BaiTap_Basic/` | Bài tập thực hành áp dụng kiến thức C# cơ bản.                                          |
| 🏗️ `OOP/`         | Lý thuyết và ví dụ về lập trình hướng đối tượng (Object-Oriented Programming).          |
| 🧪 `BaiTap_OOP/`   | Bài tập thực hành về class, object, inheritance, polymorphism và các nội dung OOP khác. |
| 📚 `Document/`     | Tài liệu dùng chung như lộ trình học tập, nguồn tham khảo và ghi chú tổng hợp.          |

### 🗂️ 2.2. Cấu trúc bên trong mỗi chủ đề

Ví dụ với chủ đề `01-Variables/`:

```text
01-Variables/
├── README.md
├── Examples.cs
├── Images/
└── Materials/
```

| Thành phần    | Mô tả                                                         |
| :------------ | :------------------------------------------------------------ |
| `README.md`   | Nội dung lý thuyết, giải thích kiến thức và hướng dẫn ôn tập. |
| `Examples.cs` | Mã nguồn ví dụ phục vụ học tập và thực hành.                  |
| `Images/`     | Hình ảnh minh họa, sơ đồ và ảnh chụp bài giảng.               |
| `Materials/`  | Tài liệu bổ sung như PDF và nguồn tham khảo liên quan.        |

**Nguyên tắc tổ chức tài liệu:**

- Tài liệu liên quan trực tiếp đến chủ đề được lưu trong thư mục của chủ đề đó.
- Tài liệu dùng chung cho toàn bộ repository được lưu trong `Document/`.
- Chỉ tạo thêm file hoặc thư mục khi thực sự cần thiết.

---

<a id="dat-ten"></a>

## 📝 3. Nguyên tắc đặt tên thư mục và file

### 📌 3.1. Nguyên tắc chung

- Sử dụng tiếng Anh để đảm bảo tính nhất quán.
- Đặt tên ngắn gọn, rõ nghĩa và phản ánh đúng nội dung.
- Không sử dụng dấu tiếng Việt hoặc khoảng trắng trong tên.
- Ưu tiên dấu gạch ngang (`-`) để phân tách các từ trong tên thư mục và file Markdown.
- Sử dụng số thứ tự khi cần xác định trình tự học tập.
- Hạn chế tên chung chung như `NewFile`, `Test1`, `CodeMoi` hoặc `TaiLieu`.

### 🗃️ 3.2. Quy tắc theo loại file

| Loại                 | Quy tắc                         | Ví dụ                           |
| :------------------- | :------------------------------ | :------------------------------ |
| Thư mục kiến thức    | Tiếng Anh, có thể kèm số thứ tự | `01-Variables/`                 |
| File Markdown        | Tên thể hiện nội dung           | `README.md`, `General-Notes.md` |
| File C#              | Sử dụng `PascalCase`            | `Examples.cs`, `Calculator.cs`  |
| Thư mục hình ảnh     | Dùng tên thống nhất             | `Images/`                       |
| Thư mục tài liệu     | Dùng tên thống nhất             | `Materials/`                    |
| File hình ảnh        | Tên mô tả nội dung              | `variable-example.png`          |
| File nguồn tham khảo | Tên thể hiện mục đích           | `Learning-Resources.md`         |

### 🧠 3.3. Quy tắc tổ chức kiến thức

- Mỗi chủ đề có một vị trí lưu trữ chính.
- Không tạo nhiều file trùng lặp cho cùng một nội dung chỉ vì kiến thức xuất hiện trong nhiều khóa học.
- Sắp xếp kiến thức theo chủ đề thay vì phụ thuộc hoàn toàn vào thứ tự của khóa học.
- Tách biệt lý thuyết và bài tập thực hành để thuận tiện tra cứu.
- Có thể điều chỉnh cấu trúc khi phạm vi kiến thức mở rộng.

## 🔀 4. Nguyên tắc Commit

`CSharp-Learning` sử dụng quy ước commit nhất quán nhằm giúp lịch sử Git dễ đọc, dễ tìm kiếm và thuận tiện cho việc theo dõi quá trình học tập, thực hành và cập nhật kiến thức C#.

### 4.1. Commit Message Structure

```text
<type>(<scope>): <short description> | <revision>
```

- `type`: Mục đích của thay đổi.
- `scope`: Chủ đề hoặc khu vực bị ảnh hưởng, có thể bỏ qua.
- `short description`: Mô tả ngắn gọn nội dung thay đổi.
- `revision`: Ký hiệu lần triển khai hoặc cập nhật, theo quy tắc tại mục 4.6. Có thể bỏ qua nếu không cần theo dõi revision.

### 4.2. Commit Types

| **Type** | **Description** | **Usage** |
|---|---|---|
| `feat` | New content or examples | Thêm kiến thức, ví dụ hoặc bài tập mới |
| `fix` | Fix errors | Sửa lỗi mã nguồn hoặc nội dung kiến thức |
| `docs` | Documentation | Cập nhật tài liệu Markdown, README |
| `style` | Code formatting | Định dạng code, không thay đổi logic |
| `refactor` | Code refactoring | Cải thiện cấu trúc mã nguồn |
| `perf` | Performance improvement | Tối ưu hiệu năng chương trình |
| `test` | Tests | Thêm hoặc cập nhật kiểm thử |
| `build` | Build system | Cập nhật cấu hình build hoặc dependencies |
| `ci` | Continuous integration | Cập nhật quy trình CI/CD |
| `chore` | Maintenance | Công việc bảo trì repository |
| `revert` | Revert changes | Hoàn tác commit trước đó |

### 4.3. Common Scopes

| **Scope** | **Description** |
|---|---|
| `basic` | Kiến thức C# cơ bản |
| `variables` | Biến và cách khai báo biến |
| `data-types` | Kiểu dữ liệu |
| `operators` | Các toán tử |
| `conditions` | Câu lệnh điều kiện |
| `loops` | Các loại vòng lặp |
| `methods` | Phương thức |
| `oop` | Lập trình hướng đối tượng |
| `classes` | Class và Object |
| `inheritance` | Tính kế thừa |
| `polymorphism` | Tính đa hình |
| `abstraction` | Tính trừu tượng |
| `encapsulation` | Tính đóng gói |
| `exercise` | Bài tập thực hành |
| `examples` | Ví dụ mã nguồn |
| `readme` | Tài liệu README |
| `docs` | Tài liệu học tập |
| `resources` | Tài nguyên và nguồn tham khảo |
| `config` | Cấu hình dự án |
| `repo` | Cấu trúc repository |

**Lưu ý:** Scope nên phản ánh phần nội dung thực sự thay đổi. Không cần sử dụng scope nếu commit chỉ ảnh hưởng đến nhiều chủ đề và không có một phạm vi chính phù hợp.

### 4.4. Commit Examples

```bash
# Add basic variable examples
git commit -m "feat(variables): add variable declaration examples"

# Add notes about data types
git commit -m "docs(data-types): add data type notes"

# Fix a C# code example
git commit -m "fix(loops): fix for loop example"

# Add basic programming exercises
git commit -m "feat(exercise): add basic C# exercises"

# Improve class and object examples
git commit -m "refactor(classes): simplify class examples"

# Update the repository README
git commit -m "docs(readme): update repository introduction"

# Organize learning resources
git commit -m "docs(resources): organize learning references"

# Format code without changing logic
git commit -m "style(methods): format method examples"
```

### 4.5. Commit Rules

1. Ưu tiên sử dụng tiếng Anh cho commit message.
2. Mỗi commit tập trung vào một mục đích chính.
3. Mô tả ngắn gọn, cụ thể và phản ánh đúng nội dung thay đổi.
4. Sử dụng scope nhất quán để dễ tìm kiếm lịch sử commit.
5. Tránh các thông điệp chung chung như `update code`, `fix bug` hoặc `final`.
6. Kiểm tra nội dung thay đổi trước khi commit.
7. Không commit mật khẩu, API key hoặc thông tin xác thực nhạy cảm.
8. Không bắt buộc sử dụng revision cho mọi commit; chỉ dùng khi cần theo dõi các lần cập nhật của cùng một chủ đề hoặc nội dung.

---

### 4.6. Feature Revision Convention

Repository sử dụng ký hiệu revision để theo dõi các lần triển khai hoặc cập nhật của cùng một chủ đề, ví dụ như một bộ ví dụ, bài tập hoặc tài liệu.

**Revision Rules**

| **Ký hiệu** | **Ý nghĩa** |
|---|---|
| `init` | Lần triển khai hoặc bổ sung đầu tiên |
| `H2` | Lần cập nhật thứ hai |
| `H3` | Lần cập nhật thứ ba |
| `H4` | Lần cập nhật thứ tư |
| `HN` | Các lần cập nhật tiếp theo, với `N` là số thứ tự |

**Examples**

```bash
# Initial implementation of variable examples
git commit -m "feat(variables): add variable examples | init"

# Second update of variable examples
git commit -m "docs(variables): clarify variable declaration | H2"

# Third update of variable examples
git commit -m "feat(variables): add scope examples | H3"

# Initial implementation of loop exercises
git commit -m "feat(exercise): add loop exercises | init"

# Second update of loop exercises
git commit -m "fix(exercise): correct loop exercise solutions | H2"
```

**Revision Guidelines**

1. Sử dụng `init` cho lần triển khai đầu tiên của nội dung cần theo dõi.
2. Bắt đầu từ `H2` cho lần cập nhật thứ hai, sau đó tăng tuần tự `H3`, `H4`, `H5`, ...
3. Mỗi chủ đề hoặc nhóm nội dung có chuỗi revision độc lập.
4. Khi tiếp tục chỉnh sửa cùng một nội dung, sử dụng revision tiếp theo thay vì đặt lại về `init`.
5. Chỉ tăng revision khi có một lần cập nhật đáng kể cần theo dõi; không bắt buộc mọi commit nhỏ đều phải tăng số.
6. Revision là quy ước nội bộ của repository, không thay thế phiên bản phát hành chính thức của C# hoặc .NET.

**Note:** Git không tự quản lý hoặc xác minh các ký hiệu revision trong commit message. Người quản lý repository cần tự theo dõi revision của từng chủ đề để tránh nhầm lẫn.

<a id="tai-lieu-tham-khao"></a>

## 📚 5. Tài liệu tham khảo

Các nguồn tài liệu phục vụ quá trình học tập và tra cứu:

| Nguồn           | Nội dung                   | Liên kết                                                             |
| :-------------- | :------------------------- | :------------------------------------------------------------------- |
| Microsoft Learn | Tài liệu chính thức về C#  | [C# Documentation](https://learn.microsoft.com/en-us/dotnet/csharp/) |
| Microsoft Learn | Tài liệu về nền tảng .NET  | [.NET Documentation](https://learn.microsoft.com/en-us/dotnet/)      |
| Git             | Tài liệu chính thức về Git | [Git Documentation](https://git-scm.com/doc)                         |

---

<a id="lo-trinh-phat-trien"></a>

## 🚀 Lộ trình phát triển

Repository sẽ được mở rộng theo tiến độ học tập thực tế.

- [ ] Hoàn thiện kiến thức C# cơ bản.
- [ ] Bổ sung bài tập thực hành C# cơ bản.
- [ ] Hệ thống hóa kiến thức lập trình hướng đối tượng (OOP).
- [ ] Bổ sung bài tập thực hành OOP.
- [ ] Chuẩn hóa quy tắc ghi chép và commit.
- [ ] Mở rộng sang các kiến thức .NET phục vụ phát triển ứng dụng.

---

<p align="center">
&#x20;  <strong>Learn consistently. Practice regularly. Build with confidence. </strong>
</p>

<p align="center">
&#x20;  <sub>C# Learning Repository · Personal Study & Practice </sub>
</p>
