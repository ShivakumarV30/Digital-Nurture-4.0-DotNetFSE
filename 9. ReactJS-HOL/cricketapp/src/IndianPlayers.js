import React from "react";

// ✅ Fix: destructure from props and then use array destructuring
export function OddPlayers({ IndianTeam }) {
  const [first, , third, , fifth] = IndianTeam;
  return (
    <div>
      <h3>Odd Position Players:</h3>
      <ul>
        <li>{first}</li>
        <li>{third}</li>
        <li>{fifth}</li>
      </ul>
    </div>
  );
}

export function EvenPlayers({ IndianTeam }) {
  const [, second, , fourth, , sixth] = IndianTeam;
  return (
    <div>
      <h3>Even Position Players:</h3>
      <ul>
        <li>{second}</li>
        <li>{fourth}</li>
        <li>{sixth}</li>
      </ul>
    </div>
  );
}

export function ListofIndianPlayers({ IndianPlayers }) {
  return (
    <div>
      <ul>
        {IndianPlayers.map((player, index) => (
          <li key={index}>{player}</li>
        ))}
      </ul>
    </div>
  );
}
