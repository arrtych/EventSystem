import { Box, Grid, Paper } from '@mui/material';
import React from 'react';
import { styled } from '@mui/material/styles';
import Header from './Header';
import Content from './Content';
import EventList from '../EventList';
import CustomTabs from '../CustomTabs';

// const Item = styled(Paper)(({ theme }) => ({
//     backgroundColor: theme.palette.mode === 'dark' ? '#1A2027' : '#fff',
//     ...theme.typography.body2,
//     padding: theme.spacing(1),
//     textAlign: 'center',
//     color: theme.palette.text.secondary,
//   }));

const Layout : React.FC = () => {

    const tabLabels = ['Avaleht', 'Ürituse lisamine'];
    const tabContent = [
        'Content for Tab 1',
        <EventList/>
      ];
    return (
        // <Box>
        //     <Grid container >
        //         <Grid item xs={8}>
        //             <div style={{backgroundColor: "red"}}>xs-8</div>
        //         </Grid>
        //         <Grid item xs={4}>
        //             <div style={{backgroundColor: "green"}}>xs-4</div>
        //         </Grid>
        //         <Grid item xs={4}>
        //             <div style={{backgroundColor: "blue"}}>xs-4</div>
        //         </Grid>
        //         <Grid item xs={8}>
        //             <div style={{backgroundColor: "yellow"}}>xs-8</div>
        //         </Grid>
        //     </Grid>
        // </Box>
        <>
            {/* <Header/> */}
            <CustomTabs labels={tabLabels} content={tabContent} />
            
            {/* <Content/> */}
            
        </>
    )
};

export default Layout;