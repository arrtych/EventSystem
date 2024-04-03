import { Box, Grid, Paper } from "@mui/material";
import React from "react";
import { styled } from "@mui/material/styles";
import Header from "./Header";

import EventList from "../EventList";
import CustomTabs from "../CustomTabs";

const Layout: React.FC = () => {
  const tabLabels = ["Avaleht", "Ürituse lisamine"]; // todo: to context
  const tabContent = ["Content for Tab 1", <EventList />];
  return (
    <>
      <CustomTabs labels={tabLabels} content={tabContent} />
      {/* Footer */}
    </>
  );
};

export default Layout;
