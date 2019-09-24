import React from 'react';
import '../styles/layout.css';
import { Link } from 'react-router-dom'

export default props => (
    <header>
        <ul>
            <li><Link to='/'>Home</Link></li>
            <li><Link to='/recipelist'>RecipeList</Link></li>
        </ul>
    </header>
);
