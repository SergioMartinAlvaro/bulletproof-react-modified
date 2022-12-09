import { useEffect, useState } from "react";

export interface CityProps {
  id: string,
  nombre: string,
  created_at: string,
  updated_at: string
}

export const CitiesList = ({cities}:any) => {

  useEffect(() => {
    setCurrentCities(cities.cities.data)
    console.log(cities.cities.data);
  })
  const [currentCities, setCurrentCities] = useState(cities.cities.data);

  return (
    <>
      <h1>Ciudades</h1>
      {currentCities && currentCities.map((city: CityProps) => {
         return <p>{city.nombre}</p>
      })}

    </>
  );
};
