import React from 'react';
import { Link } from 'react-router-dom'

export default class RecipeInfo extends React.Component {
    constructor(props) {
        super(props);
        this.state = { recipe: undefined, loading: true };
        fetch(`api/recipe/getinfobyid/${props.match.params.number}`)
            .then(data => data.json())
            .then(data => {
                this.setState({ recipe: data, loading: false });
            });
        console.log(this.state.list);
    }

    render() {
        return (
            <div>
                <h1>Recipe Info :</h1>
            </div>
        );
    }
}