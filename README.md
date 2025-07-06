   Ứng dụng học và luyện thi chứng chỉ tiếng Nhật (NAT-TEST, JLPT).
## 📖 Mô tả dự án

Quiz Nhat là một hệ thống học tập tiếng Nhật trực tuyến hoàn chỉnh, bao gồm:
- Frontend: ReactJS với UI hiện đại, responsive
- Backend: Node.js + Express API
- Database: MySQL với schema được thiết kế tối ưu
- Tính năng đầy đủ: Đăng nhập/đăng ký, xem video, làm quiz, theo dõi kết quả

 ## Cấu trúc
 
- `backend`: ASP.NET Core API (C#).
- `frontend`: ReactJS giao diện.
- `docs`: Tài liệu (Google Docs: https://docs.google.com/document/d/1AAfwjJi_yI-1v0pb5JhanZweVbhcMmtB40rJQFMnhTc/edit).

## 🚀 Cài đặt và chạy dự án
#### Tạo database MySQL:
```sql
CREATE DATABASE quiz_nhat_db CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci;
```

#### Import dữ liệu mẫu:
```bash
mysql -u root -p quiz_nhat_db < database/init.sql
```

### 4. Cấu hình môi trường

Tạo file `.env` trong thư mục `backend` (đã có sẵn):
```env
PORT=5000
DB_HOST=localhost
DB_USER=root
DB_PASSWORD=
DB_NAME=quiz_nhat_db
JWT_SECRET=quiz_nhat_secret_key_2024
```

**Lưu ý:** Cập nhật `DB_PASSWORD` theo cấu hình MySQL của bạn.

### 5. Chạy ứng dụng

#### Chạy đồng thời backend và frontend:
```bash
npm run dev
```

#### Hoặc chạy riêng từng phần:
```bash
# Terminal 1: Backend
npm run server

# Terminal 2: Frontend
npm run client
```

### 6. Truy cập ứng dụng
   - Frontend: http://localhost:3000
   - Backend API: http://localhost:5000


## Hướng dẫn chạy
   - **Backend**: `cd backend && dotnet run`
   - **Frontend**: `cd frontend && npm start`
