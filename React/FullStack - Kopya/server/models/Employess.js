const mongoose = require('mongoose');

const EmployessSchema=new mongoose.Schema({
    name:{type:String,required:true},
    age:{type:Number,required:true},
    username:{type:String ,required:true}
})
const EmployeModel = mongoose.model("employees",EmployessSchema)

module.exports=EmployeModel