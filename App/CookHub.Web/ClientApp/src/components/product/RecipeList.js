import React from 'react';

export class RecipeList extends React.Component{
    constructor(props){
        super(props);
        this.state = { list: [], loading: true };
        fetch('api/Recipe/GetList')
            .then(data => data.json())
            .then(data => {
                this.setState({ list: data, loading: false });
            });
        console.log(this.state.list);
    }

    //renderRecipes = recipes => {
    //    return (

    //        );
    //}

    render() {
        return (
            <div>
                <h1>All Recipes :</h1>
                {this.state.list.map(recipe =>
                    <p>{recipe.name}</p>
                )}
            </div>
            );
    }
}