import React from 'react';
import '../styles/layout.css';
import { Link } from 'react-router-dom'

export default props => (
    <header>
        <ul>
            <li><Link to='/'>Home</Link></li>
            <li><Link to='/recipe'>Recipes</Link></li>
        </ul>
    </header>
);
