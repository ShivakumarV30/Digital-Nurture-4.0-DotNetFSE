import React, { Component } from 'react';

class CurrencyConvertor extends Component {
  constructor() {
    super();
    this.state = {
      amount: '',
      convertedAmount: '',
    };
  }

  handleChange = (e) => {
    this.setState({ [e.target.name]: e.target.value });
  };

  handleSubmit = (e) => {
    e.preventDefault(); // Prevents page reload
    const rupees = parseFloat(this.state.amount);
    const euros = (rupees / 90).toFixed(2); // Assume 1 Euro = ₹90
    alert(`Converting to Euro: amount is ${euros}`);
  };

  render() {
    return (
      <div>
        <h2 style={{ color: 'green' }}>Currency Convertor!!!</h2>
        <form onSubmit={this.handleSubmit}>
          <label>
            Amount:
            <input
              type="text"
              name="amount"
              value={this.state.amount}
              onChange={this.handleChange}
            />
          </label>
          <br />
          <label>
            Currency:
            <input type="text" name="currency" value="Euro" readOnly />
          </label>
          <br />
          <button type="submit">Submit</button>
        </form>
      </div>
    );
  }
}

export default CurrencyConvertor;
