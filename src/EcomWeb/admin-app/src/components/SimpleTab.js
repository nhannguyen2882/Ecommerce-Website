import React from 'react';
import PropTypes from 'prop-types';
import { makeStyles } from '@material-ui/core/styles';
import AppBar from '@material-ui/core/AppBar';
import Tabs from '@material-ui/core/Tabs';
import Tab from '@material-ui/core/Tab';
import Typography from '@material-ui/core/Typography';
import Box from '@material-ui/core/Box';
import Categories from './Categories';
import {withStyles}from "@material-ui/core";
import bluegrey from '@material-ui/core/colors/bluegrey';

import { styled } from '@material-ui/core/styles';


const MyAppBar = styled(({ color, ...other }) => <AppBar {...other} />)({
  background: (props) =>
    props.color === "bluegrey"
      ? 'linear-gradient(45deg, #37474f 30%, #263238 90%)'
      : 'linear-gradient(45deg, #2196F3 30%, #21CBF3 90%)',
  border: 0,
  borderRadius: 3,
  boxShadow: (props) =>
    props.color === "bluegrey"
      ? '#cfd8dc'
      : '#cfd8dc',
  color: 'white',
  height: 48,
  padding: '0 30px',
  margin: 8,
  position: "static"
});
const dark = bluegrey[900]

function TabPanel(props) {
  const { children, value, index, ...other } = props;

  return (
    <div
      role="tabpanel"
      hidden={value !== index}
      id={`simple-tabpanel-${index}`}
      aria-labelledby={`simple-tab-${index}`}
      {...other}
    >
      {value === index && (
        <Box p={3}>
          <Typography>{children}</Typography>
        </Box>
      )}
    </div>
  );
}

TabPanel.propTypes = {
  children: PropTypes.node,
  index: PropTypes.any.isRequired,
  value: PropTypes.any.isRequired,
};

function a11yProps(index) {
  return {
    id: `simple-tab-${index}`,
    'aria-controls': `simple-tabpanel-${index}`,
  };
}

const useStyles = makeStyles((theme) => ({
  root: {
    flexGrow: 1,
    backgroundColor: theme.palette.background.paper,
  },
}));

const SimpleTabs = () => {
  const classes = useStyles();
  const [value, setValue] = React.useState(0);

  const handleChange = (event, newValue) => {
    setValue(newValue);
  };

  return (
    <div className={classes.root}>
      <MyAppBar color="bluegrey">
        <Tabs value={value} onChange={handleChange} aria-label="simple tabs example" >
          <Tab label="Categories" {...a11yProps(0)} />
          <Tab label="Order Bill" {...a11yProps(1)} />
        </Tabs>
      </MyAppBar>
      <TabPanel value={value} index={0}>
        <Categories/>
      </TabPanel>
      <TabPanel value={value} index={1}>
        Item Two
      </TabPanel>
    </div>
  );
}
export default SimpleTabs