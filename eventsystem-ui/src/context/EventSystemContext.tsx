import { createContext, useContext,useEffect, useState,  ReactNode } from 'react';
import axios from 'axios';
import { Endpoints } from '../endpoints';

// interface EventSystemContextProps {
//     name: string,
//     events: [],
// }
  
//   export const EventSystemContext = createContext<EventSystemContextProps | undefined>(undefined);
  export const EventSystemContext = createContext ({
    // name: "",
    events: [],
  })
  
  export const EventSystemContextProvider: React.FC<{ children: ReactNode }> = ({ children }) => {
    const [events, setEvents] = useState([])
    // const [name, setName] = useState([])

    // Define your context state and functions here
    // const value: EventSystemContextProps = {
    //   name: 'some name',
    //   events: []
    // };

    const fetchData = async () => {
        try {
          const response = await axios.get(Endpoints.MAIN_URL + Endpoints.events_all);
          setEvents(response.data);
        //   setName("name");
          console.log("response", response.data)
        //   value.events = response.data;
        } catch (error) {
          console.error('Error fetching data:', error);
        }
      };

    useEffect(() => {


    
        fetchData();
      }, []);
  
    return <EventSystemContext.Provider value={{ events }}>{children}</EventSystemContext.Provider>;
  };
  
  export const useMyContext = () => {
    const context = useContext(EventSystemContext);
    if (!context) {
      throw new Error('useMyContext must be used within a MyContextProvider');
    }
    return context;
  };
  