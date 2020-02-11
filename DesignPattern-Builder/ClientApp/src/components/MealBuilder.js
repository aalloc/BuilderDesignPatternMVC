import React, { Component } from 'react';

export class MealBuilder extends Component {
    static  displayName = MealBuilder.name;
    constructor(props) {
      super(props)
    
      this.state = {
        meals: [], meal:null
      };
      this.onMakeMeal = this.onMakeMeal.bind(this);
    };

    onMakeMeal(event, type){
        fetch("api/MealBuilder/MakeMeal?type=" + type)
        .then(response => response.json())
        .then((data)=> {
            var m = this.state.meals;
            this.state.meals.push(data);

            this.setState({meals : m, loading: false});
            
        });

        event.preventDefault();
    }
  render() {
    const ulStyle = {
        listStyle : "None",
      };
    return (
      <div>
             
                <h1>Meal Builder App</h1>
              
                <button
                    type="button"
                    onClick={(e) => {this.onMakeMeal(e, "kiddie")}}
                >
                   Make Kiddie Meal
                </button>
                <button
                    type="button"
                    onClick={(e) => {this.onMakeMeal(e, "solo")}}
                >
                    Make Solo Meal
                </button>
                <button
                    type="button"
                    onClick={(e) => {this.onMakeMeal(e, "beer")}}
                >
                    Make Beer Set
                </button>
               
                    <ul style={ulStyle}>
                        {this.state.meals.map(item=>(
                            <li key={item.id} style={{float:"left"}}>
                                <div>
                                    <img src={item.imageUrl} style={{width:"50px"}}></img>
                                    <p>{item.appetizer} <br/>
                                     {item.mainCourse}<br/>
                                     {item.drinks}<br/>
                                     {item.veggie}<br/>
                                     {item.dessert}<br/>
                                     </p>
                                </div>
                            </li>
                        ))}
                    </ul>
                 
            </div>
    );
  }
}
