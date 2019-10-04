import React from 'react';
import { Link } from 'react-router-dom';
import '../../styles/image.css';

export default class RecipeInfo extends React.Component {
    constructor(props) {
        super(props);
        this.state = { recipe: null, loading: true };

        fetch(`api/recipe/getinfobyid/${props.match.params.number}`)
            .then(data => data.json())
            .then(jsondata => {
                this.setState({ recipe: jsondata, loading: false });
                console.log(jsondata);
            });

    }

    render() { 
        if (this.state.recipe) { 
            return (
                <div>
                    
                    <h1>Recipe info :</h1>
                    <img className="recipe-info-image" src={`data:image/jpeg;base64,${this.state.recipe.images[0].data}`} />

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