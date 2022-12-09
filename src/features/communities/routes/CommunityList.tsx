import { useNavigate } from 'react-router-dom';

import { Layout } from '../components/Layout';
import { CommunitiesList } from '../components/CommunitiesList';
import { useEffect, useState } from 'react';
import { useGetCommunities } from '../api/getCommunities';
import { MainLayout } from '@/components/Layout';

export const CommunityList = (cityId:string) => {

  const communities = useGetCommunities({cityId});

  return (
    <Layout title="Listado de Comunidades">
      <CommunitiesList communities={{communities}} />
    </Layout>
  );
};
