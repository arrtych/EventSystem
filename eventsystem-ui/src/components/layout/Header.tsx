import { Box, Grid } from '@mui/material';
import React from 'react';
// import Logo from "../../icons/logo.svg";
import { ReactComponent as Logo } from "../../icons/logo.svg";
import { ReactComponent as Symbol } from "../../icons/symbol.svg";
import CustomTabs from '../CustomTabs';
import EventList from '../EventList';


const Header : React.FC = () => {
    const tabLabels = ['Avaleht', 'Ürituse lisamine'];
    const tabContent = [
        'Content for Tab 1',
        <EventList/>
      ];

    return (
    <Box>
        <Grid container >   
            <Grid item xs={4}>
                {/* <div style={{backgroundColor: "red"}}>xs-4</div> */}
                <div style={{border: "1px solid black"}}>
                    <Logo/>
                </div>
                
            </Grid>
            <Grid item xs={6}>
                <div style={{border: "1px solid black"}}>
                    <CustomTabs labels={tabLabels} content={tabContent} />
                </div>
            </Grid>
            <Grid item xs={2}>
            <div style={{border: "1px solid black"}}>
                <Symbol/>
            </div>
               
            </Grid>
        </Grid>
    </Box>
    )
};

export default Header;