import React, { Component } from 'react';
import CurrencyConvertor from './CurrencyConvertor';

class App extends Component {
  constructor() {
    super();
    this.state = {
      count: 0,
    };
  }

  // Method to increase the count and say hello
  increment = () => {
    this.setState({ count: this.state.count + 1 });
    this.sayHello(); // This calls another method
  };

  decrement = () => {
    this.setState({ count: this.state.count - 1 });
  };

  sayHello = () => {
    alert("Hello! Static message.");
  };

  sayWelcome = (msg) => {
    alert(msg);
  };

  handleSynthetic = () => {
    alert("I was clicked");
  };

  render() {
    return (
      <div style={{ padding: 20 }}>
        <h2>Count: {this.state.count}</h2>

        <button onClick={this.increment}>Increment</button>
        <button onClick={this.decrement}>Decrement</button>

        <br /><br />

        <button onClick={() => this.sayWelcome("welcome")}>
          Say Welcome
        </button>

        <br /><br />

        <button onClick={this.handleSynthetic}>Click on me</button>

        <br /><br />

        <CurrencyConvertor />
      </div>
    );
  }
}

export default App;
