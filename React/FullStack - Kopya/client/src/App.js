import './App.css';
import React, { useEffect, useState } from 'react'
import axios from 'axios'


function App() {
  const [employees,setEmployees]=useState([])
  const [name, setName] = useState("")
  const [age, setAge] = useState(0)
  const [username, setUsername] = useState("")
  useEffect(function() {
  axios.get("http://localhost:3030/getEmployees").then((response)=> setEmployees(response.data))
  }, [employees])
  const createEmployee = () => {
    axios.post("http://localhost:3030/createEmployee", {
      name:name,
      age:age,
      username:username
    }).then((res)=>{alert("Employee Created")})
  }
  return (
    <div className='App'>
      {employees.map((employee)=>(
      <div>
      <h1>Name:{employee.name}</h1>
      <h1>Age:{employee.age}</h1>
      <h1>Username:{employee.username}</h1>
      </div>
      ))}
      <div>
        <input placeholder="isim giriniz" type="text" onChange={(e)=> setName(e.target.value) }/>
        <input placeholder="Yaş giriniz" type="number" onChange={(e)=> setAge(e.target.value) }/>
        <input placeholder="Kullanıcı ad giriniz" type="text" onChange={(e)=> setUsername(e.target.value) }/>
        <button onClick={createEmployee}>Create Employee</button>
      </div>
    </div>
  );
}

export default App;
