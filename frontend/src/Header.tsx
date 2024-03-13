import logo from './BingBongBowling.png';

function Header(props: any) {
  return (
    <>
      <header className="row navbar navbar-light bg-light">
        <div className="col-4">
          <img src={logo} alt="BingBongBowling" />
        </div>
        <div className="col subtitle">
          <h1>
            Welcome Back! We missed you!
            <br />
          </h1>
          <h3>
            Here is a list of all bowlers from the beloved Bowling Database that
            we missed so much.
          </h3>
        </div>
      </header>
    </>
  );
}

export default Header;
