

//importação de pacotes
import React from 'react';
import ReactDOM from 'react-dom';
import {Route, BrowserRouter as Router, Switch} from 'react-router-dom';

//importação das pages
import './index.css';
import App from './Pages/Home/App';
import Livros from '../src/Pages/livros/livros';


import reportWebVitals from './reportWebVitals';

const rout = (
  <Router>
    <div>
      <Switch>
        <Route exact path="/" component={App}/>   {/* renderização da pg home */} 
        <Route path="/livros" component={Livros}/>   {/* renderização da pg livros */} 
        <Route path="/notFound" component={notFound}/>   {/* renderização da pg notFound */} 
        <Route path="/" component={App}/>   {/* renderização da pg home */} 
        <Route path="/" component={App}/>   {/* renderização da pg home */} 
        <Route path="/" component={App}/>   {/* renderização da pg home */} 
        <Route path="/" component={App}/>   {/* renderização da pg home */} 
        
      </Switch>
    </div>
  </Router>
)

ReactDOM.render( rout,
  document.getElementById('root')
);

// If you want to start measuring performance in your app, pass a function
// to log results (for example: reportWebVitals(console.log))
// or send to an analytics endpoint. Learn more: https://bit.ly/CRA-vitals
reportWebVitals();
