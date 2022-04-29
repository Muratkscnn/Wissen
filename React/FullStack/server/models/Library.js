const mongoose = require('mongoose');

const LibrarySchema=new mongoose.Schema({
    Name:{type:String,required:true},
    Isbn:{type:Number,required:true},
    Author:{type:String ,required:true},
    Publisher:{type:String ,required:true},
    PublisherDate:{type:String ,required:true},
    PageNumber:{type:String ,required:true},
    Img:{type:String ,required:true}
})
const LibraryModel = mongoose.model("library",LibrarySchema)

module.exports=LibraryModel