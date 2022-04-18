import logo from './logo.svg';
import './App.css'; 
import { useState } from 'react';
import Navbar from './components/Navbar';
import { Route, Routes } from 'react-router-dom';
import About from './components/About';
import Home from './components/Home';
import Contact from './components/Contact';


function App() {
  return ( 
    <div>
      <Navbar />
      <Routes>
        <Route path='/Home' element={<Home/>}/>
        <Route path='/About' element={<About/>}/>
        <Route path='/Contact' element={<Contact/>}/>
      </Routes>
    </div>
    

  );
}

export default App;
