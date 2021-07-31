import axios from 'axios';

const baseUrl = 'https://localhost:5001/api/';

export default {
    dCategory(url = baseUrl+'category/'){
        return{
            fetchAllCat:()=>axios.get(url),
            fetchById:id=>axios.get(url+id),
            createCat:newRecord=>axios.post(url,newRecord),
            updateCat:(id,updateRecord)=>axios.put(url+id,updateRecord),
            deleteCat:id=>axios.delete(url+id)
        }
    },
    dProduct(url = baseUrl+'product/'){
        return{
            fetchAllProduct:catid=>axios.get(url+"?categoryId="+catid),
            fetchById:id=>axios.get(url+id),
            createProduct:newRecord=>axios.post(url,newRecord),
            updateProduct:(id,updateRecord)=>axios.put(url+id,updateRecord),
            deleteProduct:id=>axios.delete(url+id)
        }
    }
}