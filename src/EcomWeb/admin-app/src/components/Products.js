import {TablePagination, Grid , Paper, TableBody, TableCell, TableContainer, TableHead, TableRow, withStyles, Checkbox, Button, ButtonGroup, Table} from "@material-ui/core";
import React ,{useState,useEffect}from "react"
import {connect} from "react-redux"
import * as actions from "../actions/dProduct";
import ProductForm from "./ProductForm"

import { useToasts } from "react-toast-notifications";

import TableProduct from "./TableProduct";

const styles = theme =>({
   
    title:{
        color: "#e91e63",
        paddingLeft: theme.spacing(3)
    },
    subTitle2:{
        color: "#ff5722",
        textAlign:'center'
    },
    subTitle1:{
        color: "#006064",
        textAlign:'center'
    },
    borderForm:{
        border: "1px solid #607d8b"
    },
});


const Products=({classes,...props})=>{
    const {addToast} = useToasts()
    
    useEffect(()=>{
       
        if(props.selectId!=null){

            props.fetchProduct(props.selectId)


        }
    },[props.selectId])

    const onDelete = (id)=>{
        console.log(id)
        if(window.confirm("Are you sure to delete?"))
            props.deleteProduct(id,()=>addToast("Deleted successfully", { appearance: 'info' }))
    }
    const rows = props.dProductList.length;
    const [page, setPage] = React.useState(0);
    const [rowsPerPage, setRowsPerPage] = React.useState(5);

    const handleChangePage = (event, newPage) => {
        setPage(newPage);
    };

    const handleChangeRowsPerPage = (event) => {
    setRowsPerPage(parseInt(event.target.value, 10));
    setPage(0);
    };

    const [currentId,setCurrentId] = useState(null)
    const dataList = props.dProductList
    const catId = props.selectId
    const columns = [
        {
          Header: "Name",
          accessor: "name",
        },
        {
          Header: "Decription",
          accessor: "desc",
        },
        {
          Header: "Price",
          accessor: "price",
        },
        {
            Header: "Date Create",
            accessor: "createdDate",
          },
        {
        Header: "Date Update",
        accessor: "updatedDate",
        },
        {
          Header: "Pulished?",
          accessor: "published",
        },
        {
            Header: "",
            accessor: "button",
          },
    ]
    const [rowdata, setRowData] = useState([])

    return (
            <Grid container>
                <Grid item xs={12} >
                <h1 className = {classes.subTitle2}>{catId==null?"Select Category to view Products":props.selectName}</h1>

                <TableProduct columns={columns} data={props.dProductList} onDelete ={onDelete} page={page} rowsPerPage={rowsPerPage} setCurrentId={setCurrentId}/>
                <TablePagination
                    rowsPerPageOptions={[5, 10, 25]}
                    component="div"
                    count={rows}
                    rowsPerPage={rowsPerPage}
                    page={page}
                    onPageChange={handleChangePage}
                    onRowsPerPageChange={handleChangeRowsPerPage}
                />
                </Grid>
                <Grid item xs={12} className = {classes.borderForm}>
                    <h2 className = {classes.subTitle1}>Add/Edit Product</h2>
                    <ProductForm {...({currentId,setCurrentId,dataList,catId})}/>
                    
                </Grid>
            </Grid>
    );
}
const mapActiontoProps = {
    deleteProduct :actions.deleteProduct,
    fetchProduct:actions.fetchAllProduct
}
const mapStateToProps = state=>({
    dProductList: state.dProduct.list
})
export default connect(mapStateToProps,mapActiontoProps)(withStyles(styles)(Products));