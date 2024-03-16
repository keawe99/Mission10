export type Bowling = {
  bowlerId: number;
  bowlerLastName: string;
  bowlerFirstName: string;
  bowlerMiddleInit: string;
  bowlerAddress: string;
  bowlerCity: string;
  bowlerState: string;
  bowlerZip: number;
  bowlerPhoneNumber: number;
  teamId: number;
  team: {
    teamId: number;
    teamName: string;
    captainId: number;
    bowlers: [];
    tourneyMatchEvenLaneTeams: [];
    tourneyMatchOddLaneTeams: [];
  };
};
