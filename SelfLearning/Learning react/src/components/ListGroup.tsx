import { Fragment, useState } from "react";

interface ListGroupProps {
    items: string[];
    heading: string;
    onSelectedItem: (item: string) => void;
}

function ListGroup({items, heading, onSelectedItem}: ListGroupProps){
    // hook
    const [selectedItem, setSelectedItem] = useState(0); 

    return (
    <Fragment>
        <h1>{heading}</h1>
        <ul className="list-group">
            {items.map((item, id) => (
            <li 
            className={id == selectedItem ? "list-group-item active" : "list-group-item"}
            key = {id} 
            onClick={() => { 
                setSelectedItem(id);
                onSelectedItem(item);
            }}>
                    {item}
            </li>))}
        </ul>
    </Fragment>
    );
}

export default ListGroup;
