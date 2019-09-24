import React from 'react';
import { Switch, Route } from 'react-router-dom'
import Home from './Home'
import RecipeList from './recipe/RecipeList'

const Main = () => (
    <main>
        <Route exact path='/' component={Home} />
        <Route path='/recipelist' component={RecipeList} />

    </main>
);

export default Main;