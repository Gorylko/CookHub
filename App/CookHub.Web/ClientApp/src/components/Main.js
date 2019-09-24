import React from 'react';
import { Switch, Route } from 'react-router-dom'
import Home from './Home'
import Recipe from './recipe/Recipe'

const Main = () => (
    <main>
        <Switch>
            <Route exact path='/' component={Home} />
            <Route path='/recipe' component={Recipe} />
        </Switch>
    </main>
);

export default Main;