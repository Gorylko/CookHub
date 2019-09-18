import React from 'react';

export class RecipeList extends React.Component{
    constructor(props){
        super(props);
        fetch('api/Recipe/GetList')
            .then(data => data.json)
            .then(recipes => {
                this.state = { list: recipes }
            });
    }

    renderRecipes = props => {
        re
    }

    render() {
        return (
            <>
                {
                    
                }
            </>
            );
    }
}