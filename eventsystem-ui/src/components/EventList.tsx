import React, { useState, useEffect, useContext} from 'react';
import axios from 'axios';
import { Endpoints } from '../endpoints';
import { EventSystemContext } from "../context/EventSystemContext";
import TextPreview from './TextPreview';


interface EventProps {
    id: number;
    title: string,
    date: string,
    status: number,
    description: string,
    place: string
}

const EventList: React.FC = () => {
    // const [events, setEvents] = useState<EventProps[]>([]);
    const context = useContext(EventSystemContext);
    const loading  = context.loading
    const events: EventProps[] = context?.events || [];
    
    // useEffect(() => {

    //     const fetchData = async () => {
    //       try {
    //         const response = await axios.get(Endpoints.MAIN_URL + Endpoints.events_all);
    //         setEvents(response.data);
    //       } catch (error) {
    //         console.error('Error fetching data:', error);
    //       }
    //     };
    
    //     // fetchData();
    //   }, []);

      // console.log("context", context?.name)
      console.log("context events", context?.events)
      console.log("context loading", context.loading)

    return (
        <>
      { loading ? (
        <div><TextPreview/></div>
      ) : (
          <div>
            <div>Events</div>
            <div>
                {events.map((e) => (
                    <div>
                        Id - {e.id}
                        description - {e.description}
                    </div>
                    ))
                }
            </div>

          </div>
      )}   




        </>

    )
}

export default EventList;