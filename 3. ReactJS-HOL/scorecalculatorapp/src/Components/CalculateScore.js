import '../Stylesheets/mystyle.css';

const percentToDecimal = (decimal) => {
  return (decimal * 100) + "%";
};

const calcScore = (total, goal) => {
  return percentToDecimal(total / goal);
};

export const CalculateScore = ({ Name, School, total, goal }) => (
  <div className="container">
    <h1><font color="brown">Student Details:</font></h1>
    <div className="Name">
      <span>Name:</span> <b>{Name}</b>
    </div>
    <div className="School">
      <span>School:</span> <b>{School}</b>
    </div>
    <div className="Total">
      <span>Total:</span> <b>{total}</b>
    </div>
    <div className="Score">
      <span>Score:</span> <b>{calcScore(total, goal)}</b>
    </div>
  </div>
);
