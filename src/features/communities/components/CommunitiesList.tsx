import { useEffect, useState } from "react";

export interface CityProps {
  id: string,
  nombre: string,
  created_at: string,
  updated_at: string
}

export const CommunitiesList = ({communities}:any) => {

  useEffect(() => {
    setCurrentCommunities(communities.communities.data)
  })
  const [currentCommunities, setCurrentCommunities] = useState(communities.communities.data);

  return (
    <>
      <h1>Comunidades</h1>
      {currentCommunities && currentCommunities.map((community: CityProps) => {
         return <p>{community.nombre}</p>
      })}

    </>
  );
};
