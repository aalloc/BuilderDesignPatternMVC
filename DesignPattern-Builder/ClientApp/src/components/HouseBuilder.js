import React, { Component } from 'react';

export class HouseBuilder extends Component {
    static displayName = HouseBuilder.name;

    constructor(props) {
      super(props)
    
      this.state = {
            products: [], loading: true
      };
      
    this.onAddItem  = this.onAddItem.bind(this);

    fetch('api/HouseBuilder/DefaultHouses')
        .then(response => response.json())
        .then(data => {
            this.setState({ products: data, loading: false, type : "modern" });
    });
     
    };
    onAddItem(event, type){
        fetch("api/HouseBuilder/GetHouse?id=" + type)
        .then(response => response.json())
        .then((data)=> {
            var products = this.state.products;
            this.state.products.push(data);
            this.setState({products : products, loading: false});
            
        });
        event.preventDefault();
    }
    render() {
        const ulStyle = {
            listStyle : "None",
          };
        return (
            <div>
                <h1>House Builder App</h1>
                {/* <ul style={{ulStyle}}>
                    {this.state.products.map(item=>(
                        <li key={item.id}>
                            {item.displayText}
                        </li>
                    ))}
                </ul> */}
                <button
                    type="button"
                    name="modern"
                    onClick={(e) => {this.onAddItem(e, "modern")}}
                >
                    Consruct Modern House
                </button>
                <button
                    type="button"
                    name="igloo"
                    onClick={(e) => {this.onAddItem(e, "igloo")}}
                >
                    Consruct Igloo House
                </button>

                <ul style={ulStyle}>
                        {this.state.products.map(item=>(
                            <li key={item.id} style={{float:"left"}}>
                                <div>
                                    <img src={item.imageUrl} style={{width:"50px"}}></img>
                                    <p>{item.structure} <br/>
                                     {item.rooms}<br/>
                                     {item.roof}<br/>
                                     {item.garage}<br/>
                                     {item.interior}<br/>
                                     </p>
                                </div>
                            </li>
                        ))}
                    </ul>
            </div>
        );
    }
}

 