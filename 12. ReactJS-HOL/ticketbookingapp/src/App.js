import React, { useState } from 'react';

function LoginButton(props) {
  return (
    <button onClick={props.onClick}>Login</button>
  );
}

function LogoutButton(props) {
  return (
    <button onClick={props.onClick}>Logout</button>
  );
}

function UserGreeting() {
  return <h2>Welcome back</h2>;
}

function GuestGreeting() {
  return <h2>Please sign up.</h2>;
}

function Greeting(props) {
  const isLoggedIn = props.isLoggedIn;
  if (isLoggedIn) {
    return <UserGreeting />;
  }
  return <GuestGreeting />;
}

function FlightDetails() {
  return (
    <div>
      <h3>Available Flights</h3>
      <ul>
        <li>Flight 101: NYC → London</li>
        <li>Flight 202: Paris → Tokyo</li>
      </ul>
    </div>
  );
}

function BookingSection() {
  return (
    <div>
      <h3>Book Your Ticket</h3>
      <p>[Booking form placeholder]</p>
    </div>
  );
}

function App() {
  const [isLoggedIn, setIsLoggedIn] = useState(false);

  const handleLoginClick = () => setIsLoggedIn(true);
  const handleLogoutClick = () => setIsLoggedIn(false);

  let button;
  if (isLoggedIn) {
    button = <LogoutButton onClick={handleLogoutClick} />;
  } else {
    button = <LoginButton onClick={handleLoginClick} />;
  }

  return (
    <div style={{ padding: '20px', fontFamily: 'Arial' }}>
      <Greeting isLoggedIn={isLoggedIn} />
      {button}
      <br /><br />
      <FlightDetails />
      <br />
      {isLoggedIn && <BookingSection />}
    </div>
  );
}

export default App;
