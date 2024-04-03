import React, { useContext, useState, useEffect } from "react";
import { Tabs, Tab, Paper, Typography, Box, Grid } from "@mui/material";
import styles from "../styles/customTabs.module.css";
import { EventSystemContext } from "../context/EventSystemContext";
import { ReactComponent as Logo } from "../icons/logo.svg";
import { ReactComponent as Symbol } from "../icons/symbol.svg";

interface TabsComponentProps {
  labels: string[];
  content: React.ReactNode[];
}

const CustomTabs: React.FC<TabsComponentProps> = ({ labels, content }) => {
  const [value, setValue] = useState(0);
  const context = useContext(EventSystemContext);
  const handleChange = (event: React.SyntheticEvent, newValue: number) => {
    setValue(newValue);
    // if()

    context.page = newValue;
    console.log("context.page", context.page);
  };

  useEffect(() => {
    context.page = value;
    console.log("tab value", value);
  }, []);
  return (
    <>
      <Box
        className={styles.mainBox}
        // sx={{ width: "100%", bgcolor: "background.paper" }}
      >
        <Grid container style={{ border: "1px solid black" }}>
          <Grid item xs={3} className={styles.GridItem}>
            <Logo />
          </Grid>

          <Grid item xs={7} className={styles.GridItem}>
            <Tabs
              value={value}
              onChange={handleChange}
              // centered
              sx={{
                "& .MuiTabs-indicator": {
                  display: "none",
                },
              }}
            >
              {labels.map((label, index) => (
                <Tab
                  sx={{
                    fontFamily: "Arial",
                    fontWeight: "bold",
                    "&.Mui-selected": {
                      backgroundColor: "#005aa1",
                      color: "white",
                    },
                    "&:not(.Mui-selected)": {
                      color: "#444444",
                    },
                    minHeight: "85px",
                  }}
                  key={index}
                  label={label}
                />
              ))}
            </Tabs>
          </Grid>

          <Grid item xs={2} className={styles.GridItemEnd}>
            <Symbol />
          </Grid>
        </Grid>
        <Grid container style={{ border: "1px solid black" }}>
          {content.map((tabContent, index) => (
            <div key={index} hidden={value !== index}>
              {value === index && (
                <div>
                  <div className={styles.title}>{tabContent}</div>
                  <div>Context {context.page}</div>
                </div>
              )}
            </div>
          ))}
        </Grid>
      </Box>
    </>
  );
};

export default CustomTabs;
