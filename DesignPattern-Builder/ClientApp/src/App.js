import React, { Component } from 'react';
import { Route } from 'react-router';
import { Layout } from './components/Layout';
import { Home } from './components/Home'; 
import { Counter } from './components/Counter';
import { HouseBuilder } from './components/HouseBuilder';
import { MealBuilder } from './components/MealBuilder';
export default class App extends Component {
  static displayName = App.name;

  render () {
    return (
      <Layout>
        <Route exact path='/' component={Home} />
        <Route exact path='/counter' component={Counter} />
        <Route path='/housebuilder' component={HouseBuilder} />
        <Route path='/mealbuilder' component={MealBuilder} />
      </Layout>
    );
  }
}
