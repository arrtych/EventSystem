import React from 'react';
import { Tabs, Tab, Paper, Typography, Box  } from '@mui/material';
import styles from "../styles/customTabs.module.css";

interface TabsComponentProps {
  labels: string[];
  content: React.ReactNode[];
}

const CustomTabs: React.FC<TabsComponentProps> = ({ labels, content  }) => {
  const [value, setValue] = React.useState(0);

  const handleChange = (event: React.SyntheticEvent, newValue: number) => {
    setValue(newValue);
  };

  return (
    <>
         <Box sx={{ width: '100%', bgcolor: 'background.paper' }}>
            <Tabs value={value} onChange={handleChange} centered
                  sx={{
                    '& .MuiTabs-indicator': {
                      display: 'none',
                    },
                  }}
            >
                {labels.map((label, index) => (
                <Tab 
                    sx={{
                        fontFamily: 'Arial',
                        fontWeight: 'bold',
                        '&.Mui-selected': {
                            backgroundColor: '#005aa1', 
                            color: 'white'
                        },
                        '&:not(.Mui-selected)': {
                            color: '#444444',
                        },
                    }}

                    key={index} 
                    label={label} 
                
                />
                ))}
            </Tabs>
        </Box>
        {content.map((tabContent, index) => (
            <div key={index} hidden={value !== index}>
            {value === index && 
                <div className={styles.title}>{tabContent}</div>
            }
            </div>
        ))}
    </>


    
  );
};

export default CustomTabs;