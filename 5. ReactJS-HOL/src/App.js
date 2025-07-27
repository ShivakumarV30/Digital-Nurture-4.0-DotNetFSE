import React, { useState } from 'react';

function App() {
  const [cohorts, setCohorts] = useState([
    {
      id: "INTADMDF10",
      name: ".NET FSD",
      startedOn: "22-Feb-2022",
      currentStatus: "Scheduled",
      coach: "Aathma",
      trainer: "Jojo Jose"
    },
    {
      id: "ADM21JF014",
      name: "Java FSD",
      startedOn: "10-Sep-2021",
      currentStatus: "Ongoing",
      coach: "Apoorv",
      trainer: "Elisa Smith"
    },
    {
      id: "CDBJF21025",
      name: "Java FSD",
      startedOn: "24-Dec-2021",
      currentStatus: "Ongoing",
      coach: "Aathma",
      trainer: "John Doe"
    },
    {
      id: "INTADMJF12",
      name: "Java FSD",
      startedOn: "22-Feb-2022",
      currentStatus: "Scheduled",
      coach: "Ibrahim",
      trainer: "To Be Assigned"
    },
    {
      id: "CDE22JF011",
      name: "Java FSD",
      startedOn: "24-Dec-2021",
      currentStatus: "Ongoing",
      coach: "Apoorv",
      trainer: "Emma Swan"
    },
    {
      id: "INTADMDF09",
      name: "Dataware Housing",
      startedOn: "22-Feb-2022",
      currentStatus: "Scheduled",
      coach: "Aathma",
      trainer: "Babjee Rao"
    },
    {
      id: "ADM22DF001",
      name: ".NET FSD",
      startedOn: "10-Sep-2021",
      currentStatus: "Ongoing",
      coach: "Ibrahim",
      trainer: "Marie Curie"
    }
  ]);

  return (
    <div style={{ padding: '20px', fontFamily: 'Arial, sans-serif' }}>
      <h1>Cohorts Details</h1>
      {cohorts.map(cohort => (
        <div key={cohort.id} style={{ border: '1px solid #ccc', margin: '10px 0', padding: '15px', borderRadius: '5px' }}>
          <h2>{cohort.id} - {cohort.name}</h2>
          <p><strong>Started On:</strong> {cohort.startedOn}</p>
          <p><strong>Current Status:</strong> {cohort.currentStatus}</p>
          <p><strong>Coach:</strong> {cohort.coach}</p>
          <p><strong>Trainer:</strong> {cohort.trainer}</p>
        </div>
      ))}
    </div>
  );
}

export default App;
