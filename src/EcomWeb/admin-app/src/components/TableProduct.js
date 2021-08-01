import React,{useState} from "react";
import {TablePagination, Grid , Paper, TableBody, TableCell, TableContainer, TableHead, TableRow, withStyles, Checkbox, Button, ButtonGroup, Table, Tab} from "@material-ui/core";
import { useTable } from "react-table";
import Moment from 'moment';
import DeleteIcon from '@material-ui/icons/delete'
import EditIcon from '@material-ui/icons/edit'

function stableSort(array) {
  const stabilizedThis = array.map((el, index) => [el, index]);
  return stabilizedThis.map((el) => el[0]);
}

const TableProduct = ({columns, data,onDelete, page, rowsPerPage, setCurrentId}) => {
  
  const {
    getTableProps,
    getTableBodyProps,
    headerGroups,
    rows,
    prepareRow,
    state,
  } = useTable({
    columns,
    data,
  });


  const [selectId,setSelectId] = useState(null)


  Moment.locale('en');
  return (
    <Table
            {...getTableProps()}
          >
            <TableHead >
              {headerGroups.map(headerGroup => (
                <TableRow {...headerGroup.getHeaderGroupProps()}>
                  {headerGroup.headers.map(column => (
                    <TableCell style={{fontSize: "1.1rem", fontWeight: "bold"}}
                      {...column.getHeaderProps()}
                    >
                      {column.render("Header")}
                    </TableCell>
                  ))}
                </TableRow>
              ))}
            </TableHead>
            <TableBody>
              {stableSort(rows)
                .slice(page * rowsPerPage, page * rowsPerPage + rowsPerPage)
                .map((record,index)=>{
                      return(
                          <TableRow key = {index} hover onClick = {()=>{setSelectId(record.id)}}>
                              <TableCell>{record.original.name}</TableCell>
                              <TableCell>{record.original.desc}</TableCell>
                              <TableCell>{record.original.price}</TableCell>
                              <TableCell>
                                  <Checkbox checked = {record.original.isFeatured}></Checkbox>
                              </TableCell>
                              <TableCell>{Moment(record.original.createdDate).format('D/MM/yy')}</TableCell>
                              <TableCell>{Moment(record.original.updatedDate).format('D/MM/yy')}</TableCell>
                              <TableCell>
                                  <Checkbox checked = {record.original.published}></Checkbox>
                              </TableCell>
                              <TableCell>
                                  <ButtonGroup>
                                      <Button><EditIcon color = "primary"
                                            onClick={() => { setCurrentId(record.original.id) }}
                                      /></Button>
                                      <Button><DeleteIcon color = "secondary"
                                          onClick = {()=>onDelete(record.original.id)}/></Button>
                                  </ButtonGroup>
                              </TableCell>
                          </TableRow>
                      )
                })
              }
            </TableBody>
            </Table>
    
      
  );
};
export default TableProduct;