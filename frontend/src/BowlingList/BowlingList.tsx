import { useCallback, useState } from 'react';
import { Bowling } from '../types/Bowling';

function BowlingList() {
  const [bowlingData, setBowlingData] = useState<Bowling[]>([]);
  const fetchBowlingData = async () => {
    const rsp = await fetch('http://localhost:5023/api/Bowling');
    const b = await rsp.json();
    setBowlingData(b);
  };

  fetchBowlingData();

  return (
    <>
      <div className="row">
        <h4 className="text-center">Best Bowlers in Coney Island</h4>
      </div>
      <table className="table table-bordered">
        <thead>
          <th>Bowler Name</th>
          <th>Team Name</th>
          <th>Address</th>
          <th>City</th>
          <th>State</th>
          <th>Zip Code</th>
          <th>Phone Number</th>
        </thead>
        <tbody>
          {bowlingData.map((b) => (
            <tr key={b.bowlerId}>
              <td>{b.bowlerLastName}</td>
              <td>{b.bowlerFirstName}</td>
              <td>{b.bowlerMiddleInit}</td>
              <td>{b.bowlerAddress}</td>
              <td>{b.bowlerCity}</td>
              <td>{b.bowlerState}</td>
              <td>{b.bowlerZip}</td>
              <td>{b.bowlerPhoneNumber}</td>
            </tr>
          ))}
        </tbody>
      </table>
    </>
  );
}

export default BowlingList;
