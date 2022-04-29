const express = require('express')
const app =express()
const mongoose = require('mongoose')
const cors = require('cors');
const EmployeModel=require("./models/Employess")
const LibraryModel=require("./models/Library")



app.use(express.json())
app.use(cors())

mongoose.connect("mongodb+srv://admin:1234@cluster0.c873i.mongodb.net/fullstack?retryWrites=true&w=majority")
//Employee Projesi
// app.get("/getEmployees",(req,res)=>{
//     EmployeModel.find({},(err,result) => {
//         if (err) {
//             res.json(err)
//         }
//         else{
//             res.json(result)
//         }
//     })
// })

// app.post("/createEmployee", async (req,res)=>{
//     const employee=req.body
//     const newEmployee =new EmployeModel(employee)
//     await newEmployee.save()
//     res.json(employee)
// })
// app.listen(3030,() => {
//     console.log("SERVER ÇALIŞIYOR")
// });
// Library
app.get("/getLibrary",(req,res)=>{
    LibraryModel.find({},(err,result) => {
        if (err) {
            res.json(err)
        }
        else{
            res.json(result)
        }
    })
})

app.post("/createLibrary", async (req,res)=>{
    const library=req.body
    const newLibrary =new LibraryModel(library)
    await newLibrary.save()
    res.json(library)
})
app.listen(3030,() => {
    console.log("SERVER ÇALIŞIYOR")
});

