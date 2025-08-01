import React from 'react';
import officeImage from './Office.png'; // ✅ Ensure this filename is correct

function App() {
  return (
    <div style={{ padding: '20px' }}>
      <h1>Office Space, at Affordable Range</h1>
      <h2>Office Space</h2>

      <img
        src={officeImage}
        alt="Office Space"
        style={{ width: '500px', height: 'auto', marginBottom: '20px' }}
      />

      <p><strong>Name:</strong> DBS</p>
      <p><strong>Rent:</strong> Rs. 50000</p>
      <p><strong>Address:</strong> Chennai</p>
    </div>
  );
}

export default App;
