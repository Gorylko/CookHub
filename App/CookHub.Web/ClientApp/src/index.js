import 'bootstrap/dist/css/bootstrap.css';
import 'bootstrap/dist/css/bootstrap-theme.css';
import './index.css';
import React from 'react';
import ReactDOM from 'react-dom';
import { BrowserRouter } from 'react-router-dom';
import { ConnectedRouter } from 'react-router-redux';
import { createBrowserHistory } from 'history';
import App from './App';
import registerServiceWorker from './registerServiceWorker';

// Create browser history to use in the Redux store


const rootElement = document.getElementById('root');

ReactDOM.render(
    <BrowserRouter>
      <App />
    </BrowserRouter>,
  rootElement);

registerServiceWorker();
