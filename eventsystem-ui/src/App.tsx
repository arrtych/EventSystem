import React from 'react';
import './App.css';
import EventList from './components/EventList';
import CustomTabs from './components/CustomTabs';

function App() {
  const tabLabels = ['Avaleht', 'Ürituse lisamine'];
  const tabContent = [
    'Content for Tab 1',
    <EventList/>
  ];
  return (
    <div className="App">
      <header className="App-header">
        <CustomTabs labels={tabLabels} content={tabContent} />
      </header>
    </div>
  );
}

export default App;


// context for all app
// show EventList by event status; or check on backend
// menu tabs. , layout