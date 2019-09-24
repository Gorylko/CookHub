import React from 'react'
import { Switch, Route } from 'react-router-dom'
import RecipeList from './RecipeList'
import RecipeInfo from './RecipeInfo'

const Recipe = (props) => (
    <Switch>
        <Route exact path='/recipe' component={RecipeList} />
        <Route path='/recipe/:number' component={RecipeInfo} />
    </Switch>
);

export default Recipe;