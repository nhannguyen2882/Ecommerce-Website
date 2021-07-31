import api from "./api"
import { v4 as uuidv1 } from 'uuid';

export const ACTION_TYPES={
    CREATE_PRODUCT:'CREATE_PRODUCT',
    UPDATE_PRODUCT:'UPDATE_PRODUCT',
    DELETE_PRODUCT:'DELETE_PRODUCT',
    FETCH_ALL_PRODUCT:'FETCH_ALL_PRODUCT'
}

const addId = data => ({
    ...data,
    id: uuidv1(),
    price: parseFloat(data.price)
})
const setUpdateDate = data =>({
    ...data,
    updatedDate: new Date()
})

export const fetchAllProduct = catId => dispatch => {
    api.dProduct().fetchAllProduct(catId)
    .then(response => {
        dispatch({
            type: ACTION_TYPES.FETCH_ALL_PRODUCT,
            payload: response.data
        })
    })
    .catch(err=>console.log(err.response.data))
    
}

export const createProduct = (data, onSuccess) => dispatch => {
    data = addId(data)
    console.log(data)

    api.dProduct().createProduct(data)
    .then(response => {

        dispatch({
            type: ACTION_TYPES.CREATE_PRODUCT,
            payload: response.data
        })
        onSuccess()
    })
    .catch(err=>console.log(err))
}

export const updateProduct = (id, data, onSuccess) => dispatch => {
    data = setUpdateDate(data)
    api.dProduct().updateProduct(id, data)
    .then(response => {

        dispatch({
            type: ACTION_TYPES.UPDATE_PRODUCT,
            payload: {id,...data}
        })
        onSuccess()
    })
    .catch(err=>console.log(err))
}

export const deleteProduct = (id, onSuccess) => dispatch => {
    api.dProduct().deleteProduct(id)
    .then(response => {

        dispatch({
            type: ACTION_TYPES.DELETE_PRODUCT,
            payload: id
        })
        onSuccess()
    })
    .catch(err=>console.log(err))
}