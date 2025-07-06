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

### Cho người học:
1. **Đăng ký tài khoản** với thông tin cơ bản
2. **Chọn cấp độ** phù hợp (N5-N1)
3. **Xem video** bài học
4. **Làm quiz** để kiểm tra kiến thức
5. **Theo dõi kết quả** và tiến độ học tập

### Tài khoản demo:
   - Username: `demo`
   - Password: `123456`

## 🔌 API Endpoints

Xem chi tiết tại [API Documentation](./API_DOCS.md)

### Endpoints chính:
- `POST /api/auth/register` - Đăng ký
- `POST /api/auth/login` - Đăng nhập
- `GET /api/courses` - Danh sách khóa học
- `GET /api/courses/:id` - Chi tiết khóa học
- `GET /api/quizzes/:id` - Chi tiết quiz
- `POST /api/quizzes/:id/submit` - Nộp bài
- `GET /api/user/results` - Kết quả của user

  ### Frontend:
- React 18
- React Router DOM
- Styled Components
- Axios
- React Icons

### Backend:
- Node.js
- Express.js
- MySQL2
- JSON Web Token
- CORS

### Database:
- MySQL 8
- UTF8MB4 encoding (hỗ trợ tiếng Nhật)

## 📈 Tính năng nâng cao có thể mở rộng

- [ ] Upload avatar người dùng
- [ ] Hệ thống ranking
- [ ] Chat community
- [ ] Flashcard học từ vựng
- [ ] Luyện nghe với âm thanh
- [ ] Xuất báo cáo PDF
- [ ] Tích hợp thanh toán
- [ ] Mobile app (React Native)

## 🐛 Troubleshooting

### Lỗi kết nối database:
```bash
# Kiểm tra MySQL đang chạy
mysql -u root -p

# Tạo lại database
mysql -u root -p -e "DROP DATABASE IF EXISTS quiz_nhat_db; CREATE DATABASE quiz_nhat_db CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci;"
mysql -u root -p quiz_nhat_db < database/init.sql
```

### Lỗi port đã được sử dụng:
```bash
# Kill process trên port 3000/5000
npx kill-port 3000
npx kill-port 5000
```

### Xóa cache và cài đặt lại:
```bash
rm -rf node_modules package-lock.json
rm -rf backend/node_modules backend/package-lock.json  
rm -rf frontend/node_modules frontend/package-lock.json
npm run install-all
```

## � Security

Dự án đã được audit và cập nhật các packages để giảm thiểu vulnerabilities:
- **Trước cập nhật**: 9 vulnerabilities (3 moderate, 6 high)  
- **Sau cập nhật**: 3 vulnerabilities (3 moderate, chỉ ảnh hưởng development)

Xem chi tiết tại [SECURITY.md](./SECURITY.md)

## �📞 Hỗ trợ

Nếu gặp vấn đề, vui lòng:
1. Kiểm tra log trong terminal
2. Đảm bảo tất cả dependencies đã được cài đặt
3. Kiểm tra kết nối database
4. Đọc kỹ error message
## 📝 License

MIT License - Tự do sử dụng cho mục đích học tập và thương mại.

---

**Chúc bạn học tiếng Nhật vui vẻ! 🎌**
"# quizNhat" 
