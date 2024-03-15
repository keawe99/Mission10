import { Bowling } from './Bowling'; // Adjust the path as needed

export type Team = {
  teamId: number;
  teamName: string;
  captainId?: number | null;
  bowlers: Bowling[];
};
