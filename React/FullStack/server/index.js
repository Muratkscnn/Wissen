const express = require('express')
const app =express()
const mongoose = require('mongoose')
const cors = require('cors');
const EmployeModel=require("./models/Employess")

app.use(express.json())
app.use(cors())

mongoose.connect("mongodb+srv://admin:1234@cluster0.c873i.mongodb.net/fullstack?retryWrites=true&w=majority")

app.get("/getEmployees",(req,res)=>{
    EmployeModel.find({},(err,result) => {
        if (err) {
            res.json(err)
        }
        else{
            res.json(result)
        }
    })
})

app.post("/createEmployee", async (req,res)=>{
    const employee=req.body
    const newEmployee =new EmployeModel(employee)
    await newEmployee.save()
    res.json(employee)
})
app.listen(3030,() => {
    console.log("SERVER ÇALIŞIYOR")
});
