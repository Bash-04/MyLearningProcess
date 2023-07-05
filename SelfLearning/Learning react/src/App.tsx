import './App.css'
import Message from './Message.tsx';
import ListGroup from './components/ListGroup.tsx';
import Alert from './components/Alert.tsx';
import Button from './components/Button.tsx';
import { useState } from "react";

function App(){
  var items = ["Amsterdam", "Eindhoven", "New York", "Paris", "Milan"];
  
  const handleSelectedItem = (item: string) => {
    console.log(item);
  }

  const [alertVisible, setAlertVisible] = useState(false);
  
  return (
  <div>
    <Message />
    <ListGroup items={items} heading='Cities' onSelectedItem={handleSelectedItem}/>
    { alertVisible && <Alert onClose={() => setAlertVisible(false)}>OH HI, <span>YOU CLICKED ON MY FRIEND</span>!</Alert>}
    <Button children="Nice button" color='secondary' onClick={() => {console.log("Click"), setAlertVisible(true)}} />
  </div>
  )
}

export default App
