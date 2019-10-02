import React from 'react';
import { Link } from 'react-router-dom'

export default class RecipeList extends React.Component {
    constructor(props) {
        super(props);
        this.state = { list: [], loading: true };
        fetch('api/Recipe/GetList')
            .then(data => data.json())
            .then(data => {
                this.setState({ list: data, loading: false });
            });
        console.log(this.state.list);
    }


    render() {
        return (
            <div>
                <h1>All Recipes :</h1>
                <ul>
                    {this.state.list.map((recipe, i) =>
                        <li key={i}><Link to={`/recipe/${recipe.id}`}>{recipe.name}</Link></li>
                    )}
                </ul>
            </div>
        );
    }
}