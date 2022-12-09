//import { AuthUser } from '../types';

export const getUser = (): Promise<any> => {
  return axios.get('/api/cities/get-all-cities'
  );
};

import { axios } from '@/lib/axios';
import { ExtractFnReturnType, QueryConfig } from '@/lib/react-query';
import { useQuery } from 'react-query';


export const getCommunities = async (): Promise<any> => {
  return axios.get('/api/cities/get-all-cities', {

  })
}

type QueryFnType = typeof getCommunities;

type GetPopularMoviesOptions = {
  config?: QueryConfig<QueryFnType>
}

export const useGetCommunities = ({config}:any) => {
  return useQuery<ExtractFnReturnType<QueryFnType>>({
    queryKey: [],
    queryFn: () => getCommunities(),
    onError: () => {
      console.error('Issue retrieving cities.')
    },
    ...config,
  });
};