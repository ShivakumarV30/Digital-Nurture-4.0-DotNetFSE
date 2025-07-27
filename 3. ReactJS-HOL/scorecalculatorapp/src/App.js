import logo from './logo.svg';
import './App.css';
import { CalculateScore } from './Components/CalculateScore';

function App() {
  return (
    <div className="App">
      <CalculateScore 
        Name="Steve" 
        School="DAV Public School" 
        total={284} 
        goal={375} 
      />
    </div>
  );
}

export default App;

