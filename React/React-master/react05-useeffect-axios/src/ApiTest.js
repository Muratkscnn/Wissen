import axios from 'axios'
import React, { useEffect, useState } from 'react'

function ApiTest() {

    const [users,setUsers]=useState([]);
    const [singleUser,setSingleUser]=useState([])

    useEffect(function() {
    axios.get('https://jsonplaceholder.typicode.com/users').then(
        (response)=> setUsers(response.data))
    },[]);

    const onchangeHandler=(e) => {
        axios.get('https://jsonplaceholder.typicode.com/users/' + e.target.value).then(
            (response)=>setSingleUser(response.data))
            console.log(e.target.value)
        }

  return (
    <div>
        <select className='form-control w-25 container mt-4' onChange={onchangeHandler}>
            <option value="0">Kullanıcı Seçiniz</option>
            {users.map((user)=> (
            <option value={user.id} key={user.id}>{user.name}</option>
            ))}
        </select>
        <hr />
        <table className='table table-dark w-50 mx-auto'>
            <thead>
            <tr>
                <th>id</th>
                <th>name</th>
                <th>username</th>
                <th>email</th>
            </tr>
            </thead>
            <tbody>
                    <tr>
                        <td>{singleUser.id}</td>
                        <td>{singleUser.name}</td>
                        <td>{singleUser.username}</td>
                        <td>{singleUser.email}</td>
                    </tr>
            </tbody>
        </table>
    </div>
  )
}

export default ApiTest