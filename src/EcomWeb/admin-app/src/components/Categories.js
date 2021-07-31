import {TablePagination, Grid , Paper, TableBody, TableCell, TableContainer, TableHead, TableRow, withStyles, Checkbox, Button, ButtonGroup, Table} from "@material-ui/core";
import React ,{useState,useEffect}from "react"
import {connect} from "react-redux"
import * as actions from "../actions/dCategory";
import CategoryForm from "./CategoryForm"
import DeleteIcon from '@material-ui/icons/delete'
import EditIcon from '@material-ui/icons/edit'
import { useToasts } from "react-toast-notifications";
import Moment from 'moment';
import { fetchAllProduct } from "../actions/dProduct";
import Products from "./Products";


const styles = theme =>({
    paper:{
        magrin: theme.spacing(2),
        padding: theme.spacing(2)
    },
    root: {
        "& .MuiTableCell-head": {
            fontSize: "1.1rem",
            fontWeight: "bold"
        },
        
    },

    title:{
        fontSize: "3rem",
        color: "#e91e63",
        paddingLeft: theme.spacing(3)
    },
    subTitle2:{
        color: "#009688",
        paddingLeft: theme.spacing(2),
    },
    subTitle1:{
        color: "#006064",
        paddingLeft: theme.spacing(3),
    }
});

function stableSort(array) {
    const stabilizedThis = array.map((el, index) => [el, index]);
    return stabilizedThis.map((el) => el[0]);
  }

const Categories=({classes,...props})=>{

    
    
    const [currentId,setCurrentId] = useState(null)
    const [selectId,setSelectId] = useState(null)

    const [selectName,setSelectName] = useState("")

    useEffect(()=>{
        props.fetchAllCategory()

    },[])
    
    const {addToast} = useToasts()
    const onDelete = (id)=>{
        if(window.confirm("Are you sure to delete?"))
            props.deleteCategory(id,()=>addToast("Deleted successfully", { appearance: 'info' }))
    }

    const rows = props.dCategoryList.length;
    const [page, setPage] = React.useState(0);
    const [rowsPerPage, setRowsPerPage] = React.useState(5);

    const handleChangePage = (event, newPage) => {
        setPage(newPage);
      };
    
      const handleChangeRowsPerPage = (event) => {
        setRowsPerPage(parseInt(event.target.value, 10));
        setPage(0);
      };

      Moment.locale('en');

    return (
        <Paper className = {classes.paper} elevation={3}>
            <h1 className = {classes.title}>Menu Milk Tea Store</h1>
            <Grid container>
                <Grid item xs={4}>
                    <h2 className = {classes.subTitle1}>Add/Edit Category</h2>
                    <CategoryForm {...({currentId,setCurrentId})}/>
                </Grid>
                <Grid item xs={8}>
                    <h2 className = {classes.subTitle2}>List Categories</h2>
                    <TableContainer>
                        <Table>
                        <TableHead className={classes.root}>
                            <TableRow>
                                <TableCell>Name</TableCell>
                                <TableCell>Desc</TableCell>
                                <TableCell>Date Create</TableCell>
                                <TableCell>Date Update</TableCell>
                                <TableCell>Publised?</TableCell>
                                <TableCell></TableCell>
                            </TableRow>
                        </TableHead>
                        <TableBody>
                        {stableSort(props.dCategoryList)
                        .slice(page * rowsPerPage, page * rowsPerPage + rowsPerPage)
                        .map((record,index)=>{
                                    return(
                                        <TableRow key = {index} hover onClick = {()=>{setSelectId(record.id);setSelectName(record.name)}}>
                                            <TableCell>{record.name}</TableCell>
                                            <TableCell>{record.desc}</TableCell>
                                            <TableCell>{Moment(record.createdDate).format('D/MM/yy')}</TableCell>
                                            <TableCell>{Moment(record.updatedDate).format('D/MM/yy')}</TableCell>
                                            <TableCell>
                                                <Checkbox checked = {record.published}></Checkbox>
                                            </TableCell>
                                            <TableCell id ="button">
                                                <ButtonGroup>
                                                    <Button><EditIcon color = "primary"
                                                         onClick={() => { setCurrentId(record.id) }}
                                                    /></Button>
                                                    <Button><DeleteIcon color = "secondary"
                                                        onClick = {()=>onDelete(record.id)}/></Button>
                                                </ButtonGroup>
                                            </TableCell>
                                        </TableRow>
                                    )
                                })
                            }
                        </TableBody>
                        </Table>
                    </TableContainer>
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
            </Grid>

            <Products {...({selectId,selectName})}/>

        </Paper>
    );
}

const mapActiontoProps = {
    fetchAllCategory:actions.fetchAllCat,
    deleteCategory :actions.deleteCat,
    
}
const mapStateToProps = state=>({
    dCategoryList: state.dCategory.list
})
export default connect(mapStateToProps,mapActiontoProps)(withStyles(styles)(Categories));