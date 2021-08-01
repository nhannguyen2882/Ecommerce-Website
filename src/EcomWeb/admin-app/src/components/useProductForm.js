import React, { useState } from "react";

const useForm = (initialValues,validate,setCurrentId)=>{
    const [values,setValues] = useState(initialValues)
    const [errors,setErrors] = useState({})
    const [checked, setChecked] = React.useState(true);

    const handleInputChange = e =>{
        
        const {name,value}= e.target
        const fieldValue = { [name]: value }

        if('published' in fieldValue)
            fieldValue["published"] = e.target.checked
        else
            fieldValue["isFeatured"] = e.target.checked
        setChecked(e.target.checked);
        
        setValues({
            ...values,
            ...fieldValue,
            
        })
        validate(fieldValue)
        
    }

    const resetForm=()=>{
        setValues({
            ...initialValues
        })
        setErrors({})
        setCurrentId(null)
    }

    return {
        values,
        setValues,
        handleInputChange,
        errors,
        setErrors,
        resetForm
    }

}

export default useForm;