import React, { useState } from "react";

const useForm = (initialValues,validate,setCurrentId)=>{
    const [values,setValues] = useState(initialValues)
    const [errors,setErrors] = useState({})
    const [checked, setChecked] = React.useState(true);

    const handleInputChange = e =>{
        console.log(e.target)
        const {name,value}= e.target
        const fieldValue = { [name]: value }

        fieldValue["published"] = e.target.checked

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