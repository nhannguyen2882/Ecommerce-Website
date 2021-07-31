import { Button, Checkbox, Grid,TextField,withStyles,FormControlLabel, ButtonGroup} from "@material-ui/core";
import * as actions from "../actions/dProduct";
import useForm from "./useProductForm";
import {connect} from "react-redux"
import { v4 as uuidv4 } from 'uuid';
import { useEffect, useState } from "react";
import {useToasts} from 'react-toast-notifications'
import InputAdornment from '@material-ui/core/InputAdornment';
import Moment from 'moment';
const styles =theme=>({
    root:{
        margin: theme.spacing(3),
        minWidth: 300,
        
    },
    smMargin:{
        float: "right",
        margin: theme.spacing(1.5)
    },
    subTitle:{
        color: "#006064",
        textAlign: 'center',

    },
    widthTF1:{
        width: 400,
        margin: theme.spacing(1)
    },
    widthTF2:{
        width: 200,
        margin: theme.spacing(1)
    },
    widthTF3:{
        width: 616,
        margin: theme.spacing(1)
    }

})

const ProductForm=({classes,...props})=>{

    const initProductValue = {
        id:null,
        name:'',
        desc:'',
        price:0,
        categoryId:props.catId,
        createdDate: new Date(),
        updatedDate: new Date(),
        published: false
    
    }


    const { addToast } = useToasts()
    const validate = (fieldInputs = values) => {
        let temp = {...errors}
        if('name' in fieldInputs)
            temp.nameProduct =  fieldInputs["name"]? "" : "This field is required."
        if('price' in fieldInputs)
            temp.price = /^[0-9]+$|^[0-9]+\.[0-9]+$|^[0-9]+\.$/.test(fieldInputs.price) ?"":"Input number or decimal number."
        if('desc' in fieldInputs)
            temp.desc = fieldInputs.desc ? "" : "This field is required."
        setErrors({
            ...temp
        })
        if(fieldInputs == values)
            return Object.values(temp).every(x=>x=="")
    } 
    
    const{values,setValues,handleInputChange,errors,setErrors,resetForm}=useForm(initProductValue,validate, props.setCurrentId)

    const typeSubmit = props.currentId == null ? "Add": "Edit"

    const [selectedFile,setSelectedFile] = useState('https://png.pngitem.com/pimgs/s/79-798828_park-junk-fast-food-comments-fast-food-icon.png')

    const fileChangedHandler = event => {
        setSelectedFile(event.target.files[0])
    }

    const uploadHandler = () => {
        
    }

    const handleSubmit = e =>{
        console.log(props.catId)
        const onSuccess = () => {
            resetForm()
            addToast(typeSubmit + " Product successfully", { appearance: 'success' })
        }
        e.preventDefault()
        if(validate()){
            if(props.currentId ==null)
                props.createProduct(values,onSuccess)
            else
                props.updateProduct(props.currentId,values,onSuccess)
        }
    }
    
    useEffect(()=>{
        console.log(props.currentId)
        if(props.currentId !=null){
            setValues({
                ...props.dataList.find(x=>x.id==props.currentId)
            })
        }
    },[props.currentId])

    return (
        <form aria-disabled autoComplete="off" className = {classes.root} onSubmit={handleSubmit}>
            <Grid container>
                <Grid item xs={7}>
                    <TextField
                        name = "name"
                        variant = "outlined"
                        label = "Name Product"
                        value = {values["name"]}
                        InputLabelProps={{
                            shrink: true,
                        }}
                        onChange = {handleInputChange}
                        {...(errors.nameProduct && {error : true, helperText : errors.nameProduct})}
                        className={classes.smMargin, classes.widthTF1}
                     />
                    <TextField 
                        name = "price"
                        variant = "outlined"
                        label = "Price Product"
                        value = {values.price}
                        onChange = {handleInputChange}
                        InputProps={{
                            startAdornment: (
                            <InputAdornment position="start">
                                $
                            </InputAdornment>
                            ),
                        }}
                        {...(errors.price && {error : true, helperText : errors.price})}
                        className={classes.smMargin, classes.widthTF2}
                    />
                    <TextField 
                        name = "desc"
                        variant = "outlined"
                        label = "Description"
                        multiline
                        rows={2}
                        value = {values.desc}
                        onChange = {handleInputChange}
                        {...(errors.desc && {error : true, helperText : errors.desc})}
                        InputLabelProps={{
                            shrink: true,
                        }}
                        className={classes.smMargin, classes.widthTF3}
                    />
                    
                    <div className={classes.smMargin}>
                    <FormControlLabel
                        control={
                        <Checkbox 
                            name ="published" 
                            checked={values.published}
                            onChange={handleInputChange}
                            />}
                        label="Is published?"
                    />
                    <ButtonGroup>
                        <Button variant="contained" onClick={resetForm}  className={classes.smMargin}>
                            Reset
                        </Button>
                        <Button variant="contained" color="secondary" type="submit" className={classes.smMargin}>
                            {typeSubmit}
                        </Button>
                        
                    </ButtonGroup>
                    </div>
                </Grid>
                <Grid item xs={1}></Grid>
                <Grid item xs={4} style={{float:"center"}}>
                    <div >
						<img src={selectedFile} alt="" id="img" className="img" style={{maxHeight: "200px", maxWidth: "200px"}}/>
                    </div>
                    <div>
                        <input type="file" onChange={fileChangedHandler}></input>
                        <button onClick={uploadHandler}>Upload!</button>
                    </div>
                </Grid>
            </Grid>
        </form>
    );
}

const mapActiontoProps = {
    createProduct :actions.createProduct,
    updateProduct :actions.updateProduct,
   
}
const mapStateToProps = state=>({
    dProductList: state.dProduct.list
})
export default connect(mapStateToProps,mapActiontoProps)(withStyles(styles)(ProductForm));