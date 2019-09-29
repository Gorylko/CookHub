import React from 'react';
import { Link } from 'react-router-dom'

export default class RecipeInfo extends React.Component {
    constructor(props) {
        super(props);
        this.state = { recipe: null, loading: true };

        fetch(`api/recipe/getinfobyid/${props.match.params.number}`)
            .then(data => data.json())
            .then(jsondata => this.setState({ recipe: jsondata, loading: false }));
    }

    render() { 
        console.log("rendering -------");
        console.log(this.state.recipe);
        if (this.state.recipe) {
            return (
                <div>
                    <h1>Recipe info :</h1>
                    <ul>
                        <li>{this.state.recipe.name}</li>
                        <li>{this.state.recipe.description}</li>
                        <li>{this.state.recipe.author.login}</li>
                    </ul>
                </div>
            );
        }
        return <div>Loading...</div>

    }
}