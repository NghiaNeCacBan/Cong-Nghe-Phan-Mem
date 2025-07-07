# Quiz Nhat - Hệ thống học tập tiếng Nhật

## 📖 Mô tả dự án

Quiz Nhat là một hệ thống học tập tiếng Nhật trực tuyến hoàn chỉnh, bao gồm:
- Frontend: ReactJS với UI hiện đại, responsive
- Backend: Node.js + Express API
- Database: MySQL với schema được thiết kế tối ưu
- Tính năng đầy đủ: Đăng nhập/đăng ký, xem video, làm quiz, theo dõi kết quả


## 📱 Tính năng chính

### 🔐 Xác thực người dùng
- Đăng ký tài khoản mới
- Đăng nhập (username/password)
- Quản lý phiên đăng nhập với JWT

### 📚 Quản lý khóa học
- Danh sách khóa học theo cấp độ (N5-N1)
- Xem chi tiết khóa học
- Video bài học tích hợp YouTube
- Lọc khóa học theo cấp độ

### 📝 Hệ thống quiz
- Làm bài kiểm tra trực tuyến
- Đếm ngược thời gian
- Chấm điểm tự động
- Hiển thị kết quả chi tiết

### 📊 Theo dõi tiến độ
- Lịch sử làm bài
- Thống kê điểm số
- Xem chi tiết từng lần làm bài
- Phân tích kết quả học tập

## 🗄️ Cấu trúc database

### Bảng chính:
- **users**: Thông tin người dùng
- **courses**: Khóa học
- **quizzes**: Bài kiểm tra
- **questions**: Câu hỏi
- **quiz_results**: Kết quả làm bài
- **user_answers**: Câu trả lời của người dùng
- **user_progress**: Tiến độ học tập

### Dữ liệu mẫu:
- 5 khóa học từ N5 đến N3
- 5 bài quiz với các câu hỏi mẫu
- Câu hỏi về Hiragana, Katakana, từ vựng, ngữ pháp

## 🔧 Cấu trúc dự án

```
quizNhat/
├── backend/                 # Node.js API
│   ├── server.js           # Main server file
│   ├── package.json        # Backend dependencies
│   └── .env               # Environment variables
├── frontend/               # React app
│   ├── public/            # Static files
│   ├── src/               # Source code
│   │   ├── components/    # React components
│   │   ├── pages/         # Page components
│   │   ├── contexts/      # React contexts
│   │   └── App.js         # Main app component
│   └── package.json       # Frontend dependencies
├── database/              # Database files
│   └── init.sql          # Database schema & sample data
├── package.json          # Root package with scripts
└── README.md            # This file
```

## 🎯 Hướng dẫn sử dụng

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

## 🛠️ Công nghệ sử dụng

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
