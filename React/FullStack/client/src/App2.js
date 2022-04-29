import './App.css';
import React, { useEffect, useState } from 'react'
import axios from 'axios'


function App() {
  const [library,setLibrary]=useState([])
  useEffect(function() {
  axios.get("http://localhost:3030/getLibrary").then((response)=> setLibrary(response.data))
  }, [library])
  return (
    <div className='App'>
      {library.map((librarys)=>(
      <div>
      <h1>Name:{librarys.Name}</h1>
      <h1>Age:{librarys.Isbn}</h1>
      <h1>Username:{librarys.Author}</h1>
      </div>
      ))}
    </div>
  );
}

export default App;
