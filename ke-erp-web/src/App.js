import React, { useEffect, useState } from 'react';
import logo from './logo.svg';
import './App.css';
import axios from 'axios';
function App() {

  const [persons, setPersons] = useState([]);
  
  useEffect(() => {

    axios.get('http://localhost/api/Touchpoints')
      .then(res => {
        setPersons(res.data);
      });

  }, []);

  return (
    <div className="App">
      <header className="App-header">        
        {
          persons.map(item => {
            return <div key={item.touchpointId}>{item.toucpointName}</div>
          })
        }
      </header>
    </div>
  );
}

export default App;
