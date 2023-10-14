import React, { Component, useState } from "react";
import './css/bulma'

export default class SearchBar extends Component {
    constructor(props) {
        super(props);
        this.listRef = React.createRef();
    }

    state = {
        ingredientsEntered: []
    };

    handleKeyDown = (e) => {
        if (e.key === 'Enter') {
            var inputField = document.getElementById("ingredientSearchField");
            this.state.ingredientsEntered.push(inputField.value);
            this.setState({ingredientsEntered: this.state.ingredientsEntered});
            inputField.value = "";
        }
    }

    render() {
        return (
            <>
                <div className="field is-grouped searchBar">
                    <p className="control is-expanded">
                        <input className="input" type="text" id="ingredientSearchField" onKeyDown={this.handleKeyDown} placeholder="You have me!"/>
                    </p>
                    <p className="control">
                        <a className="button is-info">
                        Find me a recipe
                        </a>
                    </p>
                    </div>  

                    <div>
                        {this.state.ingredientsEntered.map(ingredient => {
                            return (
                                    <span className="tag">
                                        {ingredient}
                                        <button className="delete"></button>
                                    </span>
                            );
                        })}
                    </div>
            </>
        );
    }
}