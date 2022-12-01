import { useEffect } from "react";

export const CitiesList = ({cities}:any) => {

  useEffect(() => {
    console.log(cities)
  }, [])


  return (
    <>
      <h1>Ciudades</h1>
    </>
  );
};
