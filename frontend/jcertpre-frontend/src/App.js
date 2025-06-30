// frontend/jcertpre-frontend/src/App.js
       import React, { useState } from 'react';
       import axios from 'axios';

       function App() {
           const [username, setUsername] = useState('');
           const [password, setPassword] = useState('');

           const handleLogin = async () => {
               try {
                   const response = await axios.post('http://localhost:5032/api/auth/login', { username, password });
                   alert(response.data.message);
               } catch (error) {
                   alert('Đăng nhập thất bại');
               }
           };

           return (
               <div style={{ textAlign: 'center', marginTop: '50px' }}>
                   <h2>Sign in to JCertPre</h2>
                   <input
                       type="text"
                       placeholder="Username"
                       value={username}
                       onChange={(e) => setUsername(e.target.value)}
                       style={{ display: 'block', margin: '10px auto', padding: '10px', width: '200px' }}
                   />
                   <input
                       type="password"
                       placeholder="Password"
                       value={password}
                       onChange={(e) => setPassword(e.target.value)}
                       style={{ display: 'block', margin: '10px auto', padding: '10px', width: '200px' }}
                   />
                   <button
                       onClick={handleLogin}
                       style={{ padding: '10px 20px', backgroundColor: '#007bff', color: 'white', border: 'none' }}
                   >
                       Sign in
                   </button>
               </div>
           );
       }

       export default App;