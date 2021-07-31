import api from "./api"
import { v4 as uuidv1 } from 'uuid';

export const ACTION_TYPES={
    CREATE:'CREATE',
    UPDATE:'UPDATE',
    DELETE:'DELETE',
    FETCH_ALL:'FETCH ALL'
}

const addId = data => ({
    ...data,
    id: uuidv1()
})
const setUpdateDate = data =>({
    ...data,
    updatedDate: new Date()
})

export const fetchAllCat = () => dispatch => {
    api.dCategory().fetchAllCat()
    .then(response => {
        dispatch({
            type: ACTION_TYPES.FETCH_ALL,
            payload: response.data
        })
    })
    .catch(err=>console.log(err.response.data))
    
}

export const createCat = (data, onSuccess) => dispatch => {
    data = addId(data)
    console.log(data)
    api.dCategory().createCat(data)
    .then(response => {
        dispatch({
            type: ACTION_TYPES.CREATE,
            payload: response.data
        })
        onSuccess()
    })
    .catch(err=>console.log(err))
}

export const updateCat = (id, data, onSuccess) => dispatch => {
    data = setUpdateDate(data)
    api.dCategory().updateCat(id, data)
    .then(response => {
        dispatch({
            type: ACTION_TYPES.UPDATE,
            payload: {id,...data}
        })
        onSuccess()
    })
    .catch(err=>console.log(err))
}

export const deleteCat = (id, onSuccess) => dispatch => {
    api.dCategory().deleteCat(id)
    .then(response => {
        dispatch({
            type: ACTION_TYPES.DELETE,
            payload: id
        })
        onSuccess()
    })
    .catch(err=>console.log(err))
}