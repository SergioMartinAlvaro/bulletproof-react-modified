import { useNavigate } from 'react-router-dom';

import { Layout } from '../components/Layout';
import { CitiesList } from '../components/CitiesList';
import { useEffect, useState } from 'react';
import { useGetCities } from '../api/getCities';
import { MainLayout } from '@/components/Layout';

export const CityList = () => {
  useEffect(() => {
    console.log('hola')
  }, [])

  const cities = useGetCities({});

  return (
    <Layout title="Listado de Ciudades">
      <CitiesList cities={{cities}} />
    </Layout>
  );
};
