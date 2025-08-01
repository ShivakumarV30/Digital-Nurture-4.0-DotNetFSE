import React from "react";
import ListOfPlayers from "./ListOfPlayers";
import ScoreBelow70 from "./ScoreBelow70";
import { OddPlayers, EvenPlayers, ListofIndianPlayers } from "./IndianPlayers";

const players = [
  { name: "Jack", score: 50 },
  { name: "Michael", score: 70 },
  { name: "John", score: 61 },
  { name: "Ari", score: 40 },
  { name: "Elisabeth", score: 61 },
  { name: "Sachin", score: 55 },
  { name: "Dhoni", score: 100 },
  { name: "Virat", score: 60 },
  { name: "Jadeja", score: 64 },
  { name: "Raina", score: 75 },
  { name: "Rohit", score: 80 },
];

const T20Players = ["Kohli", "Rohit", "Hardik"];
const RanjiTrophyPlayers = ["Prithvi", "Sarfaraz", "Shaw"];

const IndianPlayers = [...T20Players, ...RanjiTrophyPlayers]; // Merged using spread
var flag = false; // 🔁 Change to false to show Indian players instead

function App() {
  if (flag) {
    return (
      <div className="App">
        <h1>List of Players</h1>
        <ListOfPlayers players={players} />

        <h1>List of Players having Scores Less than 70</h1>
        <ScoreBelow70 players={players} />
      </div>
    );
  } else {
    return (
      <div className="App">
        <h1>Indian Team</h1>
        <OddPlayers IndianTeam={IndianPlayers} />
        <EvenPlayers IndianTeam={IndianPlayers} />

        <h1>List of Indian Players Merged:</h1>
        <ListofIndianPlayers IndianPlayers={IndianPlayers} />
      </div>
    );
  }
}

export default App;
