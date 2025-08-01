import React, { useState } from 'react';
import BookDetails from './components/BookDetails';
import BlogDetails from './components/BlogDetails';
import CourseDetails from './components/CourseDetails';
import { books } from './data';
import './App.css'; // <== add this for custom styles

function App() {
  const [showBooks, setShowBooks] = useState(true);
  const [showBlog, setShowBlog] = useState(true);
  const [showCourse, setShowCourse] = useState(true);


  return (
    <div className="app-container">
      <h1>Blogger App</h1>


      <div className="grid-container">
        {showCourse && (
          <div className="column">
            <CourseDetails />
          </div>
        )}
        {showBooks && (
          <div className="column">
            <BookDetails books={books} />
          </div>
        )}
        {showBlog && (
          <div className="column">
            <BlogDetails />
          </div>
        )}
      </div>
    </div>
  );
}

export default App;
