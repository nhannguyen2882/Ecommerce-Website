import { Button, Checkbox, Grid,TextField,withStyles,FormControlLabel} from "@material-ui/core";
import * as actions from "../actions/dCategory";
import useForm from "./useForm";
import {connect} from "react-redux"
import { v4 as uuidv4 } from 'uuid';
import { useEffect } from "react";
import {useToasts} from 'react-toast-notifications'
import Moment from 'moment';
const styles =theme=>({
    root:{
        margin: theme.spacing(3),
        minWidth: 300,
    },
    smMargin:{
        margin: theme.spacing(1)
    },
    subTitle:{
        color: "#006064",
        textAlign: 'center',

    }
})
const initCategoryValue = {
    id:null,
    name:'',
    desc:'',
    createdDate: new Date(),
    updatedDate: new Date(),
    published: false

}

const CategoryForm=({classes,...props})=>{

    const { addToast } = useToasts()
    const validate = (fieldInputs = values) => {
        let temp = {...errors}
        if('name' in fieldInputs){
            temp.nameCategory = fieldInputs["name"] ?"":"This field is required."
            temp.nameCategory = /^.{0,50}$/.test(fieldInputs["name"]) ? temp.nameCategory: "Max length is 50 characters"
        }
        if('desc' in fieldInputs){
            temp.desc = fieldInputs.desc ?"":"This field is required."
            temp.desc = /^.{0,50}$/.test(fieldInputs.desc)? temp.desc: "Max length is 50 characters"
        }
        setErrors({
            ...temp
        })
        if(fieldInputs == values)
            return Object.values(temp).every(x=>x=="")
    } 

    const{values,setValues,handleInputChange,errors,setErrors, resetForm}=useForm(initCategoryValue,validate, props.setCurrentId)

    const typeSubmit = props.currentId == null ? "Add": "Edit"

    const handleSubmit = e =>{
        const onSuccess = () => {
            resetForm()
            addToast(typeSubmit + " Category successfully", { appearance: 'success' })
        }
        e.preventDefault()
        if(validate()){
            if(props.currentId ==null)
                props.createCategory(values,onSuccess)
            else
                props.updateCategory(props.currentId,values,onSuccess)
        }
    }
    
    useEffect(()=>{
        if(props.currentId !=null){
            setValues({
                ...props.dCategoryList.find(x=>x.id==props.currentId)
            })
        }
    },[props.currentId])
    return (
        <form autoComplete="off" className = {classes.root} onSubmit={handleSubmit}>
            <TextField 
                name = "name"
                variant = "outlined"
                label = "Name Category"
                value = {values["name"]}
                fullWidth
                onChange = {handleInputChange}
                {...(errors.nameCategory && {error : true, helperText : errors.nameCategory})}
            />
            <p></p>
            <TextField 
                name = "desc"
                variant = "outlined"
                label = "Description"
                multiline
                rows={6}
                fullWidth
                value = {values.desc}
                onChange = {handleInputChange}
                {...(errors.desc && {error : true, helperText : errors.desc})}
            />
            <FormControlLabel
                control={
                <Checkbox 
                    name ="published" 
                    checked={values.published}
                    onChange={handleInputChange}
                    />}
                    label="Is published?"
            />
            <p></p>
            <div>
                <Button variant="contained" color="primary" type="submit">
                    {typeSubmit}
                </Button>
                <Button variant="contained" onClick={resetForm}  className={classes.smMargin}>
                    Reset
                </Button>
            </div>
        </form>
    );
}

const mapActiontoProps = {
    createCategory :actions.createCat,
    updateCategory :actions.updateCat,
   
}
const mapStateToProps = state=>({
    dCategoryList: state.dCategory.list
})
export default connect(mapStateToProps,mapActiontoProps)(withStyles(styles)(CategoryForm));