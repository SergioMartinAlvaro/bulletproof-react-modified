import { Route, Routes } from 'react-router-dom';
import { Reducer, useEffect, useMemo, useReducer, useRef } from 'react';
import { CityList } from './CommunityList';

export const CitiesRoutes = () => {
  useEffect(() => {
    console.log('Cargo ruta cities')
  },[])
  
  return (
      <Routes>
        <Route path="" element={<CityList />} />
      </Routes>
  );
};
