import React, { useContext, useState, useEffect } from "react";
import { EventSystemContext } from "../context/EventSystemContext";
import { Box, Grid } from "@mui/material";
import TextBox from "./TextBox";
import styles from "../styles/section.module.css";
import imageSrc from "../images/pilt.jpg";

const Section: React.FC = () => {
  const context = useContext(EventSystemContext);
  // const [page, setPage] = useState(context.page);
  // const { page } = useContext(EventSystemContext);
  //   const page = context.page;
  // useEffect(() => {
  //     setPage(context.page);
  //     console.log("context page", context.page)
  // }, [context.page]);

  const contentStr =
    "Sed nec elit vestibulum, <bold>tincidunt orci et</bold>, sagittis ex. Vestibulum rutrum <bold>neque suscipit</bold> ante mattis maximus. Nulla non sapien <bold>viverra, lobortis lorem non</bold>, accumsan metus.";

  return (
    <>
      <Box className={styles.contentBox}>
        <Grid container>
          <Grid item xs={6}>
            <TextBox content={contentStr} />
          </Grid>
          <Grid item xs={6}>
            <img className={styles.Image} src={imageSrc} alt="Centered Image" />
          </Grid>
        </Grid>
      </Box>
    </>
  );
};

export default Section;
