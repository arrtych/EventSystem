import React, { useContext, useState, useEffect } from 'react';
import { EventSystemContext } from '../../context/EventSystemContext';


const Content : React.FC = () => {
    const context = useContext(EventSystemContext);
    // const [page, setPage] = useState(context.page);
    // const { page } = useContext(EventSystemContext);
    const page = context.page;
    // useEffect(() => {
    //     setPage(context.page);
    //     console.log("context page", context.page)
    // }, [context.page]);
    console.log("t", page)
    return (
        <>
            {page === 0 ? (
                <div>Main Page</div>
            ): (
                <div>Second Page12</div>
            )}
        </>
    );
};

export default Content;