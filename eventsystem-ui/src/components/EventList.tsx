import React, { useState, useEffect} from 'react';
import axios from 'axios';
import { Endpoints } from '../endpoints';


interface EventProps {
    id: number;
    title: string,
    date: string,
    status: number,
    description: string,
    place: string
}

const EventList: React.FC = () => {
    const [events, setEvents] = useState<EventProps[]>([]);
    useEffect(() => {

        const fetchData = async () => {
          try {
            const response = await axios.get(Endpoints.MAIN_URL + Endpoints.events_all);
            setEvents(response.data);
          } catch (error) {
            console.error('Error fetching data:', error);
          }
        };
    
        fetchData();
      }, []);


    return (
        <>
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
        </>

    )
}

export default EventList;